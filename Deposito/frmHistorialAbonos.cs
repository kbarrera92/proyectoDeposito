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
    public partial class frmHistorialAbonos : Form
    {
        public frmHistorialAbonos()
        {
            InitializeComponent();
        }

        private void frmHistorialAbonos_Load(object sender, EventArgs e)
        {
            Bs_Cliente.llenarcmbclientetodos(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Bs_Cliente.llenardgvabonos(dataGridView1, int.Parse(listBox1.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Bs_Cliente.llenarcmbclientefiltro(listBox1, textBox1.Text.Trim());
        }
    }
}
