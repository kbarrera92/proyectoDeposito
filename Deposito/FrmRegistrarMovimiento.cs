using Negocio.DTOs;
using Negocio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposito
{
    public partial class FrmRegistrarMovimiento : Form
    {
        private readonly MovimientoRegistroService _service = new MovimientoRegistroService();

        private class TipoItem
        {
            public string Texto { get; set; }
            public TipoMovimiento Valor { get; set; }
            public override string ToString() => Texto;
        }

        public FrmRegistrarMovimiento()
        {
            InitializeComponent();
            CargarTipos();
        }

        private void CargarTipos()
        {
            cboTipo.Items.Add(new TipoItem { Texto = "Entrada", Valor = TipoMovimiento.Entrada });
            cboTipo.Items.Add(new TipoItem { Texto = "Salida", Valor = TipoMovimiento.Salida });
            cboTipo.SelectedIndex = 0;
        }

        private void FrmRegistrarMovimiento_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDetalle.Text))
            {
                MessageBox.Show("El detalle es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDetalle.Focus();
                return;
            }

            if (nudImporte.Value <= 0)
            {
                MessageBox.Show("El importe debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudImporte.Focus();
                return;
            }

            var tipoSeleccionado = ((TipoItem)cboTipo.SelectedItem).Valor;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                _service.Registrar(tipoSeleccionado, txtDetalle.Text.Trim(), nudImporte.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el movimiento: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
