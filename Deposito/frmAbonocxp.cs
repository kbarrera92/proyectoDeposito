using Entidad;
using Negocio.DTOs;
using System;
using System.Globalization;
using System.Windows.Forms;

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
            decimal saldo;
            if (!decimal.TryParse(txtsaldocuenta.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out saldo))
            {
                MessageBox.Show(this, "No se pudo leer el saldo de la cuenta", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal importe;
            if (!decimal.TryParse(txtimporteabono.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out importe) || importe <= 0)
            {
                MessageBox.Show(this, "Ingrese un importe valido mayor a cero", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtimporteabono.Focus();
                txtimporteabono.SelectAll();
                return;
            }

            if (importe > saldo)
            {
                MessageBox.Show(this, "El pago es mayor al saldo", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtimporteabono.Focus();
                txtimporteabono.SelectAll();
                return;
            }

            var texto = comboBox1.Text;
            string tipoAbono = !string.IsNullOrEmpty(texto) ? texto[0].ToString() : "N";
            Entidad.CXPABONO abono = new Entidad.CXPABONO
            {
                IDCXP = int.Parse(txtnocuenta.Text.Trim()),
                IMPORTE = importe,
                FECHA = Convert.ToDateTime(txtfechaabono.Text),
                NORECIBO = txtnorecibo.Text,
                TIPO = tipoAbono
            };

            using (var ctx = new DEPOSITOEntities1())
            {
                using (var transaction = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        ctx.CXPABONO.Add(abono);

                        ctx.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(this, "Hubo un error al grabar el abono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            MessageBox.Show(this, "Abono registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbonocxp_Load(object sender, EventArgs e)
        {
            txtimporteabono.Select();
            comboBox1.SelectedIndex = 0;
        }
    }
}
