using Negocio.DTOs;
using Negocio.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Deposito
{
    public partial class FrmReporteMovimientos : Form
    {
        private readonly ReporteMovimientosService _service = new ReporteMovimientosService();

        public FrmReporteMovimientos()
        {
            InitializeComponent();
            dtpDesde.Value = DateTime.Today;
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvReporte.AutoGenerateColumns = false;
            dgvReporte.Columns.Clear();

            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaHora",
                DataPropertyName = "FechaHora",
                HeaderText = "Fecha y hora",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" },
                Width = 130
            });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Detalle",
                DataPropertyName = "Detalle",
                HeaderText = "Detalle",
                Width = 220
            });
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Ventas", "Ventas", Color.FromArgb(29, 78, 216), false));
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Entrada", "Entrada", Color.FromArgb(15, 118, 110), false));
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Compras", "Compras", Color.FromArgb(180, 83, 9), false));
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Salidas", "Salidas", Color.FromArgb(185, 28, 28), false));
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Saldo", "Saldo", Color.FromArgb(15, 111, 98), true));
        }

        private DataGridViewColumn NuevaColumnaMoneda(string nombre, string encabezado, Color color, bool negrita)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = nombre,
                DataPropertyName = nombre,
                HeaderText = encabezado,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    NullValue = "",
                    ForeColor = color,
                    Font = negrita ? new Font("Segoe UI", 9F, FontStyle.Bold) : null
                },
                Width = 90
            };
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var datos = _service.ObtenerReporte(dtpDesde.Value.Date);
                dgvReporte.DataSource = datos;
                ActualizarKpis(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ActualizarKpis(List<ReporteMovimientoRow> datos)
        {
            lblValVentas.Text = datos.Sum(d => d.Ventas ?? 0).ToString("N2");
            lblValEntrada.Text = datos.Sum(d => d.Entrada ?? 0).ToString("N2");
            lblValCompras.Text = datos.Sum(d => d.Compras ?? 0).ToString("N2");
            lblValSalidas.Text = datos.Sum(d => d.Salidas ?? 0).ToString("N2");
            lblValSaldo.Text = (datos.Count > 0 ? datos[datos.Count - 1].Saldo ?? 0 : 0).ToString("N2");
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmRegistrarMovimiento())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    GenerarReporte();
                }
            }
        }
    }
}
