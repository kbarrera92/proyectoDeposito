using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Deposito
{
    public partial class frmCarteraClientes : Form
    {
        DataSet ds = new dsReportes();
        public frmCarteraClientes()
        {
            InitializeComponent();
        }

        private void llenarDT()
        {
            ds = new dsReportes();
            DataTable dt;
            try
            {
                dt = ds.Tables["dtClientes"];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataRow drdesxcli = ds.Tables["dtClientes"].NewRow();
                    drdesxcli["ID"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    drdesxcli["CODIGO"] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    drdesxcli["NOMBRE"] = dataGridView1.Rows[i].Cells[2].Value;
                    drdesxcli["AREA"] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    drdesxcli["DIRECCION"] = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    drdesxcli["TELEFONO"] = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    drdesxcli["SALDO"] = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value.ToString());

                    ds.Tables["dtClientes"].Rows.Add(drdesxcli);
                }
            }
            catch (Exception)
            {

                
            }

            
        }

        private double calculartotal()
        {
            double total = 0;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total += double.Parse(item.Cells[6].Value.ToString());
            }

            return total;
        }

        private void frmCarteraClientes_Load(object sender, EventArgs e)
        {
           
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "Id";
            dataGridView1.Columns[1].DataPropertyName = "Codigo";
            dataGridView1.Columns[2].DataPropertyName = "Nombre";
            dataGridView1.Columns[3].DataPropertyName = "Area";
            dataGridView1.Columns[4].DataPropertyName = "Direccion";
            dataGridView1.Columns[5].DataPropertyName = "Telefono";
            dataGridView1.Columns[6].DataPropertyName = "Saldo";
            Bs_Cliente.llenardgv(dataGridView1);
            comboBox1.SelectedIndex = 0;
            txttotalsaldos.Text = string.Format("Q {0:N2}", calculartotal());
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(txtsaldo.Text) > 0)
            {
                txtsaldo.BackColor = Color.Red;
                txtsaldo.ForeColor = Color.Yellow;
            }
            else
            {
                txtsaldo.BackColor = Color.Blue;
                txtsaldo.ForeColor = Color.Yellow;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtcodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcliente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtdireccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txttelefono.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtsaldo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnabonoasaldo_Click(object sender, EventArgs e)
        {
            Bs_Cliente.idcliente = int.Parse(txtidcliente.Text);
            Bs_Cliente.codigocliente = txtcodigo.Text.Trim();
            Bs_Cliente.nombrecliente = txtcliente.Text.Trim();
            Bs_Cliente.saldo = double.Parse(txtsaldo.Text.Trim());

            frmAbonoASaldo abonoASaldo = new frmAbonoASaldo();
            abonoASaldo.ShowDialog();

            if (abonoASaldo.DialogResult == DialogResult.OK)
            {
                Bs_Cliente.llenardgv(dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bs_Cliente.llenardgv(dataGridView1);
            comboBox1.SelectedIndex = 0;
            txttotalsaldos.Text = string.Format("Q {0:N2}", calculartotal());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Bs_Cliente.filtrarxnombre(dataGridView1, txtbuscar.Text.Trim());
                txttotalsaldos.Text = string.Format("Q {0:N2}", calculartotal());
            }
            else
            {
                Bs_Cliente.filtrarxarea(dataGridView1, txtbuscar.Text.Trim());
                txttotalsaldos.Text = string.Format("Q {0:N2}", calculartotal());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                //mensaje
                MessageBox.Show("No se puede mostrar el reporte", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ds = new dsReportes();
                llenarDT();

                try
                {
                    rptSaldos informe = new rptSaldos();
                    informe.SetDataSource(ds.Tables["dtClientes"]);
                    informe.SetParameterValue("area", txtbuscar.Text);
                    frmVerReportes reporte = new frmVerReportes();
                    reporte.crystalReportViewer1.ReportSource = informe;
                    //MessageBox.Show(ds.Tables["dtreporteviajes"].Rows.Count.ToString());
                    reporte.Show();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btnverpedidos_Click(object sender, EventArgs e)
        {
            if (txtidcliente.Text.Trim().Equals(""))
            {
                MessageBox.Show("No ha seleccionado a ningún cliente", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bs_Cliente.idcliente = int.Parse(txtidcliente.Text.Trim());
                Bs_Cliente.nombrecliente = txtcliente.Text.Trim();
                frmPedidoCliente pedcliente = new frmPedidoCliente();
                
                pedcliente.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                //mensaje
                MessageBox.Show("No se puede mostrar el reporte", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ds = new dsReportes();
                llenarDT();

                try
                {
                    rptHojaAutoventa informe = new rptHojaAutoventa();
                    informe.SetDataSource(ds.Tables["dtClientes"]);
                    informe.SetParameterValue("area", txtbuscar.Text);
                    frmVerReportes reporte = new frmVerReportes();
                    reporte.crystalReportViewer1.ReportSource = informe;
                    //MessageBox.Show(ds.Tables["dtreporteviajes"].Rows.Count.ToString());
                    reporte.Show();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }
    }
}
