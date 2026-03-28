using Negocio;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmAjuste : Form
    {
        public frmAjuste()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodpro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtprecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtexistencia.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtcantidad.Select();
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtcantidad.Text.Equals(""))
                {
                    MessageBox.Show("Cantidad inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!decimal.TryParse(txtcantidad.Text, out decimal decvalue))
                {
                    MessageBox.Show("Cantidad inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (decimal.Parse(txtcantidad.Text) == 0)
                {
                    MessageBox.Show("Cantidad inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtsubtotal.Text = string.Format("{0}", double.Parse(txtprecio.Text) * double.Parse(txtcantidad.Text));
                    btnagregar.PerformClick();
                }

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (!txtprecio.Text.Trim().Equals(""))
            {

                dataGridView2.Rows.Add(txtcodpro.Text, txtdesc.Text, txtcantidad.Text, txtprecio.Text, txtsubtotal.Text);
                txttotal.Text = calculartotal().ToString();
                limpiardatos();
            }
            else
            {
                MessageBox.Show(this, "No ha ingresado cantidad", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private double calculartotal()
        {
            double total = 0.00d;

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                total += double.Parse(fila.Cells[4].Value.ToString());
            }

            return total;
        }

        private void limpiardatos()
        {
            txtcodpro.Clear();
            txtdesc.Clear();
            txtexistencia.Text = "0";
            txtprecio.Text = "0.00";
            txtcantidad.Text = "0";
            txtsubtotal.Text = "0.00";
            txtbuscar.Clear();
            txtbuscar.Select();
        }

        private void btndescartar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Debe seleccionar un detalle para eliminarlo", "Seleccione un detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show(this, "Desea eliminar este detalle?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            agregarpedido();
        }

        private void agregarpedido()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(this, "No ha seleccionado el tipo de ajuste", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show(this, "No hay ningun detalle asociado a este ajuste", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Entidad.AJUSTE ajuste = new Entidad.AJUSTE()
                    {
                        FECHA = dateTimePicker1.Value,
                        TIPOAJUSTE = comboBox1.Text,
                        TOTAL = decimal.Parse(txttotal.Text)
                    };

                    if (Bs_Ajuste.registrarajuste(ajuste))
                    {
                        agregardetallepedido();
                        dataGridView2.Rows.Clear();
                        Bs_Producto.llenardgv(dataGridView1);
                        limpiardatos();

                        frmPrincipal frmpadre = MdiParent as frmPrincipal;

                        if (frmpadre != null)
                        {
                            frmpadre.toolStripButton5.Text =
                                $"Bajo Stock: {Bs_Producto.ConsultaProductosConBajoStock():0}";
                            frmpadre.toolStripButton5.BackColor = (Bs_Producto.ConsultaProductosConBajoStock() > 0) ? Color.Salmon : Color.Transparent;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(this, "Hubo un error al registrar el ajuste", "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
        }

        private void agregardetallepedido()
        {
            try
            {
                using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
                {
                    int ultimoajuste = db.AJUSTE.Max(x => x.ID);

                    for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                    {
                        Entidad.AJUSTEDETA ajuste = new Entidad.AJUSTEDETA()
                        {
                            ID = i + 1,
                            IDAJUSTE = ultimoajuste,
                            IDCLIENTE = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()),
                            CANTIDAD = decimal.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()),
                            PRECIO = decimal.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()),
                            SUBTOTAL = decimal.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString())
                        };

                        Bs_Ajuste.registrardetallespedido(ajuste);
                    }

                    MessageBox.Show(this, "Ajuste registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttotal.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message, "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frmAjuste_Load(object sender, EventArgs e)
        {
            Bs_Producto.llenardgv(dataGridView1);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Bs_Producto.filtrardgv(dataGridView1, txtbuscar.Text.Trim());
        }

        
    }
}
