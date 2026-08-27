using Microsoft.VisualBasic;
using Negocio;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmPrincipal : Form
    {


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }





        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.MdiParent = this;
            aboutBox.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripButtonLogin.Text.Equals("Login"))
            {
                frmLogin frm = new frmLogin();
                AddOwnedForm(frm);
                frm.Show();
            }
            else
            {
                toolStripButtonLogin.Text = "Login";
                toolStripLabelUser.Text = "Usuario: ";
                Bs_Usuario.usuarioActual = 0;
            }




        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\calc.exe");

        }

        private void areasDeRepartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAreas frmAreas = new frmAreas();
            frmAreas.MdiParent = this;
            frmAreas.Show();
        }

        private void repartidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmRepartidores frmRepartidores = new frmRepartidores();
            frmRepartidores.MdiParent = this;
            frmRepartidores.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonLogin.PerformClick();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmProveedores proveedores = new frmProveedores();
            proveedores.MdiParent = this;
            proveedores.Show();
        }

        private void carteraDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCarteraClientes cartera = new frmCarteraClientes();
            cartera.MdiParent = this;
            cartera.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmCliente cliente = new frmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConfigCapita capital = new frmConfigCapita();
            capital.MdiParent = this;
            capital.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmProductos frmProductos = new frmProductos();
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmCompras compras = new frmCompras();
            compras.MdiParent = this;
            compras.Show();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmCxP cxP = new frmCxP();
            cxP.MdiParent = this;
            cxP.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmVenta venta = new frmVenta();
            venta.MdiParent = this;
            venta.Show();
        }

        private void toolStripButtonPedido_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPedido pedido = new frmPedido();
            pedido.MdiParent = this;
            pedido.Show();
        }

        private void toolStripButtonAutoventa_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAutoventa auto = new frmAutoventa();
            auto.MdiParent = this;
            auto.Show();
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            comprasToolStripMenuItem1.PerformClick();
        }



        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmVerPedidos verPedidos = new frmVerPedidos();
            verPedidos.MdiParent = this;
            verPedidos.Show();
        }

        private void autoventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConfirmarAV auto = new frmConfirmarAV();
            auto.MdiParent = this;
            auto.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStripButtonVenta.PerformClick();
        }

        private void preventaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripButtonPedido.PerformClick();
        }



        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAjuste ajuste = new frmAjuste();
            ajuste.MdiParent = this;
            ajuste.Show();

        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {
            ajustesToolStripMenuItem.PerformClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmSalidaEfectivo efectivo = new frmSalidaEfectivo();
            efectivo.MdiParent = this;
            efectivo.Show();
        }

        private void comprasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmVerCompras compraslist = new frmVerCompras();
            compraslist.MdiParent = this;
            compraslist.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmVerVentas ventaslista = new frmVerVentas();
            ventaslista.MdiParent = this;
            ventaslista.Show();
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object valueinput = Interaction.InputBox("Ingrese su contraseña", "Validando", "");
            if (valueinput.ToString() == Bs_Usuario.password)
            {
                frmDashboard dash = new frmDashboard();
                dash.MdiParent = this;
                dash.Show();
            }


        }

        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object valueinput = Interaction.InputBox("Ingrese su contraseña", "Validando", "");
            if (valueinput.ToString() == Bs_Usuario.password)
            {
                frmInventario inventario = new frmInventario();
                inventario.MdiParent = this;
                inventario.Show();
            }


        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object valueinput = Interaction.InputBox("Ingrese su contraseña", "Validando", "");
            if (valueinput.ToString() == Bs_Usuario.password)
            {
                frmMovimientos movi = new frmMovimientos();
                movi.MdiParent = this;
                movi.Show();
            }

        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F8)
            {
                if (Bs_Usuario.usuarioActual == 0)
                {
                    MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmPedido ped = new frmPedido();
                ped.MdiParent = this;
                ped.Show();
            }
            else
            {
                if (e.KeyCode == Keys.F9)
                {
                    if (Bs_Usuario.usuarioActual == 0)
                    {
                        MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    frmAutoventa auto = new frmAutoventa();
                    auto.MdiParent = this;
                    auto.Show();
                }
                else
                {
                    if (e.KeyCode == Keys.F10)
                    {
                        if (Bs_Usuario.usuarioActual == 0)
                        {
                            MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        frmVenta venta = new frmVenta();
                        venta.MdiParent = this;
                        venta.Show();
                    }
                    else
                    {
                        if (e.KeyCode == Keys.F11)
                        {
                            if (Bs_Usuario.usuarioActual == 0)
                            {
                                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            Process.Start(@"C:\Windows\System32\calc.exe");
                        }
                    }

                }
            }
        }

        private void utilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmVerUtilidad uti = new frmVerUtilidad();
            uti.MdiParent = this;
            uti.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmSaldoEnvaseXArea env = new frmSaldoEnvaseXArea();
            env.MdiParent = this;
            env.Show();
        }

        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmVerPedidosXRep rep = new frmVerPedidosXRep();
            rep.MdiParent = this;
            rep.Show();
        }

        private void cuadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCuadre cuadre = new frmCuadre();
            cuadre.MdiParent = this;
            cuadre.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCobrosTrabajadores trab = new frmCobrosTrabajadores();
            trab.MdiParent = this;
            trab.Show();
        }

        private void cuadreAutoventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmcuadreAutoventa trab = new frmcuadreAutoventa();
            trab.MdiParent = this;
            trab.Show();
        }

        private void historialAbonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmHistorialAbonos histo = new frmHistorialAbonos();
            histo.MdiParent = this;
            histo.Show();
        }

        private void ventasCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmVentasCredito credito = new frmVentasCredito();
            credito.MdiParent = this;
            credito.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas nota = new frmNotas();
            nota.MdiParent = this;
            nota.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmVerAbonos abonos = new frmVerAbonos();
            abonos.MdiParent = this;
            abonos.Show();
        }

        private void clientesXProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmVerProductoxCliente clientes = new frmVerProductoxCliente();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Form f in this.MdiChildren)
            {
                if (f is FormProductosStockBajo)
                {
                    f.Activate();
                    return;
                }
            }

            FormProductosStockBajo stockbajo = new FormProductosStockBajo();
            stockbajo.MdiParent = this;
            stockbajo.Show();
        }

        private void resumenAdministrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bs_Usuario.usuarioActual == 0)
            {
                MessageBox.Show("Debe iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object valueinput = Interaction.InputBox("Ingrese su contraseña", "Validando", "");
            if (valueinput.ToString() == Bs_Usuario.password)
            {
                FormDashboardAdmin dash = new FormDashboardAdmin();
                dash.MdiParent = this;
                dash.Show();
            }
        }
    }
}
