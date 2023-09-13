using System;
using System.Windows.Forms;
using Negocio;

namespace Deposito
{
    public partial class frmAgregarEnvase : Form
    {
        public frmAgregarEnvase()
        {
            InitializeComponent();
        }

        private void frmAgregarEnvase_Load(object sender, EventArgs e)
        {
            Bs_Producto.llenardgv(dataGridView1);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Bs_Producto.filtrardgv(dataGridView1, txtbuscar.Text);
        }

        private bool validar()
        {
            bool success = false;
            int valornumerico;
            if (txtconcepto.Text.Trim() == "")
            {
                errorProvider1.SetError(txtconcepto, "Este campo es obligatorio");
            }
            else
            {
                if (!int.TryParse(txtcodigo.Text.Trim(), out valornumerico) || txtcodigo.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtcodigo, "Faltan datos");
                }
                else
                {
                    errorProvider1.SetError(txtcodigo, "");
                    if (txtdescripcion.Text.Trim() == "")
                    {
                        errorProvider1.SetError(txtdescripcion, "Faltan datos");
                    }
                    else
                    {
                        errorProvider1.SetError(txtdescripcion, "");
                        if (!int.TryParse(txtcantidad.Text.Trim(), out valornumerico) || txtcantidad.Text.Trim() == "")
                        {
                            errorProvider1.SetError(txtcantidad, "Datos no válidos");
                        }
                        else
                        {
                            errorProvider1.SetError(txtcantidad, "");
                            success = true;
                        }
                    }

                }
            }

            return success;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Entidad.HISTORIALENVASE envase = new Entidad.HISTORIALENVASE()
                {
                    CONCEPTO = txtconcepto.Text.Trim(),
                    PRODUCTO = int.Parse(txtcodigo.Text.Trim()),
                    CANTIDAD = int.Parse(txtcantidad.Text.Trim()),
                    FECHAPRESTADO = dateTimePicker1.Value.Date,
                    FECHADEVUELTO = null
                };

                if (Bs_Venta.registrarsaldoenvase(envase))
                {
                    MessageBox.Show("El registro se guardó", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algo salió mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdescripcion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcantidad.Select();
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnagregar.PerformClick();
            }
        }
    }
}
