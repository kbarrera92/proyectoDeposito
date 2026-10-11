using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Negocio;
using Negocio.DTOs;

namespace Deposito
{
    public partial class frmCxP : frmBase
    {
        private const int DiasPorVencer = 7;

        private static readonly Color ColorNormal = Color.FromArgb(31, 41, 55);
        private static readonly Color ColorVencida = Color.FromArgb(185, 28, 28);
        private static readonly Color ColorPorVencer = Color.FromArgb(180, 83, 9);

        private List<CuentaPagarDTO> cuentas = new List<CuentaPagarDTO>();

        public frmCxP()
        {
            InitializeComponent();
        }

        private void frmCxP_Load(object sender, EventArgs e)
        {
            configurarColumnas();
            cargarCuentas(null);
        }

        private void configurarColumnas()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            agregarColumna("IdCuenta", "No. Cuenta", 70, null, DataGridViewContentAlignment.MiddleCenter);
            agregarColumna("Proveedor", "Proveedor", 200, null, DataGridViewContentAlignment.MiddleLeft);
            agregarColumna("FechaCompra", "Fecha compra", 90, "dd/MM/yyyy", DataGridViewContentAlignment.MiddleCenter);
            agregarColumna("FechaLimite", "Fecha limite", 90, "dd/MM/yyyy", DataGridViewContentAlignment.MiddleCenter);
            agregarColumna("Total", "Total", 90, "N2", DataGridViewContentAlignment.MiddleRight);
            agregarColumna("Saldo", "Saldo", 90, "N2", DataGridViewContentAlignment.MiddleRight);
            agregarColumna("Estado", "Estado", 80, null, DataGridViewContentAlignment.MiddleCenter);
        }

        private void agregarColumna(string propiedad, string encabezado, float peso, string formato, DataGridViewContentAlignment alineacion)
        {
            var columna = new DataGridViewTextBoxColumn
            {
                DataPropertyName = propiedad,
                Name = propiedad,
                HeaderText = encabezado,
                FillWeight = peso
            };
            columna.DefaultCellStyle.Alignment = alineacion;
            if (formato != null)
            {
                columna.DefaultCellStyle.Format = formato;
            }
            dataGridView1.Columns.Add(columna);
        }

