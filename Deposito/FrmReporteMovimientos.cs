using Negocio.DTOs;
using Negocio.Services;
using System;
using System.Collections.Generic;
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
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Ventas", "Ventas"));
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Entrada", "Entrada"));
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Compras", "Compras"));
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Salidas", "Salidas"));
            dgvReporte.Columns.Add(NuevaColumnaMoneda("Saldo", "Saldo"));
        }

        private DataGridViewColumn NuevaColumnaMoneda(string nombre, string encabezado)
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
                    NullValue = ""
                },
                Width = 90
            };
        }

        private void FrmReporteMovimientos_Load(object sender, EventArgs e)
        {

        }

        

        private void MostrarTotales(List<ReporteMovimientoRow> datos)
        {
            lblTotalVentas.Text = datos.Sum(d => d.Ventas ?? 0).ToString("N2");
            lblTotalEntrada.Text = datos.Sum(d => d.Entrada ?? 0).ToString("N2");
            lblTotalCompras.Text = datos.Sum(d => d.Compras ?? 0).ToString("N2");
            lblTotalSalidas.Text = datos.Sum(d => d.Salidas ?? 0).ToString("N2");
            lblSaldoFinal.Text = (datos.Count > 0 ? datos[datos.Count - 1].Saldo ?? 0 : 0).ToString("N2");
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
                MostrarTotales(datos);
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
