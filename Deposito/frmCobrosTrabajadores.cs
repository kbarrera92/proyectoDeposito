using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
namespace Deposito
{
    public partial class frmCobrosTrabajadores : Form
    {
        public frmCobrosTrabajadores()
        {
            InitializeComponent();
        }

        private decimal calculartotal()
        {
            decimal total = 0.00m;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {                
                total = total + decimal.Parse(item.Cells[4].Value.ToString());                
            }

            return total;
        }

        private decimal calculartotalcobrado()
        {
            decimal total = 0.00m;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total = total + decimal.Parse(item.Cells[5].Value.ToString());
            }

            return total;
        }
        private void frmCobrosTrabajadores_Load(object sender, EventArgs e)
        {
            Bs_Repartidor.llenarcmb(comboBox1);
        }

        private void cargarmovs(DataGridView datagrid)
        {
            DataTable dt = new DataTable();
            SqlConnection myConn = new SqlConnection(Negocio.Utils.ConsultaParametro("CS"));
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("listarpedventasxtrab", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.AddWithValue("fecha", dateTimePicker1.Value.Date);
            myCmd.Parameters.AddWithValue("trab", int.Parse(comboBox1.SelectedValue.ToString()));

            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            datagrid.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarmovs(dataGridView1);
            txttotal.Text = string.Format("{0:N2}", calculartotal());
            txttotalcobrado.Text = string.Format("{0:N2}", calculartotalcobrado());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
