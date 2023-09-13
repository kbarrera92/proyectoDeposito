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
    public partial class frmAgregarDetallePedido : Form
    {
        public frmAgregarDetallePedido()
        {
            InitializeComponent();
        }

        private void frmAgregarDetallePedido_Load(object sender, EventArgs e)
        {
            txtnpedido.Text = Bs_Pedido.idpedido.ToString();
            Bs_Producto.llenardgv(dataGridView1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigopro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdescpro.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtprecioprod.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtstock.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtprecioprod.Select();
            txtcantdet.Text = "0";
        }

        private void txtprecioprod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (txtprecioprod.Text.Equals(""))
                {
                    txtsubtdet.Text = "0.00";
                }
                else
                {
                    txtsubtdet.Text = string.Format("{0:N2}", double.Parse(txtprecioprod.Text) * double.Parse(txtcantdet.Text));
                }
                txtcantdet.Select();
            }
        }

        private void txtcantdet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (txtcantdet.Text.Equals(""))
                {
                    txtsubtdet.Text = "0.00";
                }
                else
                {
                    txtsubtdet.Text = string.Format("{0:N2}", double.Parse(txtprecioprod.Text) * double.Parse(txtcantdet.Text));
                }

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Entidad.PEDIDODETA venta = new Entidad.PEDIDODETA()
            {
                ID = Bs_Pedido.iddetallepedido,
                IDPEDIDO = int.Parse(txtnpedido.Text),
                IDPRODUCTO = int.Parse(txtcodigopro.Text),
                CANTIDAD = int.Parse(txtcantdet.Text),
                PRECIO = decimal.Parse(txtprecioprod.Text),
                SUBTOTAL = decimal.Parse(txtsubtdet.Text)
            };

            Bs_Venta.registrardetallespedido(venta);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Bs_Producto.filtrardgv(dataGridView1, txtbuscar.Text.Trim());
        }
    }
}
