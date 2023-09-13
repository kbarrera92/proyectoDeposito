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
using Deposito;

namespace Deposito
{
    public partial class frmCxP : frmBase
    {
        public frmCxP()
        {
            InitializeComponent();
        }

        private void frmCxP_Load(object sender, EventArgs e)
        {
            Bs_Compra.mostrarcxp(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            txtnocuenta.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            txtproveedor.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            txtfechacompra.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            txtfechalimite.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            txttotal.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            txtsaldo.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
            txtestado.Text = dataGridView1.Rows[id].Cells[6].Value.ToString();
            DateTime hoy = DateTime.Today;
            TimeSpan diffechas = Convert.ToDateTime(txtfechalimite.Text) - hoy;
            txtdiasrestantes.Text = diffechas.Days.ToString();
        }

        private void txtbuscarcuenta_TextChanged(object sender, EventArgs e)
        {
            Bs_Compra.filtrarcuentas(dataGridView1, txtbuscarcuenta.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            frmAbonocxp abono = new frmAbonocxp();
            //this.Hide();
            //abono.MdiParent = principal;
            abono.txtnocuenta.Text = this.txtnocuenta.Text;
            abono.txtsaldocuenta.Text = this.txtsaldo.Text;
            abono.txtfechaabono.Text = DateTime.Now.ToShortDateString();
            limpiar();
            abono.ShowDialog();
            if (abono.DialogResult.Equals(DialogResult.OK))
            {
                Bs_Compra.mostrarcxp(dataGridView1);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bs_Compra.ncompra = int.Parse(txtnocuenta.Text);
            frmVerAbonosCxP abono = new frmVerAbonosCxP();
            abono.Show();
        }
    }
}
