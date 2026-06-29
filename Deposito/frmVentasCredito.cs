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
    public partial class frmVentasCredito : Form
    {
        public frmVentasCredito()
        {
            InitializeComponent();
        }

        private void frmVentasCredito_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Venta.verventascredito(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Cobrada")
            {
                MessageBox.Show("La venta ya fue cobrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Ya cobró esta venta?", "Cambiando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Bs_Venta.cobrarventacredito(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())))
                {
                    Entidad.MOVIMIENTO mov = new Entidad.MOVIMIENTO()
                    {
                        FECHA = DateTime.Now.Date,
                        DESCRIPCION = "Pago de venta No. " + dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        TIPO = 1,
                        IMPORTE = decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString())
                    };

                    if (Bs_Efectivo.crearNuevoMov(mov, new Entidad.DEPOSITOEntities1()))
                    {
                        MessageBox.Show("Se guardó correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bs_Venta.verventascredito(dataGridView1);
                    }
                        
                }
            }
        }
    }
}
