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
            txttotalreal.Text = string.Format("{0:N2}", Negocio.Bs_Efectivo.getefectivohoy(DateTime.Today.Date) - Negocio.Bs_Efectivo.getsalidashoy(DateTime.Today.Date) + Negocio.Bs_Venta.gettotalventascreditopagadas(DateTime.Today.Date));

            //ESTO ES FIJO
            lblcantproductos.Text = string.Format("{0}", Negocio.Bs_Producto.getcantidad());
            lblcantclientes.Text = Negocio.Bs_Cliente.getcantidad().ToString();
            lblcantproveedores.Text = Negocio.Bs_Proveedor.getcantidad().ToString();
            lblareareasreparto.Text = Negocio.Bs_Area.getcantidad().ToString();
            lblcantrepartidores.Text = Negocio.Bs_Repartidor.getcantidad().ToString();
            lbltotalcxp.Text = string.Format("Q {0:N2}", Negocio.Bs_Compra.gettotalcxp());
            lbltotalsaldo.Text = string.Format("Q {0:N2}", Negocio.Bs_Cliente.gettotalsaldo());
            lbltotalventascredito.Text = string.Format("Q {0:N2}", Negocio.Bs_Venta.gettotalventascredito());
            lblvalorinventario.Text = string.Format("Q {0:N2}", Negocio.Bs_Producto.getvalorinventario());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbltotalventas.Text = string.Format("Q {0:N2}", Negocio.Bs_Venta.gettotalxfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalautoventa.Text = string.Format("Q {0:N2}", Negocio.Bs_Autoventa.gettotalxfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalpedido.Text = string.Format("Q {0:N2}", Negocio.Bs_Pedido.gettotalxfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalabonos.Text = string.Format("Q {0:N2}", Negocio.Bs_Pedido.gettotalxfechasabonos(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalcompras.Text = string.Format("Q {0:N2}", Negocio.Bs_Compra.gettotalhoyporfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalgastos.Text = string.Format("Q {0:N2}", Negocio.Bs_Efectivo.gettotalhoyporfechas(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
            lbltotalcxp.Text = string.Format("Q {0:N2}", Negocio.Bs_Compra.gettotalhoyporfechascxp(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
