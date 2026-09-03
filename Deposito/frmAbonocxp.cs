using Entidad;
using Negocio.DTOs;
using System;
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
            if (double.Parse(txtimporteabono.Text) <= double.Parse(txtsaldocuenta.Text))
            {
                var texto = comboBox1.Text;
                string tipoAbono = !string.IsNullOrEmpty(texto) ? texto[0].ToString() : "N";
                Entidad.CXPABONO abono = new Entidad.CXPABONO
                {
                    IDCXP = int.Parse(txtnocuenta.Text.Trim()),
                    IMPORTE = decimal.Parse(txtimporteabono.Text.Trim()),
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
                            MessageBox.Show(this, "Abono registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(this, "Hubo un error al grabar el abono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
            comboBox1.SelectedIndex = 0;
        }
    }
}
