using Negocio;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmHistorialAbonos : Form
    {
        private static readonly Font FontTitulo = new Font("Arial", 12, FontStyle.Bold);
        private static readonly Font FontEncabezado = new Font("Arial", 9, FontStyle.Bold);
        private static readonly Font FontTexto = new Font("Arial", 9);
        private static readonly string[] Encabezados = { "ID", "Fecha", "Cliente", "Total", "Cobrado", "Saldo", "Repartidor" };
        private static readonly bool[] AlinearDerecha = { false, false, false, true, true, true, false };
        private static readonly bool[] EsFlexible = { false, false, true, false, false, false, true }; // Cliente y Repartidor se estiran
        private static readonly CultureInfo CulturaGT = CultureInfo.GetCultureInfo("es-GT");

        private List<AbonoImpresion> _abonosImprimir;
        private int _indiceImpresion;
        private float[] _anchosColumnas;

        public frmHistorialAbonos()
        {
            InitializeComponent();
        }

        private void frmHistorialAbonos_Load(object sender, EventArgs e)
        {
            Bs_Cliente.llenarcmbclientetodos(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Bs_Cliente.llenardgvabonos(dataGridView1, int.Parse(listBox1.SelectedValue.ToString()));
            }
            catch (Exception)
            {


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Bs_Cliente.llenarcmbclientefiltro(listBox1, textBox1.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker1.Value.Date;
            DateTime hasta = DateTime.Now;

            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {

                var lst = from abono in db.BIT_ABONOSYSALDOS.AsNoTracking()
                          join cli in db.CLIENTE on abono.IDCLUENTE equals cli.ID
                          where cli.ID == (int)listBox1.SelectedValue && abono.FECHA >= desde && abono.FECHA <= hasta
                          select new
                          {
                              abono.ID,
                              abono.FECHA,
                              cli.NOMBRE,
                              abono.TOTAL,
                              abono.COBRADO,
                              abono.SALDO,
                              abono.REPARTIDOR
                          };

                var lst2 = from lista1 in lst
                           join rep in db.REPARTIDOR on lista1.REPARTIDOR equals rep.ID into repJoin
                           from repartidor in repJoin.DefaultIfEmpty()
                           orderby lista1.FECHA ascending, lista1.ID ascending
                           select new AbonoImpresion
                           {
                               ID = lista1.ID,
                               FECHA = lista1.FECHA,
                               NOMBRE = lista1.NOMBRE,
                               TOTAL = lista1.TOTAL,
                               COBRADO = lista1.COBRADO,
                               SALDO = lista1.SALDO,
                               REPARTIDOR = repartidor != null ? repartidor.NOMBRE : "N/A"
                           };

                _abonosImprimir = lst2.ToList();

            }


            if (_abonosImprimir.Count == 0)
            {
                MessageBox.Show("No hay abonos en el rango de fechas seleccionado.", "Imprimir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _indiceImpresion = 0;

            using (var pd = new PrintDocument())
            {
                pd.DefaultPageSettings.PaperSize = new PaperSize("Carta", 850, 1100); // 8.5 x 11 pulgadas
                pd.DefaultPageSettings.Margins = new Margins(50, 50, 60, 60);
                pd.PrintPage += PdAbonos_PrintPage;

                float anchoDisponible = pd.DefaultPageSettings.PaperSize.Width
                    - pd.DefaultPageSettings.Margins.Left
                    - pd.DefaultPageSettings.Margins.Right;

                _anchosColumnas = CalcularAnchosColumnas(anchoDisponible);

                using (var vistaPrevia = new PrintPreviewDialog())
                {
                    vistaPrevia.Document = pd;
                    vistaPrevia.Width = 900;
                    vistaPrevia.Height = 700;
                    vistaPrevia.ShowDialog();
                }
            }
        }

        private float[] CalcularAnchosColumnas(float anchoDisponible)
        {
            using (var bmp = new Bitmap(1, 1))
            using (var g = Graphics.FromImage(bmp))
            {
                var anchos = new float[Encabezados.Length];

                for (int i = 0; i < Encabezados.Length; i++)
                    anchos[i] = g.MeasureString(Encabezados[i], FontEncabezado).Width;

                foreach (var item in _abonosImprimir)
                {
                    string[] valores =
                    {
                item.ID.ToString(),
                item.FECHA?.ToString("dd/MM/yyyy HH:mm"),
                item.NOMBRE,
                item.TOTAL?.ToString("C2", CulturaGT),
                item.COBRADO?.ToString("C2", CulturaGT),
                item.SALDO?.ToString("C2", CulturaGT),
                item.REPARTIDOR
            };

                    for (int i = 0; i < valores.Length; i++)
                    {
                        float ancho = g.MeasureString(valores[i], FontTexto).Width;
                        if (ancho > anchos[i]) anchos[i] = ancho;
                    }
                }

                const float relleno = 14f;
                for (int i = 0; i < anchos.Length; i++)
                    anchos[i] += relleno;

                float anchoFijo = 0f, anchoFlexibleBase = 0f;
                for (int i = 0; i < anchos.Length; i++)
                {
                    if (EsFlexible[i]) anchoFlexibleBase += anchos[i];
                    else anchoFijo += anchos[i];
                }

                float total = anchoFijo + anchoFlexibleBase;

                if (total >= anchoDisponible)
                {
                    // ni el mínimo cabe: se reduce todo proporcionalmente
                    float factor = anchoDisponible / total;
                    for (int i = 0; i < anchos.Length; i++)
                        anchos[i] *= factor;
                }
                else if (anchoFlexibleBase > 0)
                {
                    // sobra espacio: se reparte entre las columnas flexibles, según su peso
                    float espacioExtra = anchoDisponible - total;
                    for (int i = 0; i < anchos.Length; i++)
                    {
                        if (EsFlexible[i])
                            anchos[i] += espacioExtra * (anchos[i] / anchoFlexibleBase);
                    }
                }
                else
                {
                    // caso raro sin columnas flexibles con contenido: reparto parejo
                    float extra = (anchoDisponible - total) / anchos.Length;
                    for (int i = 0; i < anchos.Length; i++)
                        anchos[i] += extra;
                }

                return anchos;
            }
        }

        private void PdAbonos_PrintPage(object sender, PrintPageEventArgs e)
        {
            var g = e.Graphics;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float altoLinea = FontTexto.GetHeight(g) + 6;

            if (_indiceImpresion == 0)
            {
                g.DrawString($"Reporte de abonos desde {dateTimePicker1.Value:dd/MM/yyyy}", FontTitulo, Brushes.Black, x, y);
                y += FontTitulo.GetHeight(g) + 12;
            }

            float xCol = x;
            for (int i = 0; i < Encabezados.Length; i++)
            {
                DrawCelda(g, Encabezados[i], FontEncabezado, xCol, y, _anchosColumnas[i], AlinearDerecha[i]);
                xCol += _anchosColumnas[i];
            }
            y += altoLinea;
            g.DrawLine(Pens.Black, x, y, x + _anchosColumnas.Sum(), y);
            y += 6;

            while (_indiceImpresion < _abonosImprimir.Count)
            {
                if (y + altoLinea > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                var item = _abonosImprimir[_indiceImpresion];
                string[] valores =
                {
                    item.ID.ToString(),
                    item.FECHA?.ToString("dd/MM/yyyy HH:mm"),
                    item.NOMBRE,
                    item.TOTAL?.ToString("C2", CulturaGT),
                    item.COBRADO?.ToString("C2", CulturaGT),
                    item.SALDO?.ToString("C2", CulturaGT),
                    item.REPARTIDOR
                };

                xCol = x;
                for (int i = 0; i < valores.Length; i++)
                {
                    DrawCelda(g, valores[i], FontTexto, xCol, y, _anchosColumnas[i], AlinearDerecha[i]);
                    xCol += _anchosColumnas[i];
                }

                y += altoLinea;
                _indiceImpresion++;
            }

            e.HasMorePages = false;
        }

        private void DrawCelda(Graphics g, string texto, Font font, float x, float y, float ancho, bool alinearDerecha)
        {
            if (alinearDerecha)
            {
                float anchoTexto = g.MeasureString(texto, font).Width;
                g.DrawString(texto, font, Brushes.Black, x + ancho - anchoTexto - 6, y);
            }
            else
            {
                g.DrawString(texto, font, Brushes.Black, x, y);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idAbono = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            long? idPedido = Bs_Pedido.ObtenerIdPedido(idAbono);

            if (idPedido == null)
            {
                MessageBox.Show("No se encontró el pedido asociado a este abono.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (FormDetallePedido frm = new FormDetallePedido(idPedido.Value))
            {
                frm.ShowDialog();
            }
        }
    }
}
