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
    public partial class frmConfigCapita : Form
    {
        public frmConfigCapita()
        {
            InitializeComponent();
        }

        private void frmConfigCapita_Load(object sender, EventArgs e)
        {
            textBox1.Text = string.Format("{0:N2}",Negocio.Bs_Efectivo.getCapital(100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal refe;
            if (!decimal.TryParse(textBox1.Text.Trim(), out refe))
            {
                MessageBox.Show("Cantidad no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Desea realizar este cambio?", "Cambiando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Negocio.Bs_Efectivo.cambiarcapital(100, decimal.Parse(textBox1.Text.Trim())))
                    {
                        MessageBox.Show("Se guardó correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }
    }
}
