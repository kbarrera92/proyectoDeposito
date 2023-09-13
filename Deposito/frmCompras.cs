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
    public partial class frmCompras : Form
    {
        short tipoCompra;
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            Bs_Producto.llenardgv(dgvProductos);
            Bs_Compra.llenarcmb(cmbFP);
            cmbTipo.SelectedIndex = 0;
            
        }

        private void cmbFP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbFP.Text.Equals("EFECTIVO"))
            {
                DateTime fecha = dateTimePicker1.Value.AddDays(30);
                dateTimePicker2.Value = fecha;
            }
            else
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void txtnitprov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtnombreprov.Text = Bs_Compra.getdatosproveedor(txtnitprov.Text.Trim());
                    lblcodigoproveedor.Text = Bs_Compra.getdatosproveedor1(txtnitprov.Text.Trim()).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: " + ex.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Bs_Compra.filtrardgv(dgvProductos, txtfiltrar.Text.Trim());
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvProductos.CurrentRow.Index);
            txtcodpro.Text = dgvProductos.Rows[id].Cells[0].Value.ToString();
            txtdescpro.Text = dgvProductos.Rows[id].Cells[1].Value.ToString();
            txtpresentacionpro.Text = dgvProductos.Rows[id].Cells[4].Value.ToString();
            txtmarcapro.Text = dgvProductos.Rows[id].Cells[5].Value.ToString();
            txtexistencia.Text = dgvProductos.Rows[id].Cells[6].Value.ToString();
            txtcostopro.Text = dgvProductos.Rows[id].Cells[2].Value.ToString();
            txtcantidad.Focus();
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcantidad.Text.Trim().Count() == 0)
                {
                    txtsubtotal.Text = "0.0";
                }
                else
                {
                    txtsubtotal.Text = Convert.ToString(double.Parse(txtcantidad.Text.Trim()) * double.Parse(txtcostopro.Text.Trim()));
                }

            }
            catch (Exception)
            {

            }
        }

        private void txtcostopro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcostopro.Text.Trim().Count() == 0)
                {
                    txtsubtotal.Text = "0.0";
                }
                else
                {
                    txtsubtotal.Text = Convert.ToString(double.Parse(txtcantidad.Text.Trim()) * double.Parse(txtcostopro.Text.Trim()));
                }

            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Desea ingresar una compra nueva y borrar todos los campos", "Limpiar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvdetalles.Rows.Clear();
                Bs_Producto.llenardgv(dgvProductos);
                limpiar();
            }

        }

        private void limpiar()
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            cmbFP.SelectedIndex = 0;
            txtnitprov.Clear();
            txtnombreprov.Clear();
            txtcodpro.Clear();
            txtdescpro.Clear();
            txtcostopro.Text = "0.0";
            txtpresentacionpro.Clear();
            txtmarcapro.Clear();
            txtexistencia.Text = "0";
            txtcantidad.Text = "0";
            txtsubtotal.Text = "0.0";
            txtnodocumento.Clear();
            lblcodigoproveedor.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Desea salir sin guardar los cambios", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvdetalles.Rows.Count == 0)
            {
                MessageBox.Show(this, "No hay detalles para borrar", "Faltan datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else
            {
                dgvdetalles.Rows.RemoveAt(dgvdetalles.CurrentRow.Index);
                txttotalcompra.Text = calcularTotal().ToString();
            }
        }

        private double calcularTotal()
        {
            double total = 0.0d;
            foreach (DataGridViewRow item in dgvdetalles.Rows)
            {
                total += Convert.ToDouble(item.Cells[4].Value.ToString());
            }

            return total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text.Trim() != "")
            {
                if (Convert.ToDecimal(txtcantidad.Text.Trim()) > 0)
                {
                    dgvdetalles.Rows.Add(txtcodpro.Text, txtdescpro.Text, txtcostopro.Text, txtcantidad.Text, txtsubtotal.Text);
                    txttotalcompra.Text = string.Format ("{0:N2}",calcularTotal());
                    txtcodpro.Clear();
                    txtdescpro.Clear();
                    txtcostopro.Text = "0.0";
                    txtpresentacionpro.Clear();
                    txtmarcapro.Clear();
                    txtexistencia.Text = "0";
                    txtcantidad.Text = "0";
                    txtsubtotal.Text = "0.0";
                }
                else
                {
                    MessageBox.Show("Cantidad incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            agregarcompra();
        }

        private void agregarcompra()
        {
            if (txtnitprov.Text == "")
            {
                errorProvider1.SetError(txtnitprov, "Este campo es obligarorio");
                return;
            }
            else
            {
                errorProvider1.SetError(txtnitprov, "");
                if (dgvdetalles.Rows.Count <= 0)
                {
                    errorProvider1.SetError(dgvdetalles, "No hay ningun producto para agregar");
                    return;
                }
                else
                {
                    if (cmbTipo.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(cmbTipo, "Este campo es obligatorio");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(dgvdetalles, "");
                    }
                    
                }
            }

            if (cmbTipo.SelectedIndex == 0) tipoCompra = 0;
            else tipoCompra = 1;

            Entidad.COMPRA prod = new Entidad.COMPRA
            {
                FECHACOMPRA = dateTimePicker1.Value,
                HORA = DateTime.Now.ToShortTimeString(),
                FECHAPAGO = dateTimePicker2.Value,
                PROVEEDOR = Convert.ToInt32(lblcodigoproveedor.Text),
                TOTAL = Convert.ToDecimal(txttotalcompra.Text),
                FORMAPAGO = int.Parse(cmbFP.SelectedValue.ToString()),
                USUARIO = Bs_Usuario.usuarioActual,
                DOCUMENTO = txtnodocumento.Text.Trim(),
                TIPO = tipoCompra
            };

            if (Bs_Compra.registrarcompra(prod))
            {
                agregardetallecompra();
                //MessageBox.Show(this, "Compra registrada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvdetalles.Rows.Clear();
                Bs_Producto.llenardgv(dgvProductos);
                limpiar();
            }
            else
            {
                MessageBox.Show(this, "Hubo un error al registrar la compra", "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void agregardetallecompra()
        {
            try
            {
                using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
                {
                    long ultimacompra = db.COMPRA.Max(x => x.ID);

                    for (int i = 0; i <= dgvdetalles.Rows.Count - 1; i++)
                    {
                        Entidad.COMPRADETA prod = new Entidad.COMPRADETA
                        {
                            ID = i + 1,
                            IDCOMPRA = ultimacompra,
                            IDPRODUCTO = Convert.ToInt32(dgvdetalles.Rows[i].Cells[0].Value.ToString()),
                            CANTIDAD = Convert.ToDecimal(dgvdetalles.Rows[i].Cells[3].Value.ToString()),
                            PRECIO = Convert.ToDecimal(dgvdetalles.Rows[i].Cells[2].Value.ToString()),
                            SUBTOTAL = Convert.ToDecimal(dgvdetalles.Rows[i].Cells[4].Value.ToString())
                        };

                        Bs_Compra.registrardetalles(prod);
                    }

                    MessageBox.Show(this, "Compra registrada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void txtnitprov_Validating(object sender, CancelEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProveedores proveedores = new frmProveedores();

            proveedores.Show();
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnregistrar.PerformClick();
            }

        }

        
    }
}
