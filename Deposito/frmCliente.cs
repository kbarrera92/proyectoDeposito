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
    public partial class frmCliente : frmBase
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Cliente.llenardgv(dataGridView1);
            Negocio.Bs_Cliente.llenarcmb(cmbareasreparto);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtidcliente.Clear();
            txtcodigocliente.Clear();
            txtnombrecliente.Clear();
            cmbareasreparto.SelectedIndex = -1;
            txtdireccion.Clear();
            txttelefonocliente.Clear();
            txtsaldocliente.Clear();
            txtcodigocliente.Focus();
            btnregistrar.Text = "Registrar";
        }

        private void obtenerDatos(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            int index = cmbareasreparto.FindString(dataGridView1.Rows[id].Cells[3].Value.ToString());
            txtidcliente.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            txtcodigocliente.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            txtnombrecliente.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            cmbareasreparto.SelectedIndex = index;
            txtdireccion.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            txttelefonocliente.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
            txtsaldocliente.Text = dataGridView1.Rows[id].Cells[6].Value.ToString();
            btnregistrar.Text = "Actualizar";
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(txtidcliente.Text);
            string codigo="";
            string nombre="";
            int area=0;
            string direccion="";
            string telefono="";
            decimal saldo=0.0m;

            if (btnregistrar.Text.Equals("Registrar"))
            {
                if (txtcodigocliente.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtcodigocliente, "Este campo es obligatorio");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtcodigocliente, "");
                }
                if (txtnombrecliente.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtnombrecliente, "Este campo es obligatorio");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtnombrecliente, "");
                }

                                
                codigo = txtcodigocliente.Text;
                nombre = txtnombrecliente.Text;
                area = Convert.ToInt32(cmbareasreparto.SelectedValue.ToString());
                direccion = txtdireccion.Text;
                telefono = txttelefonocliente.Text;
                saldo = decimal.Parse(txtsaldocliente.Text);

                using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
                {
                    var consulta = from clients in db.CLIENTE
                                   where clients.CODIGO.Equals(codigo)
                                   select clients;

                    foreach (var item in consulta)
                    {
                        MessageBox.Show("El código ya existe", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Entidad.CLIENTE cliente = new Entidad.CLIENTE
                {
                    CODIGO = codigo,
                    NOMBRE = nombre,
                    AREAREPARTO = area,
                    DIRECCION = direccion,
                    TELEFONO = telefono,
                    SALDO = Convert.ToDecimal(saldo),
                    ESTADO = true
                };

                try
                {
                    Negocio.Bs_Cliente.crearCliente(cliente);
                    MessageBox.Show(this, "Cliente registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Negocio.Bs_Cliente.llenardgv(dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: " + ex.Message, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                codigo = txtcodigocliente.Text;
                nombre = txtnombrecliente.Text;
                area = Convert.ToInt32(cmbareasreparto.SelectedValue.ToString());
                direccion = txtdireccion.Text;
                telefono = txttelefonocliente.Text;
                saldo = decimal.Parse(txtsaldocliente.Text);
                //Actualizar registro
                Negocio.Bs_Cliente.actualizarCliente(int.Parse(txtidcliente.Text), codigo, nombre, area, direccion, telefono, saldo);
                Negocio.Bs_Cliente.llenardgv(dataGridView1);
                limpiar();
                btnregistrar.Text = "Registrar";

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtidcliente.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtidcliente, "No ha seleccionado ningun registro");
                return;
            }
            else
            {
                Negocio.Bs_Cliente.dardebajacliente(int.Parse(txtidcliente.Text.Trim()));
                MessageBox.Show(this, "Eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Negocio.Bs_Cliente.llenardgv(dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
