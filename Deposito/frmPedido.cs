using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Negocio;
using System.Drawing.Printing;

namespace Deposito
{
    public partial class frmPedido : Form
    {
        decimal saldo;
        long npedido;
        private decimal costo;

        DataSet ds = new dsReportes();
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            Bs_Producto.llenardgv(dataGridView1);
            Bs_Cliente.llenarcmbclientetodos(lstclientes);
            txtsaldo.Clear();
            if (!Bs_Usuario.isAdmin) dataGridView1.Columns["Costo"].Visible = false;
        }

        private void lstclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtsaldo.Text = Bs_Cliente.obtenersaldo(int.Parse(lstclientes.SelectedValue.ToString())).ToString();
            }
            catch (Exception)
            {

               
            }
            
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndescartar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Debe seleccionar un detalle para eliminarlo", "Seleccione un detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show(this, "Desea eliminar este detalle?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                    txttotal.Text = string.Format("{0:N2}", calculartotal());
                }
            }
        }

        private double calculartotal()
        {
            double total = 0.00d;

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                total += double.Parse(fila.Cells[4].Value.ToString());
            }

            return total;
        }

        private void limpiardatos()
        {
            txtcodpro.Clear();
            txtdesc.Clear();
            txtexistencia.Text = "0";
            txtprecio.Text = "0.00";
            txtcantidad.Text = "0";
            txtsubtotal.Text = "0.00";
            txtdetsabores.Clear();
            txtbuscar.Clear();
            txtbuscar.Select();
            costo = 0m;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (Decimal.Parse(txtexistencia.Text) >= decimal.Parse(txtcantidad.Text))
            {
                if (!txtprecio.Text.Trim().Equals(""))
                {
                    
                    dataGridView2.Rows.Add(txtcodpro.Text, txtdesc.Text, txtcantidad.Text, string.Format("{0:N2}", decimal.Parse(txtprecio.Text)), txtsubtotal.Text, txtdetsabores.Text, costo);
                    txttotal.Text = string.Format("{0:N2}",calculartotal());
                    limpiardatos();
                }
                else
                {
                    MessageBox.Show(this, "No ha ingresado cantidad a vender", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(this, "No hay existencia disponible", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            agregarpedido();
        }


        private void agregarpedido()
        {
            if (lstclientes.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "No ha seleccionado ningun cliente", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show(this, "No hay ningun detalle asociado a este pedido", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Entidad.PEDIDO pedido = new Entidad.PEDIDO()
                    {
                        FECHA = dateTimePicker1.Value,
                        CLIENTE = int.Parse(lstclientes.SelectedValue.ToString()),
                        USUARIO = Bs_Usuario.usuarioActual,
                        TOTAL = decimal.Parse(txttotal.Text),
                        REPCOBRO = null
                    };

                    int cliente = int.Parse(lstclientes.SelectedValue.ToString());
                    saldo = Bs_Cliente.obtenersaldo(cliente);

                    if (Bs_Venta.registrarpedido(pedido))
                    {

                        agregardetallepedido();                       
                        

                        //MessageBox.Show(this, "Compra registrada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txttotal.Clear();
                        dataGridView2.Rows.Clear();
                        Bs_Producto.llenardgv(dataGridView1);
                        limpiardatos();
                        txtsaldo.Clear();
                        txtbuscar.Select();
                    }
                    else
                    {
                        MessageBox.Show(this, "Hubo un error al registrar el pedido", "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Reporte
        private void llenarDT()
        {
            ds = new dsReportes();
            DataTable dt;

            dt = ds.Tables["dtPedido"];
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var descripcion = dataGridView2.Rows[i].Cells[1].Value.ToString() + "(" + dataGridView2.Rows[i].Cells[5].Value.ToString() + ")";
                DataRow drdesxcli = ds.Tables["dtPedido"].NewRow();
                drdesxcli["ID"] = i + 1;
                drdesxcli["DESCRIPCION"] = descripcion;
                drdesxcli["CANTIDAD"] = dataGridView2.Rows[i].Cells[2].Value;
                drdesxcli["PRECIO"] = dataGridView2.Rows[i].Cells[3].Value;
                drdesxcli["SUBTOTAL"] = dataGridView2.Rows[i].Cells[4].Value.ToString();

                ds.Tables["dtPedido"].Rows.Add(drdesxcli);
            }
        }

        private void agregardetallepedido()
        {
            try
            {
                using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
                {
                    long ultimopedido = db.PEDIDO.Max(x => x.ID);
                    npedido = ultimopedido;

                    for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                    {
                        Entidad.PEDIDODETA venta = new Entidad.PEDIDODETA()
                        {
                            ID = i + 1,
                            IDPEDIDO = ultimopedido,
                            IDPRODUCTO = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()),
                            CANTIDAD = decimal.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()),
                            PRECIO = decimal.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()),
                            SUBTOTAL = decimal.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString()),
                            DETALLESAB = dataGridView2.Rows[i].Cells[5].Value.ToString(),
                            COSTOPED = decimal.Parse(dataGridView2.Rows[i].Cells[6].Value.ToString())
                        };

                        Bs_Venta.registrardetallespedido(venta);
                    }

                    llenarDT();
                    MessageBox.Show(this, "Pedido registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    try
                    {
                        rptPedidos informe = new rptPedidos();
                        informe.SetDataSource(ds.Tables["dtPedido"]);
                        informe.SetParameterValue("npedido", ultimopedido);
                        informe.SetParameterValue("fecha", dateTimePicker1.Value.Date);
                        informe.SetParameterValue("cliente", lstclientes.Text);
                        informe.SetParameterValue("saldo", saldo);
                        frmVerReportes reporte = new frmVerReportes();
                        reporte.crystalReportViewer1.ReportSource = informe;
                        //MessageBox.Show(ds.Tables["dtreporteviajes"].Rows.Count.ToString());
                        reporte.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodpro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            costo = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txtprecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtexistencia.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtprecio.Select();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            if (txtprecio.Text.Trim().Equals(""))
            {
                txtsubtotal.Text = "0.00";
            }
            else
            {
                txtsubtotal.Text = string.Format("{0}", double.Parse(txtprecio.Text) * double.Parse(txtcantidad.Text));
            }
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtcantidad.Text.Equals(""))
            {
                txtsubtotal.Text = "0.00";
            }
            else
            {
                txtsubtotal.Text = string.Format("{0:N2}", double.Parse(txtprecio.Text) * double.Parse(txtcantidad.Text));
            }
        }

        private void txtprecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                txtcantidad.Select();
            }
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (decimal.Parse(txtcantidad.Text) <= 0)
            {
                MessageBox.Show("Cantidad invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                txtdetsabores.Select();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font f1 = new Font("Constantia", 15, FontStyle.Bold, GraphicsUnit.Point);
            Font f2 = new Font("Constantia", 14, FontStyle.Bold, GraphicsUnit.Point);
            Font f3 = new Font("Constantia", 12, FontStyle.Regular, GraphicsUnit.Point);

            Pen pen = new System.Drawing.Pen(Brushes.Black, 2);

            e.Graphics.DrawString("Pedido No _____" + npedido + "______", f1, Brushes.Black, new PointF(50, 15));
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), f1, Brushes.Black, new PointF(320, 15));
            e.Graphics.DrawString("Deposito Nohemí", f1, Brushes.Black, new PointF(50, 40));
            e.Graphics.DrawString("Teléfono: 3121-8864", f1, Brushes.Black, new PointF(50, 65));
            e.Graphics.DrawString("Cliente: " + lstclientes.Text + " ------ Saldo: " + saldo, f1, Brushes.Black, new PointF(50, 90));
            e.Graphics.DrawImage(Image.FromFile("Deposito.jpg"), 635, 15, 150, 100);
            e.Graphics.DrawLine(pen, new Point(50, 125), new Point(780, 125));

            e.Graphics.DrawString("No.", f2, Brushes.Blue, new PointF(55, 135));
            e.Graphics.DrawString("Descripción", f2, Brushes.Blue, new PointF(130, 135));
            e.Graphics.DrawString("Cantidad", f2, Brushes.Blue, new PointF(420, 135));
            e.Graphics.DrawString("Precio", f2, Brushes.Blue, new PointF(540, 135));
            e.Graphics.DrawString("Subtotal", f2, Brushes.Blue, new PointF(660, 135));

            int ini = 170;
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                e.Graphics.DrawString((fila.Index + 1).ToString(), f3, Brushes.Black, new PointF(55, ini));
                e.Graphics.DrawString(fila.Cells[1].Value.ToString() + " (" + fila.Cells[5].Value.ToString() + ")", f3, Brushes.Black, new PointF(130, ini));
                e.Graphics.DrawString(fila.Cells[2].Value.ToString(), f3, Brushes.Black, new PointF(420, ini));
                e.Graphics.DrawString(fila.Cells[3].Value.ToString(), f3, Brushes.Black, new PointF(540, ini));
                e.Graphics.DrawString(fila.Cells[4].Value.ToString(), f3, Brushes.Black, new PointF(660, ini));

                ini += 20;
            }

            e.Graphics.DrawString("Total: " + txttotal.Text, f1, Brushes.Blue, new PointF(580, 520));
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Bs_Producto.filtrardgv(dataGridView1, txtbuscar.Text.Trim());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Bs_Cliente.llenarcmbclientefiltro(lstclientes, txtbuscarcliente.Text.Trim());

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnagregar.PerformClick();
            }
        }

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F7)
            {
                btnregistrar.PerformClick();
            }
        }
    }
}
