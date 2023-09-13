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
    public partial class frmAbonocxp : Form
    {
        public frmAbonocxp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtimporteabono.Text) <= double.Parse(txtsaldocuenta.Text))
            {
                Entidad.CXPABONO abono = new Entidad.CXPABONO
                {
                    IDCXP = int.Parse(txtnocuenta.Text.Trim()),
                    IMPORTE = decimal.Parse(txtimporteabono.Text.Trim()),
                    FECHA = Convert.ToDateTime(txtfechaabono.Text),
                    NORECIBO = txtnorecibo.Text
                };

                try
                {

                    Negocio.Bs_Compra.abonaracuenta(abono);
                    MessageBox.Show(this, "Abono registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                catch (Exception ex)
                {
                    throw;
                    //MessageBox.Show("Error: " + ex.Message, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show(this, "El pago es mayor al saldo", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbonocxp_Load(object sender, EventArgs e)
        {
            txtimporteabono.Select();
        }
    }
}
