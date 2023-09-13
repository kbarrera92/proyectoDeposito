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
    public partial class frmInventario : Form
    {
        DataSet ds = new dsReportes();
        public frmInventario()
        {
            InitializeComponent();
        }

        private void llenarDT()
        {
            ds = new dsReportes();
            DataTable dt;

            dt = ds.Tables["dtProducto"];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataRow drdesxcli = ds.Tables["dtProducto"].NewRow();
                drdesxcli["ID"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                drdesxcli["DESCRIPCION"] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                drdesxcli["COSTO"] = dataGridView1.Rows[i].Cells[2].Value;
                drdesxcli["PRECIO"] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                drdesxcli["PRESENTACION"] = dataGridView1.Rows[i].Cells[4].Value.ToString();
                drdesxcli["MARCA"] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                drdesxcli["EXISTENCIA"] = dataGridView1.Rows[i].Cells[6].Value.ToString();

                ds.Tables["dtProducto"].Rows.Add(drdesxcli);
            }
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            Bs_Producto.llenardgv(dataGridView1);
            if (!Bs_Usuario.isAdmin) dataGridView1.Columns["Costo"].Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Bs_Usuario.isAdmin)
            {
                MessageBox.Show("No tiene acceso a este módulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                    rptInventario informe = new rptInventario();
                    informe.SetDataSource(ds.Tables["dtProducto"]);
                    
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
    }
}
