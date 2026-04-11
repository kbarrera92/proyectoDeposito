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

namespace Deposito
{
    public partial class FormControlCajaExterna : Form
    {
        private DataView dv;
        public FormControlCajaExterna()
        {
            InitializeComponent();
        }

        private void checkBoxPorRegistro_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxPorRegistro.Checked) return;

            checkBoxPorDia.Checked = false;
        }

        private void checkBoxPorDia_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxPorDia.Checked) return;

            checkBoxPorRegistro.Checked = false;
        }

        private void CargarMovimientos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection myConn = new SqlConnection(Negocio.Utils.ConsultaParametro("CS"));
                myConn.Open();
                SqlCommand myCmd = new SqlCommand("sp_ControlCajaExterna", myConn);
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.Parameters.AddWithValue("OPCION", checkBoxPorRegistro.Checked ? 1 : 2);
                myCmd.Parameters.AddWithValue("FILAS", checkBoxPorRegistro.Checked ? numericUpDownPorRegistro.Value : numericUpDownPorDia.Value);

                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                dv = dt.DefaultView;
                dataGridView1.DataSource = dv;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los movimientos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarMovimientos();
        }
    }
}
