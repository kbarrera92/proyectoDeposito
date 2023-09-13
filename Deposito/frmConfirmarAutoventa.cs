using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Deposito
{
    public partial class frmConfirmarAutoventa : Form
    {
        public frmConfirmarAutoventa()
        {
            InitializeComponent();
        }

        private void frmConfirmarAutoventa_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Autoventa.llenardgv(dataGridView1);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns[0].DataPropertyName = "ID";
            dataGridView2.Columns[1].DataPropertyName = "IDPRODUCTO";
            dataGridView2.Columns[2].DataPropertyName = "DESCRIPCION";
            dataGridView2.Columns[3].DataPropertyName = "CANTIDAD";
            dataGridView2.Columns[4].DataPropertyName = "PRECIO";
            dataGridView2.Columns[5].DataPropertyName = "SUBTOTAL";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnautoventa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtfechaautoventa.Text = String.Format("{0:dd/MM/yyyy}", dataGridView1.CurrentRow.Cells[1].Value);
            txtrepartidor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            Bs_Autoventa.llenardgvdetalles(dataGridView2, int.Parse(txtnautoventa.Text));
            txttotalautoventa.Text = string.Format("{0:N2}", calculartotal());
        }

        private double calculartotal()
        {
            double total = 0.00d;

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                total += double.Parse(fila.Cells[5].Value.ToString());
            }

            return total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double precio1 = 0.00;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            precio1 = double.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString());
            txtiddetalle.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtcodpro.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtdescripcion.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtcantsalida.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtsubtsalida.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtcantdevuelta.Text = "0";
            txtcantreal.Text = txtcantsalida.Text;
            txtsubtsalidareal.Text = txtsubtsalida.Text;
            txtcantdevuelta.Select();
        }

        private void txtcantdevuelta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                txtcantreal.Text = string.Format("{0}", int.Parse(txtcantsalida.Text) - int.Parse(txtcantdevuelta.Text));
                txtsubtsalidareal.Text = string.Format("{0:N2}", double.Parse(txtcantreal.Text) * precio1);
                                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bs_Autoventa.actualizarDetalleAutoventa(int.Parse(txtiddetalle.Text), int.Parse(txtnautoventa.Text), int.Parse(txtcantreal.Text), decimal.Parse(txtsubtsalidareal.Text));
                Bs_Autoventa.llenardgvdetalles(dataGridView2, int.Parse(txtnautoventa.Text));
                //Limpiar datos de abajo
            }
            catch (Exception  ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
