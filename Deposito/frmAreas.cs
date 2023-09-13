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
    public partial class frmAreas : frmBase
    {
        public frmAreas()
        {
            InitializeComponent();
        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Area.llenardgv(dataGridView1);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnregistrar.Text = "Registrar";
            txtiduser.Clear();
            txtcodigoarea.Clear();
            txtnombrearea.Clear();
            txtcodigoarea.Focus();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (btnregistrar.Text.Equals("Registrar"))
            {
                if (txtcodigoarea.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtcodigoarea, "Este campo es obligatorio");
                    return;
                }
                if (txtnombrearea.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtnombrearea, "Este campo es obligatorio");
                    return;
                }
                

                Entidad.AREAREPARTO user = new Entidad.AREAREPARTO
                {
                    CODIGO = txtcodigoarea.Text,
                    NOMBRE = txtnombrearea.Text,
                    ESTADO = true
                };

                try
                {
                    Negocio.Bs_Area.crearArea(user);
                    MessageBox.Show(this, "Area registrada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Negocio.Bs_Area.llenardgv(dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: " + ex.Message, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                //Actualizar registro
                Negocio.Bs_Area.actualizarUsuario(int.Parse(txtiduser.Text.Trim()), txtcodigoarea.Text.Trim(), txtnombrearea.Text.Trim());
                Negocio.Bs_Area.llenardgv(dataGridView1);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtiduser.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtiduser, "No ha seleccionado ningun registro");
                return;
            }
            else
            {
                Negocio.Bs_Area.dardebajausuario(int.Parse(txtiduser.Text.Trim()));
                MessageBox.Show(this, "Eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Negocio.Bs_Area.llenardgv(dataGridView1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            txtiduser.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            txtcodigoarea.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            txtnombrearea.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            btnregistrar.Text = "Actualizar";
        }
    }
}
