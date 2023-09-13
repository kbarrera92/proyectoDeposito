using System;
using System.Windows.Forms;
using Negocio;

namespace Deposito
{
    public partial class frmcuadreAutoventa : Form
    {
        public frmcuadreAutoventa()
        {
            InitializeComponent();
        }

        private void frmcuadreAutoventa_Load(object sender, EventArgs e)
        {
            Bs_Autoventa.llenardgv(dataGridView1);
            Bs_Producto.llenardgv(dataGridView4);
            Bs_Cliente.llenarcmb(comboBox1);
        }

        private double calculartotalsalida()
        {
            double total = 0.00d;

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                total += double.Parse(fila.Cells[5].Value.ToString());
            }

            return total;
        }

        private double calculartotalreal()
        {
            double total = 0.00d;

            foreach (DataGridViewRow fila in dataGridView3.Rows)
            {
                total += double.Parse(fila.Cells[4].Value.ToString());
            }

            return total;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int auto = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtfecha.Text = string.Format("{0:dd/MM/yyyy}",dataGridView1.CurrentRow.Cells[1].Value);
            txtnautoventa.Text = auto.ToString();
            Bs_Autoventa.llenardgvdetalles(dataGridView2, auto);
            txttotalsalida.Text = string.Format("{0:N2}", calculartotalsalida());
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bs_Cliente.llenarcmbcliente(listBox1, comboBox1.Text);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Add(txtcodpro.Text, 
                txtdesc.Text, 
                txtcantidad.Text, 
                txtprecio.Text, 
                txtsubtotal.Text, 
                txtcliente.Text.Trim(), 
                txtabono.Text);
            txttotalreal.Text = string.Format("{0:N2}", calculartotalreal());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    if (dataGridView3.Rows[i].Cells[5].Value.ToString() == "")
                    {
                        Entidad.AUTOVENTADETA2 pedido = new Entidad.AUTOVENTADETA2()
                        {
                            ID = i + 1,
                            IDAUTOVENTA = int.Parse(txtnautoventa.Text.Trim()),
                            IDPRODUCTO = int.Parse(dataGridView3.Rows[i].Cells[0].Value.ToString()),
                            CANTIDAD = decimal.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString()),
                            PRECIO = decimal.Parse(dataGridView3.Rows[i].Cells[3].Value.ToString()),
                            SUBTOTAL = decimal.Parse(dataGridView3.Rows[i].Cells[4].Value.ToString()),
                            CLIENTE = null,
                            ABONO = null

                        };

                        Bs_Pedido.registrardetalles2(pedido);
                    }
                    else
                    {
                        Entidad.AUTOVENTADETA2 pedido = new Entidad.AUTOVENTADETA2()
                        {
                            ID = i + 1,
                            IDAUTOVENTA = int.Parse(txtnautoventa.Text.Trim()),
                            IDPRODUCTO = int.Parse(dataGridView3.Rows[i].Cells[0].Value.ToString()),
                            CANTIDAD = decimal.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString()),
                            PRECIO = decimal.Parse(dataGridView3.Rows[i].Cells[3].Value.ToString()),
                            SUBTOTAL = decimal.Parse(dataGridView3.Rows[i].Cells[4].Value.ToString()),
                            CLIENTE = int.Parse(dataGridView3.Rows[i].Cells[5].Value.ToString()),
                            ABONO = decimal.Parse(dataGridView3.Rows[i].Cells[6].Value.ToString())

                        };

                        int cliente = int.Parse(dataGridView3.Rows[i].Cells[5].Value.ToString());
                        //datetime fecha = Convert.ToDateTime(txtfecha.text)
                        decimal total = decimal.Parse(dataGridView3.Rows[i].Cells[4].Value.ToString());
                        decimal cobrado = decimal.Parse(dataGridView3.Rows[i].Cells[6].Value.ToString());
                        decimal saldo = Bs_Cliente.obtenersaldo(cliente);

                        Bs_Pedido.registrardetalles2(pedido);

                        Entidad.BIT_ABONOSYSALDOS bitacora = new Entidad.BIT_ABONOSYSALDOS()
                        {
                            IDCLUENTE = cliente,
                            FECHA = Convert.ToDateTime(txtfecha.Text),
                            TOTAL = total,
                            COBRADO = cobrado,
                            SALDO = saldo
                        };

                        Bs_Cliente.crearhistorialsaldos(bitacora);
                    }



                }

                MessageBox.Show("Se registró la autoventa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView3.DataSource = null;
                dataGridView3.Rows.Clear();
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
                Bs_Autoventa.llenardgv(dataGridView1);
                Bs_Producto.llenardgv(dataGridView4);
                txtnautoventa.Clear();
                txtfecha.Clear();
                txtcodpro.Clear();
                txtdesc.Clear();
                txtprecio.Clear();
                txtcantidad.Clear();
                txtsubtotal.Clear();
                txtcliente.Clear();
                txtabono.Clear();

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Bs_Cliente.llenarcmbclientefiltro(listBox1, txtbuscar.Text.Trim());
        }

        private void dataGridView4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnagregar.PerformClick();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Bs_Producto.filtrardgv(dataGridView4, textBox1.Text.Trim());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcliente.Text = listBox1.SelectedValue.ToString();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodpro.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            txtprecio.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            
            txtprecio.Select();
        }

        private void txtsubtotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtabono.Text = "0.00";
                txtabono.Select();
            }
        }

        private void txtabono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnagregar.PerformClick();
                
            }
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtcantidad.Text.Equals("") || decimal.Parse(txtcantidad.Text) < 0)
            {
                txtsubtotal.Text = "0.00";
            }
            else
            {
                txtsubtotal.Text = string.Format("{0:N2}", double.Parse(txtprecio.Text) * double.Parse(txtcantidad.Text));
            }
        }

        private void txtprecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcantidad.Select();
            }
        }
    }
}
