using Negocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace Deposito
{
    public partial class frmCuadre : Form
    {
        private DataView dv;
        public frmCuadre()
        {
            InitializeComponent();
        }

        private void cargarmovs(DataGridView datagrid)
        {
            DataTable dt = new DataTable();
            SqlConnection myConn = new SqlConnection(Negocio.Utils.ConsultaParametro("CS"));
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("listarpedventas", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.AddWithValue("fecha", dateTimePicker1.Value.Date);

            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dv = dt.DefaultView;
            datagrid.DataSource = dv;

        }

        private void frmCuadre_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].DataPropertyName = "FECHA";
            dataGridView1.Columns[2].DataPropertyName = "CLI";
            dataGridView1.Columns[3].DataPropertyName = "NOMBRE";
            dataGridView1.Columns[5].DataPropertyName = "TOTAL";

            dataGridView1.Columns[4].DataPropertyName = "TIPO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarmovs(dataGridView1);
            Negocio.Bs_Repartidor.llenarcmb(comboBox1);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private decimal calculartotal()
        {
            decimal total = 0.00m;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[7].Value) == true)
                {
                    total = total + decimal.Parse(item.Cells[5].Value.ToString());
                }
            }

            return total;
        }

        private decimal calculartotalcobrado()
        {
            decimal total = 0.00m;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[7].Value) == true)
                {
                    try
                    {
                        total = total + decimal.Parse(item.Cells[6].Value.ToString());
                    }
                    catch (Exception)
                    {

                        //throw;
                    }

                }
            }

            return total;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                


                if (decimal.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()) >= 0.00m)
                {
                    dataGridView1.CurrentRow.Cells[7].Value = true;
                    textBox1.Text = calculartotal().ToString();
                    textBox2.Text = calculartotalcobrado().ToString();
                }
                else
                {
                    dataGridView1.CurrentRow.Cells[7].Value = true;
                    textBox1.Text = calculartotal().ToString();
                    textBox2.Text = calculartotalcobrado().ToString();
                }


            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
                {
                    textBox1.Text = calculartotal().ToString();
                    textBox2.Text = calculartotalcobrado().ToString();
                }
                else
                {
                    //do something
                    textBox1.Text = calculartotal().ToString();
                    textBox2.Text = calculartotalcobrado().ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[6].Value == null && Convert.ToBoolean(item.Cells[7].Value))
                {
                    MessageBox.Show("Faltan datos. Revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                bool success = Convert.ToBoolean(item.Cells[7].Value);

                if (success == true)
                {
                    if (item.Cells[4].Value.ToString().Equals("VENTA"))
                    {
                        if (decimal.Parse(item.Cells[6].Value.ToString()) < decimal.Parse(item.Cells[5].Value.ToString()))
                        {
                            decimal toti = decimal.Parse(string.Format("{0:N2}", decimal.Parse(item.Cells[6].Value.ToString())));
                            Negocio.Bs_Venta.eliminarVenta(int.Parse(item.Cells[0].Value.ToString()), int.Parse(comboBox1.SelectedValue.ToString()),toti);
                            Entidad.VENTASCREDITO vc = new Entidad.VENTASCREDITO()
                            {
                                ID = int.Parse(item.Cells[0].Value.ToString()),
                                FECHA = dateTimePicker1.Value.Date,
                                CONCEPTO = item.Cells[3].Value.ToString(),
                                TOTAL = decimal.Parse(item.Cells[5].Value.ToString()) - decimal.Parse(item.Cells[6].Value.ToString()),
                                COBRADA = null

                            };
                            if (Bs_Venta.registrarventacredito(vc))
                            {
                                
                            }
                        }
                        else
                        {
                            Negocio.Bs_Venta.cobrarVenta(int.Parse(item.Cells[0].Value.ToString()), int.Parse(comboBox1.SelectedValue.ToString()));
                        }

                        Entidad.BITACORAVENTASTRAB bit = new Entidad.BITACORAVENTASTRAB()
                        {
                            FECHA = dateTimePicker1.Value.Date,
                            CONCEPTO = item.Cells[3].Value.ToString(),
                            TIPO = "VENTA",
                            TOTAL = decimal.Parse(item.Cells[5].Value.ToString()),
                            COBRADO = decimal.Parse(item.Cells[6].Value.ToString()),
                            TRABAJADOR = int.Parse(comboBox1.SelectedValue.ToString())
                        };
                        Bs_Venta.registrarbitacoraventa(bit);
                    }
                    else
                    {
                        if (item.Cells[4].Value.ToString().Equals("PEDIDO"))
                        {
                            
                            if (decimal.Parse(item.Cells[6].Value.ToString()) >= 0)
                            {

                                int cliente = int.Parse(item.Cells[2].Value.ToString());
                                decimal total = decimal.Parse(string.Format("{0:N2}", decimal.Parse(item.Cells[5].Value.ToString())));

                                //Abono a saldo
                                Entidad.ABONOASALDO abono = new Entidad.ABONOASALDO()
                                {
                                    CLIENTE = cliente,
                                    IMPORTE = decimal.Parse(item.Cells[6].Value.ToString()),
                                    FECHA = Convert.ToDateTime(item.Cells[1].Value.ToString())

                                };

                                if (Bs_Pedido.crearAbono(abono))
                                {
                                    Entidad.BIT_ABONOSYSALDOS bita = new Entidad.BIT_ABONOSYSALDOS()
                                    {
                                        IDCLUENTE = cliente,
                                        FECHA = Convert.ToDateTime(item.Cells[1].Value.ToString()),
                                        TOTAL = total,
                                        COBRADO = Convert.ToDecimal(Math.Round(double.Parse(item.Cells[6].Value.ToString()), 2)),
                                        SALDO = Bs_Cliente.obtenersaldo(cliente),
                                        PEDIDO = int.Parse(item.Cells[0].Value.ToString())
                                    };

                                    Bs_Cliente.crearhistorialsaldos(bita);

                                    Bs_Venta.eliminarpedido(int.Parse(item.Cells[0].Value.ToString()), int.Parse(comboBox1.SelectedValue.ToString()));
                                }                                                      
                                
                            }
                            else
                            {

                            }
                            
                        }
                    }
                }



            }

            MessageBox.Show("Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargarmovs(dataGridView1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string valor = row.Cells["NOMBRE"].Value.ToString();
                string encontrar = "" + textBox3.Text + "";
                bool encontrado = valor.StartsWith(encontrar);
                if (encontrado)
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[row.Index].Cells[0];
                    return;
                }
            }
            
        }
    }
}
