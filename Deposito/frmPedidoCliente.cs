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
    public partial class frmPedidoCliente : Form
    {
        public frmPedidoCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPedidoCliente_Load(object sender, EventArgs e)
        {
            lblCliente.Text += Bs_Cliente.nombrecliente;
            
        }

        //Calcular total
        private double calculartotal(int col)
        {
            double total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += double.Parse(row.Cells[col].Value.ToString());
            }

            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bs_Cliente.llenartodoslospedidos(Bs_Cliente.idcliente, dataGridView1, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            txttotalsaldos.Text = string.Format("{0:N2}", calculartotal(3));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            txttotalsaldos.Text = "0.00";
        }
    }
}
