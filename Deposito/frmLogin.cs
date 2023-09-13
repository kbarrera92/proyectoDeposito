using Entidad;
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
    
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (Negocio.Bs_Usuario.checkLogin(user, pass))
            {
                MessageBox.Show(this, "Bienvenido al sistema: " + user, "Datos correctos", MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmPrincipal frmpadre = Owner as frmPrincipal;
                frmpadre.toolStripButtonLogin.Text = "Salir";
                frmpadre.toolStripLabelUser.Text += user;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "No se encontraron coincidencias", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
