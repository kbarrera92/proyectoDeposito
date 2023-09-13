using System;
using System.Windows.Forms;
using Negocio;
using System.Data;
using System.Data.SqlClient;

namespace Deposito
{
    public partial class frmVerProductoxCliente : Form
    {
        private AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        public frmVerProductoxCliente()
        {
            InitializeComponent();
        }

        private double calculartotal(int col, DataGridView dgv)
        {
            double total = 0.0d;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += double.Parse(row.Cells[col].Value.ToString());
            }

            return total;
        }



        private void cargarData()
        {
            DataTable dt = new DataTable();
            SqlConnection myConn = new SqlConnection(Utils.ConsultaParametro("CS"));
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("mostrarProdxCliente2", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                coll.Add(dt.Rows[i]["DESCRIPCION"].ToString());
            }

            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = coll;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            txttotalsaldos.Clear();
            textBox1.Clear();
        }

        private void frmVerProductoxCliente_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlConnection myConn = new SqlConnection(Utils.ConsultaParametro("CS"));
                    myConn.Open();
                    SqlCommand myCmd = new SqlCommand("mostrarProdxCliente", myConn);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    myCmd.Parameters.AddWithValue("fecha", dateTimePicker1.Value.Date);
                    myCmd.Parameters.AddWithValue("str", textBox1.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    txttotalsaldos.Text = string.Format("{0:N2}", calculartotal(2, dataGridView1));
                }
                catch (Exception)
                {

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
