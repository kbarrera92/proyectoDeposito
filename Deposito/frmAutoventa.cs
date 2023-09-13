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
    public partial class frmAutoventa : Form
    {
        private decimal costo;
        public frmAutoventa()
        {
            InitializeComponent();
        }

        private void frmAutoventa_Load(object sender, EventArgs e)
        {
            Bs_Repartidor.llenarcmb(comboBox1);
            Bs_Producto.llenardgv(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodpro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            costo = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txtprecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtexistencia.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtprecio.Select();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            if (txtprecio.Text.Equals(""))
            {
                txtsubtotal.Text = "0.00";
            }
            else
            {
                txtsubtotal.Text = string.Format("{0}", double.Parse(txtprecio.Text) * double.Parse(txtcantidad.Text));
            }
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtcantidad.Text.Equals(""))
            {
                txtsubtotal.Text = "0.00";
            }
            else
            {
                txtsubtotal.Text = string.Format("{0:N2}", double.Parse(txtprecio.Text) * double.Parse(txtcantidad.Text));
            }
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnagregar.PerformClick();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txtexistencia.Text) >= decimal.Parse(txtcantidad.Text))
            {
                if (!txtprecio.Text.Trim().Equals(""))
                {

                    dataGridView2.Rows.Add(txtcodpro.Text, txtdesc.Text, txtcantidad.Text, txtprecio.Text, txtsubtotal.Text, costo);
                    txttotal.Text = string.Format("{0:N2}", calculartotal());
                    limpiardatos();
                }
                else
                {
                    MessageBox.Show(this, "No ha ingresado cantidad a vender", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(this, "No hay existencia disponible", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double calculartotal()
        {
            double total = 0.00d;

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                total += double.Parse(fila.Cells[4].Value.ToString());
            }

            return total;
        }

        private void limpiardatos()
        {
            txtcodpro.Clear();
            txtdesc.Clear();
            txtexistencia.Text = "0";
            txtprecio.Text = "0.00";
            txtcantidad.Text = "0";
            txtsubtotal.Text = "0.00";
            txtbuscar.Clear();
            txtbuscar.Select();
        }

        private void btndescartar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Debe seleccionar un detalle para eliminarlo", "Seleccione un detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show(this, "Desea eliminar este detalle?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            agregarpedido();
        }


        //Aca estan los metodos para agregar el pedido y el detalle
        private void agregarpedido()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(this, "No ha seleccionado ningun repartidor", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show(this, "No hay ningun detalle asociado a este pedido", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Entidad.AUTOVENTA salida = new Entidad.AUTOVENTA()
                    {
                        FECHA = dateTimePicker1.Value,
                        HORA = DateTime.Now.ToShortTimeString(),
                        REPARTIDOR = int.Parse(comboBox1.SelectedValue.ToString()),                        
                        TOTAL = decimal.Parse(txttotal.Text)
                    };

                    if (Bs_Autoventa.crearautoventa(salida))
                    {

                        agregardetallepedido();
                        //MessageBox.Show(this, "Compra registrada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView2.Rows.Clear();
                        Bs_Producto.llenardgv(dataGridView1);
                        limpiardatos();
                        
                    }
                    else
                    {
                        MessageBox.Show(this, "Hubo un error al registrar la salida", "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void agregardetallepedido()
        {
            try
            {
                using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
                {
                    int ultimopedido = db.AUTOVENTA.Max(x => x.ID);

                    for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                    {
                        Entidad.AUTOVENTADETA2 venta = new Entidad.AUTOVENTADETA2()
                        {
                            ID = i + 1,
                            IDAUTOVENTA = ultimopedido,
                            IDPRODUCTO = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()),
                            CANTIDAD = decimal.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()),
                            PRECIO = decimal.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()),
                            SUBTOTAL = decimal.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString()),
                            COSTOAU = decimal.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString())
                        };

                        Bs_Pedido.registrardetalles(venta);
                    }

                    MessageBox.Show(this, "Salida registrada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttotal.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(ex.InnerException.Message);

            }
        }

        private void txtprecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcantidad.Select();
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Bs_Producto.filtrardgv(dataGridView1, txtbuscar.Text.Trim());
        }
    }
}
