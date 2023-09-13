using Negocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmMovimientos : Form
    {
        public frmMovimientos()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            bool resp = false;
            double vnumerico;

            if (txtdescripcion.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtdescripcion, "Este campo es obligatorio");
            }
            else
            {
                errorProvider1.SetError(txtdescripcion, "");
                if (cmbtipo.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbtipo, "Debe elegir un tipo de movimiento");
                }
                else
                {
                    errorProvider1.SetError(cmbtipo, "");
                    if (!double.TryParse(txtimporte.Text.Trim(), out vnumerico))
                    {
                        errorProvider1.SetError(txtimporte, "Debe escribir un valor numérico");
                    }
                    else
                    {
                        errorProvider1.SetError(txtimporte, "");
                        if (cmbtipo.Text !="ENTRADA")
                        {
                            if (double.Parse(txtefectivo.Text) < double.Parse(txtimporte.Text))
                            {
                                errorProvider1.SetError(txtimporte, "No hay suficiente efectivo");
                            }
                            else
                            {
                                errorProvider1.SetError(txtimporte, "");
                                resp = true;
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(txtimporte, "");
                            resp = true;
                        }
                        
                        
                    }
                }
            }

            return resp;
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                try
                {
                    Entidad.MOVIMIENTO mov = new Entidad.MOVIMIENTO()
                    {
                        FECHA = dtpFecha.Value.Date,
                        DESCRIPCION = txtdescripcion.Text.Trim(),
                        TIPO = short.Parse(cmbtipo.SelectedValue.ToString()),
                        IMPORTE = decimal.Parse(txtimporte.Text.Trim())
                    };

                    if (Bs_Efectivo.crearNuevoMov(mov))
                    {
                        MessageBox.Show("El registro se guardó correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Bs_Efectivo.llenardgvmovimientos(dataGridView1);
                        llenarcmb(cmbtipo);


                        //Obtener capital
                        txtcapital.Text = string.Format("{0:N}", Bs_Efectivo.getCapital(100) + Bs_Cliente.gettotalsaldo() + Bs_Venta.gettotalventascredito() + Bs_Producto.getvalorinventario());

                        txtefectivo.Text = string.Format("{0:N}", Bs_Efectivo.getCapital(100));
                        txttotalproducto.Text = string.Format("{0:N2}", Bs_Producto.getvalorinventario());
                        txttotalsaldos.Text = string.Format("{0:N2}", Bs_Cliente.gettotalsaldo() + Bs_Venta.gettotalventascredito());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void llenarcmb(ComboBox combo)
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {

                var lst = (from a in db.TRANSACCION
                           select new
                           {
                               Codigo = a.ID,
                               Descripcion = a.NOMBRETRANS

                           }).ToList();

                combo.DataSource = lst;
                combo.ValueMember = "Codigo";
                combo.DisplayMember = "Descripcion";


            }
        }
        private void frmMovimientos_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].DataPropertyName = "FECHA";
            dataGridView1.Columns[2].DataPropertyName = "DESCRIPCION";
            dataGridView1.Columns[3].DataPropertyName = "NOMBRETRANS";
            dataGridView1.Columns[4].DataPropertyName = "IMPORTE";
            cmbtipo.SelectedIndex = -1;
            Bs_Efectivo.llenardgvmovimientos(dataGridView1);
            llenarcmb(cmbtipo);


            //Obtener capital
            txtcapital.Text = string.Format("{0:N}", Bs_Efectivo.getCapital(100) + Bs_Cliente.gettotalsaldo() + Bs_Venta.gettotalventascredito() + Bs_Producto.getvalorinventario());

            txtefectivo.Text = string.Format("{0:N}", Bs_Efectivo.getCapital(100));
            txttotalproducto.Text = string.Format("{0:N2}", Bs_Producto.getvalorinventario());
            txttotalsaldos.Text = string.Format("{0:N2}", Bs_Cliente.gettotalsaldo() + Bs_Venta.gettotalventascredito());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bs_Efectivo.llenardgvmovimientosxfecha(dataGridView1, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bs_Efectivo.borrarmov(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }
    }
}
