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
    public partial class frmAgregarAV : Form
    {
        public frmAgregarAV()
        {
            InitializeComponent();
        }

        private void frmAgregarAV_Load(object sender, EventArgs e)
        {
            //Llena el combo empleados
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var lst = (from a in db.CLIENTE                           
                           where a.ESTADO == true
                           select new
                           {
                               Codigo = a.ID,
                               Nombre = a.NOMBRE

                           }).ToList();

                comboBox1.DataSource = lst;
                comboBox1.ValueMember = "Codigo";
                comboBox1.DisplayMember = "Nombre";

            }
            //fin
            comboBox1.SelectedIndex = -1;
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double valornumerico;
                if (!double.TryParse(txtcantidad.Text.Trim(), out valornumerico))
                {
                    MessageBox.Show("Debe ingresar un dato numérico", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtsubtotal.Text = string.Format("{0:N2}", double.Parse(txtprecio.Text) * double.Parse(txtcantidad.Text));
                }
            }
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            double valornumerico;
            if (!double.TryParse(txtcantidad.Text.Trim(), out valornumerico))
            {
                errorProvider1.SetError(txtcantidad, "Debe ingresar un dato numérico");
                return;
            }
            else
            {
                errorProvider1.SetError(txtcantidad, "");
            }

            //if (checkBox1.Checked)
            //{
            //    //grabar en autoventadeta2
            //    //Entidad.AUTOVENTADETA2 salida = new Entidad.AUTOVENTADETA2()
            //    //{
            //    //    ID = int.Parse(lbliddeta.Text),
            //    //    IDAUTOVENTA = int.Parse(lblnav.Text),
            //    //    IDPRODUCTO = int.Parse(txtid.Text),
            //    //    CANTIDAD = decimal.Parse(txtcantidad.Text),
            //    //    PRECIO = decimal.Parse(txtprecio.Text),
            //    //    SUBTOTAL = decimal.Parse(txtsubtotal.Text),
            //    //    CLIENTE = int.Parse(comboBox1.SelectedValue.ToString()),
            //    //    ABONO = decimal.Parse(txtab.Text.Trim())
            //    //};

            //    //Bs_Pedido.registrardetalles2(salida);
            //    //actualizar saldo del cliente
            //    //sumarle el pedido y restarle el abono si lo hubiera
                
            //}
            //else
            //{
            //    //Entidad.AUTOVENTADETA2 salida = new Entidad.AUTOVENTADETA2()
            //    //{
            //    //    ID = int.Parse(lbliddeta.Text),
            //    //    IDAUTOVENTA = int.Parse(lblnav.Text),
            //    //    IDPRODUCTO = int.Parse(txtid.Text),
            //    //    CANTIDAD = decimal.Parse(txtcantidad.Text),
            //    //    PRECIO = decimal.Parse(txtprecio.Text),
            //    //    SUBTOTAL = decimal.Parse(txtsubtotal.Text),
            //    //    CLIENTE = null,
            //    //    ABONO = null
            //    //};
            //    //Bs_Pedido.registrardetalles2(salida);
                
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
