using System;
using System.Windows.Forms;
using Negocio;

namespace Deposito
{
    public partial class frmVerPedidosXRep : Form
    {
        public frmVerPedidosXRep()
        {
            InitializeComponent();
        }

        private double calculartotal(int col, DataGridView dgv)
        {
            double total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total = double.Parse(total + row.Cells[col].Value.ToString());
            }

            return total;
        }

        private void frmVerPedidosXRep_Load(object sender, EventArgs e)
        {
            Bs_Repartidor.llenarcmb(comboBox1);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bs_Pedido.llenardgvpedxrep(dataGridView1, dateTimePicker1.Value.Date, int.Parse(comboBox1.SelectedValue.ToString()));
            txttotalsaldos.Text = string.Format("{0:N2}",calculartotal(4, dataGridView1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            comboBox1.SelectedIndex = -1;
            txttotalsaldos.Clear();
        }
    }
}
