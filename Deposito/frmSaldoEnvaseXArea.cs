using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Deposito
{
    public partial class frmSaldoEnvaseXArea : Form
    {
        int idsaldoenvase = 0;
        private DataSet ds;
        public frmSaldoEnvaseXArea()
        {
            InitializeComponent();
        }

        private void llenarDt()
        {
            ds = new dsReportes();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataRow dr = ds.Tables["dtEnvase"].NewRow();
                dr["ID"] = dataGridView1.Rows[i].Cells[0].Value;
                dr["CONCEPTO"] = dataGridView1.Rows[i].Cells[1].Value;
                dr["DESCRIPCION"] = dataGridView1.Rows[i].Cells[2].Value;
                dr["CANTIDAD"] = dataGridView1.Rows[i].Cells[3].Value;
                dr["FECHAPRESTADO"] = dataGridView1.Rows[i].Cells[4].Value;

                ds.Tables["dtEnvase"].Rows.Add(dr);
            }
        }

        private void cargarhistorial(DataGridView datagrid)
        {
            string sp = "historial";
            SqlCommand comando = new SqlCommand();
            SqlConnection myConn = new SqlConnection(Negocio.Utils.ConsultaParametro("CS"));
            myConn.Open();
            comando.Connection = myConn;
            comando.CommandText = sp;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("concepto", string.Format("%{0}%",textBox1.Text.Trim()));
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(table);
            datagrid.DataSource = table;
        }

        private void cargarhistorialtodo(DataGridView datagrid)
        {
            string sp = "todohistorial";
            SqlCommand comando = new SqlCommand();
            SqlConnection myConn = new SqlConnection(Negocio.Utils.ConsultaParametro("CS"));
            myConn.Open();
            comando.Connection = myConn;
            comando.CommandText = sp;
            comando.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(table);
            datagrid.DataSource = table;
        }

        private void frmSaldoEnvaseXArea_Load(object sender, EventArgs e)
        {
            cargarhistorialtodo(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarhistorial(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAgregarEnvase envase = new frmAgregarEnvase();
            envase.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idsaldoenvase = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idsaldoenvase == 0)
            {
                MessageBox.Show("No ha elegido un saldo", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿El envase ya fue devuelto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Negocio.Bs_Venta.devolverenvase(idsaldoenvase))
                    {
                        MessageBox.Show("Registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarhistorialtodo(dataGridView1);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ds = new dsReportes();
            try
            {
                llenarDt();

                var informe = new rptEnvase();
                informe.SetDataSource(ds.Tables["dtEnvase"]);

                frmVerReportes reporte = new frmVerReportes();
                reporte.crystalReportViewer1.ReportSource = informe;
                reporte.Show();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            

        }
    }
}
