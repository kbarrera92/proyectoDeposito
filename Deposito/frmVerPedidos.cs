using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Negocio;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace Deposito
{
    public partial class frmVerPedidos : Form
    {
        DataSet ds = new dsReportes();
        public frmVerPedidos()
        {
            InitializeComponent();
        }

        //Reporte
        private void llenarDT()
        {
            ds = new dsReportes();
            DataTable dt;
            string detalles;
            dt = ds.Tables["dtPedido"];
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                detalles = dataGridView2.Rows[i].Cells[6].Value == null ? "" : dataGridView2.Rows[i].Cells[6].Value.ToString();
                DataRow drdesxcli = ds.Tables["dtPedido"].NewRow();
                drdesxcli["ID"] = i + 1;
                drdesxcli["DESCRIPCION"] = dataGridView2.Rows[i].Cells[2].Value.ToString() + "("
                    + detalles + ")";
                drdesxcli["CANTIDAD"] = dataGridView2.Rows[i].Cells[3].Value;
                drdesxcli["PRECIO"] = dataGridView2.Rows[i].Cells[4].Value;
                drdesxcli["SUBTOTAL"] = dataGridView2.Rows[i].Cells[5].Value.ToString();

                ds.Tables["dtPedido"].Rows.Add(drdesxcli);
            }
        }
        
        private void frmVerPedidos_Load(object sender, EventArgs e)
        {

            Bs_Pedido.llenardgv(dataGridView1);
            dataGridView1.Columns[4].Visible = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns[0].DataPropertyName = "ID";
            dataGridView2.Columns[1].DataPropertyName = "IDPRODUCTO";
            dataGridView2.Columns[2].DataPropertyName = "DESCRIPCION";
            dataGridView2.Columns[3].DataPropertyName = "CANTIDAD";
            dataGridView2.Columns[4].DataPropertyName = "PRECIO";
            dataGridView2.Columns[5].DataPropertyName = "SUBTOTAL";
            dataGridView2.Columns[6].DataPropertyName = "DETALLESAB";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnpedido.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtfechapedido.Text = String.Format("{0:dd/MM/yyyy}", dataGridView1.CurrentRow.Cells[1].Value);
            txtnombrecliente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblidcliente.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            Bs_Pedido.llenardgvdetalles(dataGridView2, int.Parse(txtnpedido.Text));
            txttotalpedido.Text = string.Format("{0:N2}", calculartotal());
        }

        private double calculartotal()
        {
            double total = 0.00d;

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                total += double.Parse(fila.Cells[5].Value.ToString());
            }

            return total;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Cells[5].Value = string.Format("{0:N2}", (double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) * double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString())));
                txttotalpedido.Text = string.Format("{0:N2}", calculartotal());
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Desea registrar este detalle?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }

        private void btneliminardetalle_Click(object sender, EventArgs e)
        {
            int ndetalle = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            int npedido = int.Parse(txtnpedido.Text);

            if (MessageBox.Show(this, "Desea eliminar este detalle?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bs_Pedido.borrardetalle(ndetalle, npedido);
                Bs_Pedido.llenardgvdetalles(dataGridView2, npedido);
                txttotalpedido.Text = string.Format("{0:N2}", calculartotal());
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminarpedido_Click(object sender, EventArgs e)
        {
            int npedido = int.Parse(txtnpedido.Text);
            if (MessageBox.Show(this, "Desea eliminar este pedido?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Bs_Pedido.borrardetallepedido(npedido))
                {
                    Bs_Pedido.borrarpedido(npedido);
                    Bs_Pedido.llenardgvdetalles(dataGridView2, npedido);
                    txttotalpedido.Text = string.Format("{0:N2}", calculartotal());
                    Bs_Pedido.llenardgv(dataGridView1);
                    txtnpedido.Clear();
                    txtnombrecliente.Clear();
                    txtfechapedido.Clear();
                }
                else
                {
                    MessageBox.Show("Algo salio mal", "Hubo un error al eliminar el pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProductos producto = new frmProductos();
            producto.Show();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Bs_Pedido.iddetallepedido = int.Parse(dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[0].Value.ToString()) + 1;
            Bs_Pedido.idpedido = int.Parse(txtnpedido.Text);
            frmAgregarDetallePedido agregar = new frmAgregarDetallePedido();
            agregar.ShowDialog();

            if (agregar.DialogResult == DialogResult.OK)
            {
                Bs_Pedido.llenardgvdetalles(dataGridView2, int.Parse(txtnpedido.Text));
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

            Bs_Pedido.filtrardgv(dataGridView1, txtbuscar.Text.Trim());
            dataGridView1.Columns[4].Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            llenarDT();
            //imprimirComprobante();
            try
            {
                rptPedidos informe = new rptPedidos();
                informe.SetDataSource(ds.Tables["dtPedido"]);
                informe.SetParameterValue("npedido", int.Parse(txtnpedido.Text.Trim()));
                informe.SetParameterValue("fecha", DateTime.Parse(txtfechapedido.Text));
                informe.SetParameterValue("cliente", txtnombrecliente.Text);
                informe.SetParameterValue("saldo", Bs_Cliente.obtenerSaldoAnterior(int.Parse(lblidcliente.Text)));
                frmVerReportes reporte = new frmVerReportes();
                reporte.crystalReportViewer1.ReportSource = informe;
                //MessageBox.Show(ds.Tables["dtreporteviajes"].Rows.Count.ToString());
                reporte.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font f1 = new Font("Constantia", 15, FontStyle.Bold, GraphicsUnit.Point);
            Font f2 = new Font("Constantia", 14, FontStyle.Bold, GraphicsUnit.Point);
            Font f3 = new Font("Constantia", 12, FontStyle.Regular, GraphicsUnit.Point);
            Pen pen = new System.Drawing.Pen(Brushes.Black, 2);

            e.Graphics.DrawString("Pedido No _____" + txtnpedido.Text + "______", f1, Brushes.Black, new PointF(50, 15));
            e.Graphics.DrawString("Fecha: " + txtfechapedido.Text, f1, Brushes.Black, new PointF(320, 15));
            e.Graphics.DrawString("Deposito Nohemí", f1, Brushes.Black, new PointF(50, 40));
            e.Graphics.DrawString("Teléfono: 3121-8864", f1, Brushes.Black, new PointF(50, 65));
            e.Graphics.DrawString("Cliente: " + txtnombrecliente.Text, f1, Brushes.Black, new PointF(50, 90));
            e.Graphics.DrawImage(Image.FromFile("depo.jpg"), 635, 15, 150, 100);
            e.Graphics.DrawLine(pen, new Point(50, 125), new Point(780, 125));

            e.Graphics.DrawString("No.", f2, Brushes.Blue, new PointF(55, 135));
            e.Graphics.DrawString("Descripción", f2, Brushes.Blue, new PointF(130, 135));
            e.Graphics.DrawString("Cantidad", f2, Brushes.Blue, new PointF(420, 135));
            e.Graphics.DrawString("Precio", f2, Brushes.Blue, new PointF(540, 135));
            e.Graphics.DrawString("Subtotal", f2, Brushes.Blue, new PointF(660, 135));

            int ini = 170;
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                e.Graphics.DrawString(fila.Cells[0].Value.ToString(), f3, Brushes.Black, new PointF(55, ini));
                e.Graphics.DrawString(fila.Cells[2].Value.ToString(), f3, Brushes.Black, new PointF(130, ini));
                e.Graphics.DrawString(fila.Cells[3].Value.ToString(), f3, Brushes.Black, new PointF(420, ini));
                e.Graphics.DrawString(fila.Cells[4].Value.ToString(), f3, Brushes.Black, new PointF(540, ini));
                e.Graphics.DrawString(fila.Cells[5].Value.ToString(), f3, Brushes.Black, new PointF(660, ini));

                ini += 20;
            }

            e.Graphics.DrawString("Total: " + txttotalpedido.Text, f1, Brushes.Blue, new PointF(580, 450));
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int npedido = int.Parse(txtnpedido.Text);
            int det = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            int prod = int.Parse(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            var cant = decimal.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());
            if (MessageBox.Show(this, "Desea eliminar este detalle del pedido?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                SqlConnection myConn = new SqlConnection(Negocio.Utils.ConsultaParametro("CS"));
                myConn.Open();
                SqlCommand myCmd = new SqlCommand("sp_borrarDetallePedido", myConn);
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.Parameters.AddWithValue("IDDET", det);
                myCmd.Parameters.AddWithValue("IDPED", npedido);

                try
                {
                    myCmd.ExecuteNonQuery();
                    MessageBox.Show("Se eliminó correctamente el detalle del pedido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bs_Pedido.llenardgvdetalles(dataGridView2, int.Parse(txtnpedido.Text));
                    txttotalpedido.Text = string.Format("{0:N2}", calculartotal());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al eliminar el detalle del pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                }
                finally
                {
                    Bs_Pedido.llenardgv(dataGridView1);
                }

            }
        }
    }
}
