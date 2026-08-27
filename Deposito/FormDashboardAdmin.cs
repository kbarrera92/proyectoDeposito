using System;
using System.Windows.Forms;

namespace Deposito
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
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
    }
}
