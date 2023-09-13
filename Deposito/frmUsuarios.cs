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
    public partial class frmUsuarios : frmBase
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Usuario.llenardgv(dataGridView1);
            Negocio.Bs_Usuario.llenarCmbTipoUsuario(comboBox1);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            txtiduser.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            txtnombre.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            txtusuario.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            txtpassword.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            btnregistrar.Text = "Actualizar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnregistrar.Text.Equals("Registrar"))
            {
                if (txtnombre.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtnombre, "Este campo es obligatorio");
                    return;
                }
                if (txtusuario.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtusuario, "Este campo es obligatorio");
                    return;
                }
                if (txtpassword.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtpassword, "Este campo es obligatorio");
                    return;
                }

                Entidad.USUARIO user = new Entidad.USUARIO
                {
                    NOMBRE = txtnombre.Text.Trim(),
                    USER = txtusuario.Text.Trim(),
                    PASSWORD = txtpassword.Text.Trim(),
                    TIPOUSUARIO = short.Parse(comboBox1.SelectedValue.ToString()),
                    ESTADO = true
                };
                
                try
                {
                    Negocio.Bs_Usuario.crearUsuario(user);
                    MessageBox.Show(this, "Usuario creado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Negocio.Bs_Usuario.llenardgv(dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: " + ex.Message, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                //Actualizar registro
                Negocio.Bs_Usuario.actualizarUsuario(int.Parse(txtiduser.Text.Trim()), txtnombre.Text.Trim(), txtusuario.Text.Trim(), txtpassword.Text.Trim());
                Negocio.Bs_Usuario.llenardgv(dataGridView1);
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnregistrar.Text = "Registrar";
            txtnombre.Clear();
            txtiduser.Clear();
            txtusuario.Clear();
            txtpassword.Clear();
            txtnombre.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtiduser.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtiduser, "No ha seleccionado ningun registro");
                return;
            }
            else
            {
                Negocio.Bs_Usuario.dardebajausuario(int.Parse(txtiduser.Text.Trim()));
                MessageBox.Show(this, "Eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Negocio.Bs_Usuario.llenardgv(dataGridView1);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
