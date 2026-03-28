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
    public partial class frmProductos : frmBase
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Bs_Producto.llenardgv(dataGridView1);
            linkLabel1.Text = "Imprimir\ninventario";
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnregistrar.Text = "Registrar";
            limpiar();
        }

        private void limpiar()
        {
            txtidproducto.Clear();
            txtdesproducto.Clear();
            txtcostoproducto.Clear();
            txtprecioproducto.Clear();
            txtpresentacionprod.Clear();
            txtmarcaprod.Clear();
            txtexistencia.Clear();
            textBoxStockMinimo.Text = "0.0";
            txtdesproducto.Focus();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (btnregistrar.Text.Equals("Registrar"))
            {
                if (txtdesproducto.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtdesproducto, "Este campo es obligatorio");
                    return;
                }
                if (txtcostoproducto.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtcostoproducto, "Este campo es obligatorio");
                    return;
                }
                if (txtprecioproducto.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtprecioproducto, "Este campo es obligatorio");
                    return;
                }
                if (txtexistencia.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtexistencia, "Este campo es obligatorio");
                    return;
                }

                
                if (!decimal.TryParse(textBoxStockMinimo.Text, out decimal valor))
                {
                    errorProvider1.SetError(textBoxStockMinimo, "Este campo debe ser numérico");
                    return;
                }
                if (valor < 0)
                {
                    errorProvider1.SetError(textBoxStockMinimo, "No se permiten número negativos");
                    return;
                }

                Entidad.PRODUCTO prod = new Entidad.PRODUCTO
                {
                    DESCRIPCION = txtdesproducto.Text.Trim(),
                    COSTO = decimal.Parse(txtcostoproducto.Text.Trim()),
                    PRECIO = decimal.Parse(txtprecioproducto.Text.Trim()),
                    PRESENTACION = txtpresentacionprod.Text.Trim(),
                    MARCA = txtmarcaprod.Text.Trim(),
                    EXISTENCIA = int.Parse(txtexistencia.Text.Trim()),
                    ESTADO = true,
                    RETORNABLE = chkretornable.Checked,
                    STOCKMINIMO = decimal.Parse(textBoxStockMinimo.Text)
                };

                try
                {
                    Bs_Producto.crearProducto(prod);
                    MessageBox.Show(this, "Producto registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bs_Producto.llenardgv(dataGridView1);
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: " + ex.Message, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                //Actualizar registro
                Bs_Producto.actualizarProducto(int.Parse(txtidproducto.Text.Trim()), txtdesproducto.Text.Trim(), decimal.Parse(txtcostoproducto.Text.Trim()), decimal.Parse(txtprecioproducto.Text.Trim()), txtpresentacionprod.Text.Trim(), txtmarcaprod.Text.Trim(), decimal.Parse(txtexistencia.Text.Trim()), chkretornable.Checked, decimal.Parse(textBoxStockMinimo.Text));
                limpiar();
                Bs_Producto.llenardgv(dataGridView1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            txtidproducto.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            txtdesproducto.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            txtcostoproducto.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            txtprecioproducto.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            txtpresentacionprod.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            txtexistencia.Text = dataGridView1.Rows[id].Cells[6].Value.ToString();
            txtmarcaprod.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
            textBoxStockMinimo.Text = dataGridView1.Rows[id].Cells[7].Value.ToString();
            chkretornable.Checked = Convert.ToBoolean(dataGridView1.Rows[id].Cells[8].Value);

            btnregistrar.Text = "Actualizar";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Bs_Producto.dardebajaproducto(int.Parse(txtidproducto.Text));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
