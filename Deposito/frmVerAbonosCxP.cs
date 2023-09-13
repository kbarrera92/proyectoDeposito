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
    public partial class frmVerAbonosCxP : Form
    {
        public frmVerAbonosCxP()
        {
            InitializeComponent();
        }

        private void frmVerAbonosCxP_Load(object sender, EventArgs e)
        {
            Bs_Compra.mostrarcxpabonos(dataGridView1, Bs_Compra.ncompra);
        }
    }
}
