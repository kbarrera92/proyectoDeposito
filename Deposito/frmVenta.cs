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
    public partial class frmVenta : Form
    {
        DataSet ds = new DataSet();
        decimal costo;
        public frmVenta()
        {
            InitializeComponent();
            
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnregistrar, "Guardar venta");
            toolTip1.SetToolTip(btndescartar, "Descartar venta. Se borraran todos los cambios");
            toolTip1.SetToolTip(btnsalir, "Salir de esta ventana");
            toolTip1.SetToolTip(btnagregar, "Agregar detalle");
            Bs_Producto.llenardgv(dataGridView1);
            if (!Bs_Usuario.isAdmin) dataGridView1.Columns["Costo"].Visible = false;
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
            if (txtprecio.Text.Equals(""))
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txtexistencia.Text) >= decimal.Parse(txtcantidad.Text))
            {
                if (!txtprecio.Text.Trim().Equals(""))
                {
                    dataGridView2.Rows.Add(txtcodpro.Text, txtdesc.Text, txtcantidad.Text, string.Format("{0:N2}",decimal.Parse(txtprecio.Text)), txtsubtotal.Text, txtobs.Text, costo);
                    txttotal.Text = string.Format("{0:N2}", calculartotal());
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

        private double calculartotal()
        {
            double total = 0.00d;

            foreach  (DataGridViewRow fila in dataGridView2.Rows)
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
            txtbuscar.Clear();
            txtobs.Clear();
            costo = 0m;
            txtbuscar.Select();
        }

        private void txtprecio_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                txtcantidad.Select();
            }
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtobs.Select();
                
            }
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
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            agregarventa();
        }

        private void agregarventa()
        {
            if (txtconcepto.Text == "")
            {
                errorProvider1.SetError(txtconcepto, "Este campo es obligarorio");
                return;
            }
            else
            {
                errorProvider1.SetError(txtconcepto, "");
                if (dataGridView2.Rows.Count <= 0)
                {
                    errorProvider1.SetError(dataGridView2, "No hay ningun producto para agregar");
                    return;
                }
                else
                {
                    errorProvider1.SetError(dataGridView2, "");
                }
            }

            Entidad.VENTA venta = new Entidad.VENTA
            {
                FECHA = dateTimePicker1.Value,
                HORA = DateTime.Now.ToShortTimeString(),                                
                TOTAL = Convert.ToDecimal(txttotal.Text),                
                USUARIO = Bs_Usuario.usuarioActual,
                CONCEPTO = txtconcepto.Text.Trim()
                
                
            };

            if (Bs_Venta.registrarventa(venta))
            {
                
                agregardetalleventa();
                //MessageBox.Show(this, "Compra registrada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView2.Rows.Clear();
                Bs_Producto.llenardgv(dataGridView1);
                limpiardatos();
            }
            else
            {
                MessageBox.Show(this, "Hubo un error al registrar la venta", "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregardetalleventa()
        {
            try
            {
                using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
                {
                    long ultimaventa = db.VENTA.Max(x => x.ID);
                
                    for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                    {
                        Entidad.VENTADETA venta = new Entidad.VENTADETA()
                        {
                            ID = i + 1,
                            VENTA = ultimaventa,
                            IDPRODUCTO = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()),
                            CANTIDAD = decimal.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()),
                            PRECIO = decimal.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()),
                            SUBTOTAL = decimal.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString()),
                            DESCRIPCION = dataGridView2.Rows[i].Cells[5].Value.ToString(),
                            COSTO = decimal.Parse(dataGridView2.Rows[i].Cells[6].Value.ToString())
                        };

                        Bs_Venta.registrardetalles(venta);
                    }

                    llenarDT();

                    MessageBox.Show(this, "Venta registrada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        rptVentaDeta informe = new rptVentaDeta();
                        informe.SetDataSource(ds.Tables["dtVentaDeta"]);
                        informe.SetParameterValue("noventa", ultimaventa);
                        informe.SetParameterValue("fechaventa", dateTimePicker1.Value.Date);
                        informe.SetParameterValue("cliente", txtconcepto.Text);
                        //informe.SetParameterValue("saldo", saldo);
                        frmVerReportes reporte = new frmVerReportes();
                        reporte.crystalReportViewer1.ReportSource = informe;
                        //MessageBox.Show(ds.Tables["rptVentaDeta"].Rows.Count.ToString());
                        reporte.Show();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    txttotal.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void llenarDT()
        {
            ds = new dsReportes();
            DataTable dt;

            dt = ds.Tables["dtVentaDeta"];
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataRow drdesxcli = ds.Tables["dtVentaDeta"].NewRow();
                drdesxcli["ID"] = i + 1;
                drdesxcli["PRODUCTO"] = dataGridView2.Rows[i].Cells[1].Value.ToString();
                drdesxcli["CANTIDAD"] = Convert.ToDecimal(dataGridView2.Rows[i].Cells[2].Value);
                drdesxcli["PRECIO"] = dataGridView2.Rows[i].Cells[3].Value;
                drdesxcli["SUBTOTAL"] = dataGridView2.Rows[i].Cells[4].Value;
                drdesxcli["OBSERVACIONES"] = dataGridView2.Rows[i].Cells[5].Value.ToString();

                ds.Tables["dtVentaDeta"].Rows.Add(drdesxcli);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Bs_Compra.filtrardgv(dataGridView1, txtbuscar.Text);
        }

        private void txtobs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnagregar.PerformClick();
            }
        }
    }
}
