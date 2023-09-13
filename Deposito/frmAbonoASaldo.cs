using System;
using System.Windows.Forms;
using Negocio;

namespace Deposito
{
    public partial class frmAbonoASaldo : Form
    {
        public frmAbonoASaldo()
        {
            InitializeComponent();
        }

        private void frmAbonoASaldo_Load(object sender, EventArgs e)
        {
            txtidcliente.Text = Bs_Cliente.idcliente.ToString();
            txtcodigo.Text = Bs_Cliente.codigocliente;
            txtnombre.Text = Bs_Cliente.nombrecliente;
            txtsaldo.Text = Bs_Cliente.saldo.ToString();
            Bs_Repartidor.llenarcmb(comboBox1);
            txtimporte.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validado())
            {
                crearobjeto();
            }
        }

        private void crearobjeto()
        {
            Entidad.ABONOASALDO abono = new Entidad.ABONOASALDO()
            {
                CLIENTE = int.Parse(txtidcliente.Text),
                IMPORTE = decimal.Parse(txtimporte.Text.Trim()),
                FECHA = dateTimePicker1.Value
                
            };

            if (Bs_Pedido.crearAbono(abono))
            {
                MessageBox.Show(this, "Se guardo correctamente el abono", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Entidad.BIT_ABONOSYSALDOS bita = new Entidad.BIT_ABONOSYSALDOS()
                {
                    IDCLUENTE = int.Parse(txtidcliente.Text),
                    FECHA = dateTimePicker1.Value,
                    TOTAL = 0.00m,
                    COBRADO = decimal.Parse(txtimporte.Text.Trim()),
                    SALDO = Bs_Cliente.obtenersaldo(int.Parse(txtidcliente.Text)),
                    REPARTIDOR = int.Parse(comboBox1.SelectedValue.ToString())
                };

                Bs_Cliente.crearhistorialsaldos(bita);

                Close();
            }
            
        }

        private bool validado()
        {
            bool valida = false;

            if(txtimporte.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtimporte, "Este campo es obligatorio");
            }
            else
            {
                errorProvider1.SetError(txtimporte, "");
                if (double.Parse(txtimporte.Text.Trim()) <= 0)
                {
                    errorProvider1.SetError(txtimporte, "Cantidad incorrecta");
                }
                else
                {
                    errorProvider1.SetError(txtimporte, "");
                    valida = true;
                }
            }

            return valida;
        }
    }
}
