using Negocio;
using System;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmSolicitarClave : Form
    {
        private const int MaxIntentos = 3;

        private readonly string pantalla;
        private int intentosRestantes = MaxIntentos;

        public frmSolicitarClave(string pantalla)
        {
            InitializeComponent();
            this.pantalla = pantalla;

            var config = Bs_ClaveAcceso.obtenerPantalla(pantalla);
            lbltitulo.Text = config != null ? config.DESCRIPCION : "Acceso restringido";
            lblsubtitulo.Text = config != null && config.TIPOCLAVE == 2
                ? "Ingrese su Clave 2 para continuar"
                : "Ingrese su contraseña para continuar";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtclave.Text.Length == 0)
            {
                mostrarError("Ingrese la contraseña");
                txtclave.Focus();
                return;
            }

            if (Bs_ClaveAcceso.validarClave(pantalla, txtclave.Text))
            {
                DialogResult = DialogResult.OK;
                return;
            }

            intentosRestantes--;
            if (intentosRestantes <= 0)
            {
                MessageBox.Show(this, "Demasiados intentos fallidos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }

            mostrarError("Contraseña incorrecta. Intentos restantes: " + intentosRestantes);
            txtclave.SelectAll();
            txtclave.Focus();
        }

        private void mostrarError(string mensaje)
        {
            lblerror.Text = mensaje;
            lblerror.Visible = true;
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            lblerror.Visible = false;
        }

        private void chkmostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtclave.UseSystemPasswordChar = !chkmostrar.Checked;
            txtclave.Focus();
        }
    }
}
