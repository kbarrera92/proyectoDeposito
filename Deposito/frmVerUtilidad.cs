using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmVerUtilidad : Form
    {
        public frmVerUtilidad()
        {
            InitializeComponent();
        }

        private void cargarUtilidad(DataGridView datagrid)
        {
            DataTable dt = new DataTable();
            SqlConnection myConn = new SqlConnection(Negocio.Utils.ConsultaParametro("CS"));
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("mostrarUtilidadNew", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.AddWithValue("ini", dateTimePicker1.Value.Date);
            myCmd.Parameters.AddWithValue("fin", dateTimePicker2.Value.Date);
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            datagrid.DataSource = dt;

        }

        private double calculartotal(DataGridView dgv, short col)
        {
            double total = 0;

            foreach (DataGridViewRow item in dgv.Rows)
            {
                total += double.Parse(item.Cells[col].Value.ToString());
            }

            return total;
        }

        private void frmVerUtilidad_Load(object sender, EventArgs e)
        {
            dataGridView4.Columns[0].DataPropertyName = "ID";
            dataGridView4.Columns[1].DataPropertyName = "DESCRIPCION";
            dataGridView4.Columns[2].DataPropertyName = "CANTIDAD";
            dataGridView4.Columns[3].DataPropertyName = "PRECIO";
            dataGridView4.Columns[4].DataPropertyName = "COSTO";
            dataGridView4.Columns[5].DataPropertyName = "UTILIDAD";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarUtilidad(dataGridView4);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cargarUtilidad(dataGridView4);
            txttotalUtilidades.Text = string.Format("{0:N2}", calculartotal(dataGridView4, 5));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView4.DataSource = null;
            dataGridView4.Rows.Clear();
            txttotalUtilidades.Text = "0.00";
        }
    }
}
