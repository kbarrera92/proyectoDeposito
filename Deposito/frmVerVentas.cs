using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmVerVentas : Form
    {
        DataSet ds = new dsReportes();

        public frmVerVentas()
        {
            InitializeComponent();
        }

        //Llenar Datatable
        private void llenarDT()
        {
            ds = new dsReportes();
            DataTable dt;

            dt = ds.Tables["dtVentas"];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataRow drdesxcli = ds.Tables["dtVentas"].NewRow();
                drdesxcli["ID"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                drdesxcli["FECHA"] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                drdesxcli["CONCEPTO"] = dataGridView1.Rows[i].Cells[4].Value;
                drdesxcli["TOTAL"] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                
                ds.Tables["dtVentas"].Rows.Add(drdesxcli);
            }
        }

        private void llenarDT2()
        {
            ds = new dsReportes();
            DataTable dt;

            dt = ds.Tables["dtVentaDeta"];
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataRow drdesxcli = ds.Tables["dtVentaDeta"].NewRow();
                drdesxcli["ID"] = dataGridView2.Rows[i].Cells[0].Value.ToString();
                drdesxcli["PRODUCTO"] = dataGridView2.Rows[i].Cells[2].Value.ToString();
                drdesxcli["CANTIDAD"] = dataGridView2.Rows[i].Cells[3].Value;
                drdesxcli["PRECIO"] = dataGridView2.Rows[i].Cells[4].Value.ToString();
                drdesxcli["SUBTOTAL"] = dataGridView2.Rows[i].Cells[5].Value.ToString();
                drdesxcli["OBSERVACIONES"] = dataGridView2.Rows[i].Cells[6].Value.ToString() == null ? "" : dataGridView2.Rows[i].Cells[6].Value.ToString();
                ds.Tables["dtVentaDeta"].Rows.Add(drdesxcli);
            }
        }

        private void llenarDT3()
        {
            ds = new dsReportes();
            DataTable dt;

            dt = ds.Tables["dtVentaDeta"];
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                DataRow drdesxcli = ds.Tables["dtVentaDeta"].NewRow();
                drdesxcli["ID"] = dataGridView3.Rows[i].Cells[0].Value.ToString();
                drdesxcli["PRODUCTO"] = dataGridView3.Rows[i].Cells[1].Value.ToString();
                drdesxcli["CANTIDAD"] = dataGridView3.Rows[i].Cells[2].Value;
                drdesxcli["PRECIO"] = dataGridView3.Rows[i].Cells[3].Value.ToString();
                drdesxcli["SUBTOTAL"] = dataGridView3.Rows[i].Cells[4].Value.ToString();

                ds.Tables["dtVentaDeta"].Rows.Add(drdesxcli);
            }
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

        private void frmVerVentas_Load(object sender, EventArgs e)
        {
            Bs_Venta.llenardgv(dataGridView1);
            txttotalVentas.Text = string.Format("{0:N2}", calculartotal(dataGridView1, 5));
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Bs_Venta.llenardgvporusuario(dataGridView1, textBox1.Text);
                txttotalVentas.Text = string.Format("{0:N2}", calculartotal(dataGridView1, 5));
            }
            else
            {
                Bs_Venta.llenardgvporconcepto(dataGridView1, textBox1.Text);
                txttotalVentas.Text = string.Format("{0:N2}", calculartotal(dataGridView1, 5));
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bs_Venta.llenardgvporfechas(dataGridView1, dateTimePicker1.Value, dateTimePicker2.Value);
            Bs_Venta.llenardgvporfechascorte(dataGridView3, dateTimePicker1.Value, dateTimePicker2.Value);
            txttotalVentas.Text = string.Format("{0:N2}", calculartotal(dataGridView1, 5));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bs_Venta.llenardgv(dataGridView1);
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            txttotalDetalles.Text = "0.00";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long nventa = long.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Bs_Venta.llenardgvdetalles(dataGridView2, nventa);
            txttotalDetalles.Text = string.Format("{0:N2}", calculartotal(dataGridView2, 5));
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                //Mensaje
                MessageBox.Show("No se puede mostrar el reporte", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ds = new dsReportes();
                llenarDT2();

                try
                {
                    rptVentaDeta informe = new rptVentaDeta();
                    informe.SetDataSource(ds.Tables["dtVentaDeta"]);
                    informe.SetParameterValue("noventa", long.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    informe.SetParameterValue("fechaventa", dataGridView1.CurrentRow.Cells[1].Value);
                    informe.SetParameterValue("cliente", dataGridView1.CurrentRow.Cells[4].Value);
                    frmVerReportes reporte = new frmVerReportes();
                    reporte.crystalReportViewer1.ReportSource = informe;
                    //MessageBox.Show(ds.Tables["dtreporteviajes"].Rows.Count.ToString());
                    reporte.Show();
                }
                catch (Exception)
                {

                    throw;
                }
                //Mostrar reporte
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                    rptVentas informe = new rptVentas();
                    informe.SetDataSource(ds.Tables["dtVentas"]);
                    informe.SetParameterValue("fechainicio", dateTimePicker1.Value);
                    informe.SetParameterValue("fechafinal", dateTimePicker2.Value);
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                //mensaje
                MessageBox.Show("No se puede mostrar el reporte", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ds = new dsReportes();
                llenarDT3();

                try
                {
                    rptCorteCaja informe = new rptCorteCaja();
                    informe.SetDataSource(ds.Tables["dtVentaDeta"]);
                    informe.SetParameterValue("fechainicio", dateTimePicker1.Value);
                    informe.SetParameterValue("fechafinal", dateTimePicker2.Value);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if  (MessageBox.Show("¿Eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int venta = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (Bs_Venta.ValidaVentaCuadrada(venta))
                {
                    MessageBox.Show("La venta no se puede eliminar, ya fue cuadrada", "Hubo un error al eliminar la venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Bs_Venta.borrardetallesventas(venta))
                {
                    if (Bs_Venta.borrarventa(venta))
                    {
                        MessageBox.Show("Eliminada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bs_Venta.llenardgv(dataGridView1);
                        txttotalVentas.Text = string.Format("{0:N2}", calculartotal(dataGridView1, 5));
                        comboBox1.SelectedIndex = 0;

                    }
                }
                
            }

            frmPrincipal frmpadre = MdiParent as frmPrincipal;

            if (frmpadre != null)
            {
                frmpadre.toolStripButton5.Text =
                    $"Bajo Stock: {Bs_Producto.ConsultaProductosConBajoStock():0}";
                frmpadre.toolStripButton5.BackColor = (Bs_Producto.ConsultaProductosConBajoStock() > 0) ? Color.Salmon : Color.Transparent;
            }
        }
    }
}
