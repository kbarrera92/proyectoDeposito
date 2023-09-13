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
    public partial class frmSalidaEfectivo : Form
    {
        public frmSalidaEfectivo()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            dateTimePicker1.Value = DateTime.Today;
            txtconcepto.Clear();
            txtcantidad.Text = "0.00";
        }

        private double calculartotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total = total + double.Parse(row.Cells[3].Value.ToString());
            }
            return total;
        }
        private void frmSalidaEfectivo_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Efectivo.llenargastosvarios(dataGridView1);
            txttotal.Text = string.Format("{0:N2}", calculartotal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Negocio.Bs_Efectivo.llenargastosvariosfecha(dataGridView1, dateTimePicker2.Value.Date, dateTimePicker3.Value.Date);
            txttotal.Text = string.Format("{0:N2}", calculartotal());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Negocio.Bs_Efectivo.llenargastosvarios(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valornumerico;
            if (txtconcepto.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtconcepto, "Este campo es obligatorio");
                return;
            }
            else
            {
                errorProvider1.SetError(txtconcepto, "");
                if (!double.TryParse(txtcantidad.Text.Trim(), out valornumerico))
                {
                    errorProvider1.SetError(txtcantidad, "Debe ingresar un valor numérico");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtcantidad, "");
                }
            }

            Entidad.SALIDAEFECTIVO salidaEfectivo = new Entidad.SALIDAEFECTIVO
            {
                FECHA = dateTimePicker1.Value,
                CONCEPTO = txtconcepto.Text.Trim(),
                IMPORTE = decimal.Parse(txtcantidad.Text)
            };

            try
            {
                if (Negocio.Bs_Efectivo.crearNuevo(salidaEfectivo))
                {
                    MessageBox.Show("Registro guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Negocio.Bs_Efectivo.llenargastosvarios(dataGridView1);
                    limpiar();
                    txttotal.Text = string.Format("{0:N2}", calculartotal());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}