        private void cargarCuentas(int? idSeleccionar)
        {
            try
            {
                cuentas = Bs_Compra.obtenercxp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudieron cargar las cuentas por pagar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            aplicarFiltro(idSeleccionar);
        }

        private void aplicarFiltro(int? idSeleccionar)
        {
            int? idActual = idSeleccionar ?? cuentaSeleccionada()?.IdCuenta;
            string texto = txtbuscarcuenta.Text.Trim();

            var lista = cuentas
                .Where(c => chkpagadas.Checked || !c.Pagada)
                .Where(c => texto.Length == 0
                    || c.Proveedor.IndexOf(texto, StringComparison.CurrentCultureIgnoreCase) >= 0
                    || c.IdCuenta.ToString().Contains(texto))
                .ToList();

            dataGridView1.DataSource = lista;
            if (idActual.HasValue)
            {
                seleccionarCuenta(idActual.Value);
            }
            mostrarDetalle();
            actualizarResumen(lista);
        }

        private void seleccionarCuenta(int idCuenta)
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                var cuenta = fila.DataBoundItem as CuentaPagarDTO;
                if (cuenta != null && cuenta.IdCuenta == idCuenta)
                {
                    dataGridView1.CurrentCell = fila.Cells[0];
                    fila.Selected = true;
                    return;
                }
            }
        }

        private CuentaPagarDTO cuentaSeleccionada()
        {
            if (dataGridView1.CurrentRow == null) return null;
            return dataGridView1.CurrentRow.DataBoundItem as CuentaPagarDTO;
        }

        private void mostrarDetalle()
        {
            var cuenta = cuentaSeleccionada();
            if (cuenta == null)
            {
                limpiar();
                btnAbonar.Enabled = false;
                btnVerAbonos.Enabled = false;
                return;
            }

            txtnocuenta.Text = cuenta.IdCuenta.ToString();
            txtproveedor.Text = cuenta.Proveedor;
            txtfechacompra.Text = formatearFecha(cuenta.FechaCompra);
            txtfechalimite.Text = formatearFecha(cuenta.FechaLimite);
            txttotal.Text = string.Format("Q {0:N2}", cuenta.Total);
            txtsaldo.Text = string.Format("Q {0:N2}", cuenta.Saldo);
            txtestado.Text = cuenta.Estado;
            mostrarDiasRestantes(cuenta);

            btnAbonar.Enabled = !cuenta.Pagada;
            btnVerAbonos.Enabled = true;
        }

        private void mostrarDiasRestantes(CuentaPagarDTO cuenta)
        {
            int? dias = cuenta.DiasRestantes;
            if (cuenta.Pagada || !dias.HasValue)
            {
                txtdiasrestantes.Text = "-";
                txtdiasrestantes.ForeColor = ColorNormal;
            }
            else if (dias.Value < 0)
            {
                txtdiasrestantes.Text = "Vencida (" + Math.Abs(dias.Value) + " d)";
                txtdiasrestantes.ForeColor = ColorVencida;
            }
            else if (dias.Value == 0)
            {
                txtdiasrestantes.Text = "Vence hoy";
                txtdiasrestantes.ForeColor = ColorVencida;
            }
            else
            {
                txtdiasrestantes.Text = dias.Value + (dias.Value == 1 ? " dia" : " dias");
                txtdiasrestantes.ForeColor = dias.Value <= DiasPorVencer ? ColorPorVencer : ColorNormal;
            }
        }

        private static string formatearFecha(DateTime? fecha)
        {
            return fecha.HasValue ? fecha.Value.ToString("dd/MM/yyyy") : string.Empty;
        }

        private void actualizarResumen(List<CuentaPagarDTO> lista)
        {
            var pendientes = lista.Where(c => !c.Pagada).ToList();
            decimal saldoPendiente = pendientes.Sum(c => c.Saldo);
            decimal vencido = pendientes.Where(c => c.DiasRestantes < 0).Sum(c => c.Saldo);

            lblpendientes.Text = pendientes.Count.ToString();
            lblsaldopendiente.Text = string.Format("Q {0:N2}", saldoPendiente);
            lblvencido.Text = string.Format("Q {0:N2}", vencido);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            mostrarDetalle();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var cuenta = dataGridView1.Rows[e.RowIndex].DataBoundItem as CuentaPagarDTO;
            if (cuenta == null) return;

            if (cuenta.Pagada)
            {
                e.CellStyle.ForeColor = Color.Gray;
            }
            else if (cuenta.DiasRestantes < 0)
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 224, 224);
            }
            else if (cuenta.DiasRestantes <= DiasPorVencer)
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 243, 205);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                abonar();
            }
        }

        private void txtbuscarcuenta_TextChanged(object sender, EventArgs e)
        {
            aplicarFiltro(null);
        }

        private void chkpagadas_CheckedChanged(object sender, EventArgs e)
        {
            aplicarFiltro(null);
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            abonar();
        }

        private void btnVerAbonos_Click(object sender, EventArgs e)
        {
            verAbonos();
        }

        private void abonar()
        {
            var cuenta = cuentaSeleccionada();
            if (cuenta == null || cuenta.Pagada) return;

            using (frmAbonocxp abono = new frmAbonocxp())
            {
                abono.txtnocuenta.Text = cuenta.IdCuenta.ToString();
                abono.txtsaldocuenta.Text = cuenta.Saldo.ToString("N2");
                abono.txtfechaabono.Text = DateTime.Now.ToShortDateString();
                if (abono.ShowDialog(this) == DialogResult.OK)
                {
                    cargarCuentas(cuenta.IdCuenta);
                }
            }
        }

        private void verAbonos()
        {
            var cuenta = cuentaSeleccionada();
            if (cuenta == null) return;

            using (frmVerAbonosCxP abonos = new frmVerAbonosCxP(cuenta.IdCuenta, cuenta.Proveedor))
            {
                abonos.ShowDialog(this);
            }
        }

        private void frmCxP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                abonar();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                verAbonos();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape && txtbuscarcuenta.Focused && txtbuscarcuenta.Text.Length > 0)
            {
                txtbuscarcuenta.Clear();
                e.Handled = true;
            }
        }

        private void limpiar()
        {
            txtnocuenta.Clear();
            txtproveedor.Clear();
            txtfechacompra.Clear();
            txtfechalimite.Clear();
            txtdiasrestantes.Clear();
            txtsaldo.Clear();
            txttotal.Clear();
            txtestado.Clear();
        }
    }
}
