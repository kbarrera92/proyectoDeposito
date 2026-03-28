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
    public partial class FormProductosStockBajo : Form
    {
        public FormProductosStockBajo()
        {
            InitializeComponent();
        }

        private void FormProductosStockBajo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Negocio.Bs_Producto.ListaProductosConBajoStock();
        }
    }
}
