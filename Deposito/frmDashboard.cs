using Entidad;
using Negocio;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lbltotalventas.Text = string.Format("Q {0:N2}", Negocio.Bs_Venta.gettotalhoy(DateTime.Today.Date));
            lbltotalautoventa.Text = string.Format("Q {0:N2}", Negocio.Bs_Autoventa.gettotalhoy(DateTime.Today.Date));
            lbltotalpedido.Text = string.Format("Q {0:N2}", Negocio.Bs_Pedido.gettotalhoy(DateTime.Today.Date));
            lbltotalabonos.Text = string.Format("Q {0:N2}", Negocio.Bs_Pedido.gettotalhoyabonos(DateTime.Today.Date));
            lbltotalcompras.Text = string.Format("Q {0:N2}", Negocio.Bs_Compra.gettotalhoy(DateTime.Today.Date));
            lbltotalgastos.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.gettotalhoy(DateTime.Today.Date));
            lblabonoscxp.Text = string.Format("Q {0:N2}", Negocio.Bs_Compra.gettotalhoycxp(DateTime.Today.Date));

            txtefectivo.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getefectivohoy(DateTime.Today.Date));
            txtcreditoentradas.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getcreditohoy(DateTime.Today.Date));
            txttotalsalidas.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getsalidashoy(DateTime.Today.Date));
            txtventascreditocob.Text = string.Format("Q {0:N2}", Negocio.Bs_Venta.gettotalventascreditopagadas(DateTime.Today.Date));
            txttotalreal.Text = string.Format("{0:N2}", Negocio.Bs_Efectivo.getefectivohoy(DateTime.Today.Date) -
                Negocio.Bs_Efectivo.getsalidashoy(DateTime.Today.Date) + Negocio.Bs_Venta.gettotalventascreditopagadas(DateTime.Today.Date));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbltotalventas.Text = string.Format("Q {0:N2}", Negocio.Bs_Venta.gettotalxfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalautoventa.Text = string.Format("Q {0:N2}", Negocio.Bs_Autoventa.gettotalxfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalpedido.Text = string.Format("Q {0:N2}", Negocio.Bs_Pedido.gettotalxfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalabonos.Text = string.Format("Q {0:N2}", Negocio.Bs_Pedido.gettotalxfechasabonos(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalcompras.Text = string.Format("Q {0:N2}", Negocio.Bs_Compra.gettotalhoyporfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalgastos.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.gettotalhoyporfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lblabonoscxp.Text = string.Format("Q {0:N2}", Negocio.Bs_Compra.gettotalhoyporfechascxp(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            txtefectivo.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getefectivofechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            txtcreditoentradas.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getcreditofechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            txttotalsalidas.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getsalidasfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            txtventascreditocob.Text = string.Format("Q {0:N2}", Negocio.Bs_Venta.gettotalventascreditopagadasxfecha(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            txttotalreal.Text = string.Format("{0:N2}", Negocio.Bs_Efectivo.getefectivofechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date) -
                Negocio.Bs_Efectivo.getsalidasfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date)
                + Negocio.Bs_Venta.gettotalventascreditopagadasxfecha(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbltotalventas.Text = string.Format("Q {0:N2}", Negocio.Bs_Venta.gettotalhoy(DateTime.Today.Date));
            lbltotalautoventa.Text = string.Format("Q {0:N2}", Negocio.Bs_Autoventa.gettotalhoy(DateTime.Today.Date));
            lbltotalpedido.Text = string.Format("Q {0:N2}", Negocio.Bs_Pedido.gettotalhoy(DateTime.Today.Date));
            lbltotalabonos.Text = string.Format("Q {0:N2}", Negocio.Bs_Pedido.gettotalhoyabonos(DateTime.Today.Date));
            lbltotalcompras.Text = string.Format("Q {0:N2}", Negocio.Bs_Compra.gettotalhoy(DateTime.Today.Date));
            lbltotalgastos.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.gettotalhoy(DateTime.Today.Date));
            lblabonoscxp.Text = string.Format("Q {0:N2}", Negocio.Bs_Compra.gettotalhoycxp(DateTime.Today.Date));

            txtefectivo.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getefectivohoy(DateTime.Today.Date));
            txtcreditoentradas.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getcreditohoy(DateTime.Today.Date));
            txttotalsalidas.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getsalidashoy(DateTime.Today.Date));
            txttotalreal.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.getefectivohoy(DateTime.Today.Date) - Negocio.Bs_Efectivo.getsalidashoy(DateTime.Today.Date));

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }


        private void buttonGuadarEfectivoReal_Click(object sender, EventArgs e)
        {
            if (ValidaCuadreExistente(DateTime.Today.Date))
            {
                MessageBox.Show("Ya existe un cuadre de efectivo del día de hoy", "Datos duplicados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txttotalreal.Text, out decimal decValue) || decimal.Parse(txttotalreal.Text) <= 0m)
            {
                MessageBox.Show("La cantidad de efectivo no es válida", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (MessageBox.Show("¿Desea guardar este registro de efectivo a la caja?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    short tipoTran;
                    using (var db = new DEPOSITOEntities1())
                    {
                        tipoTran = db.TRANSACCION.Where(t => t.NOMBRETRANS == "EFECTIVODIA").Select(t => t.ID).FirstOrDefault();
                    }

                    var movimiento = new MOVIMIENTO()
                    {
                        FECHA = DateTime.Now,
                        DESCRIPCION = $"Efectivo de la fecha {dateTimePicker1.Value.Date}",
                        TIPO = tipoTran,
                        IMPORTE = decimal.Parse(txttotalreal.Text.Trim())
                    };

                    using (var ctx = new DEPOSITOEntities1())
                    {
                        using (var transaction = ctx.Database.BeginTransaction())
                        {

                        
                            if (Bs_Efectivo.crearNuevoMov(movimiento, ctx))
                            {
                                var bitacora = new BITACORACUADRESDIARIOS
                                {
                                    FECHA = DateTime.Now,
                                    MONTO = movimiento.IMPORTE ?? 0m,
                                    USUARIO = Bs_Usuario.usuarioActual
                                };

                                ctx.BITACORACUADRESDIARIOS.Add(bitacora);
                                ctx.SaveChanges();
                                transaction.Commit();
                                MessageBox.Show("El registro se guardó correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Hubo un error al guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al grabar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaCuadreExistente(DateTime fecha)
        {
            using (var db = new DEPOSITOEntities1())
            {
                return db.BITACORACUADRESDIARIOS.Any(c => DbFunctions.TruncateTime(c.FECHA) == DbFunctions.TruncateTime(fecha.Date));
            }
        }
    }
}
