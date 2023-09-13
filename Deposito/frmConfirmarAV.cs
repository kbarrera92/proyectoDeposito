using Negocio;
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
    public partial class frmConfirmarAV : Form
    {
        public frmConfirmarAV()
        {
            InitializeComponent();
        }

        private void frmConfirmarAV_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Autoventa.llenardgv(dataGridView1);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns[0].DataPropertyName = "ID";
            dataGridView2.Columns[1].DataPropertyName = "IDPRODUCTO";
            dataGridView2.Columns[2].DataPropertyName = "DESCRIPCION";
            dataGridView2.Columns[3].DataPropertyName = "CANTIDAD";
            dataGridView2.Columns[4].DataPropertyName = "PRECIO";
            dataGridView2.Columns[5].DataPropertyName = "SUBTOTAL";

            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.Columns[0].DataPropertyName = "ID";
            dataGridView3.Columns[1].DataPropertyName = "IDPRODUCTO";
            dataGridView3.Columns[2].DataPropertyName = "DESCRIPCION";
            dataGridView3.Columns[3].DataPropertyName = "CANTIDAD";
            dataGridView3.Columns[4].DataPropertyName = "PRECIO";
            dataGridView3.Columns[5].DataPropertyName = "SUBTOTAL";
        }

        //validar cantidades
        private decimal devuelvecantidad(int codigopro, DataGridView datagrid)
        {
            decimal cant = 0;
            
            for (int i = 0; i < datagrid.Rows.Count; i++)
            {
                if (int.Parse(datagrid.Rows[i].Cells[1].Value.ToString()) == codigopro)
                {
                    cant += decimal.Parse(datagrid.Rows[i].Cells[3].Value.ToString());
                }
            }

            return cant;
        }
        //

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nautoventa = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Bs_Autoventa.llenardgvdetalles(dataGridView2, nautoventa);
            Bs_Autoventa.llenardgvdetalles2(dataGridView3, nautoventa);
            txtnoautoventa.Text = nautoventa.ToString();
            txttotalautoventa.Text = string.Format("{0:N2}", calculartotal());
        }

        private double calculartotal()
        {
            double total = 0.00d;

            foreach (DataGridViewRow fila in dataGridView3.Rows)
            {
                total += double.Parse(fila.Cells[5].Value.ToString());
            }

            return total;
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(devuelvecantidad(int.Parse(dataGridView2.CurrentRow.Cells[1].Value.ToString()), dataGridView3).ToString());
            if (devuelvecantidad(int.Parse(dataGridView2.CurrentRow.Cells[1].Value.ToString()), dataGridView3) < decimal.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString()))
            {
                int no;
                if (dataGridView3.Rows.Count == 0)
                {
                    no = 0 + 1;
                }
                else
                {
                    no = int.Parse(dataGridView3.Rows[dataGridView3.Rows.Count - 1].Cells[0].Value.ToString()) + 1;
                }

                frmAgregarAV agregar = new frmAgregarAV();
                agregar.lbliddeta.Text = no.ToString();
                agregar.lblnav.Text = txtnoautoventa.Text.Trim();
                agregar.txtid.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                agregar.txtproducto.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                agregar.txtprecio.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                agregar.txtcantidad.Select();
                agregar.ShowDialog();

                if (agregar.DialogResult == DialogResult.OK)
                {

                    //dataGridView3.Rows.Add(agregar.txtid.Text, agregar.txtproducto.Text, agregar.txtcantidad.Text, agregar.txtprecio.Text, agregar.txtsubtotal.Text);
                    Bs_Autoventa.llenardgvdetalles2(dataGridView3, int.Parse(txtnoautoventa.Text));
                    txttotalautoventa.Text = string.Format("{0:N2}", calculartotal());
                }
            }
            else
            {
                MessageBox.Show("Cantidad incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0)
            {
                int det = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
                int autov = int.Parse(txtnoautoventa.Text);
                Bs_Autoventa.borrardetalle(det, autov);
                Bs_Autoventa.llenardgvdetalles2(dataGridView3, int.Parse(txtnoautoventa.Text));
                txttotalautoventa.Text = string.Format("{0:N2}", calculartotal());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Bs_Autoventa.actualizartotal(int.Parse(txtnoautoventa.Text), decimal.Parse(txttotalautoventa.Text)))
            {
                MessageBox.Show("Registro guardado exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Bs_Autoventa.filtrar(dataGridView1, textBox1.Text.Trim());
        }
    }
}
