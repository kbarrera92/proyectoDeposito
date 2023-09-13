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
    public partial class frmRepartidores : frmBase
    {
        public frmRepartidores()
        {
            InitializeComponent();
        }

        private void frmRepartidores_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Repartidor.llenardgv(dataGridView1);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnregistrar.Text = "Registrar";
            limpiar();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (btnregistrar.Text.Equals("Registrar"))
            {
                if (txtnombrerepartidor.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtnombrerepartidor, "Este campo es obligatorio");
                    return;
                }
                if (txttelrepartidor.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txttelrepartidor, "Este campo es obligatorio");
                    return;
                }


                Entidad.REPARTIDOR user = new Entidad.REPARTIDOR
                {
                    NOMBRE = txtnombrerepartidor.Text.Trim(),
                    TELEFONO = txttelrepartidor.Text.Trim(),
                    ESTADO = true
                };

                try
                {
                    Negocio.Bs_Repartidor.crearRepartidor(user);
                    MessageBox.Show(this, "Repartidor registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Negocio.Bs_Repartidor.llenardgv(dataGridView1);
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: " + ex.Message, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                //Actualizar registro
                Negocio.Bs_Repartidor.actualizarRepartidor(int.Parse(txtidrepartidor.Text.Trim()), txtnombrerepartidor.Text.Trim(), txttelrepartidor.Text.Trim());
                limpiar();
                Negocio.Bs_Repartidor.llenardgv(dataGridView1);
            }
        }

        public void limpiar()
        {
            txtidrepartidor.Clear();
            txtnombrerepartidor.Clear();
            txttelrepartidor.Clear();
            txtnombrerepartidor.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            txtidrepartidor.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            txtnombrerepartidor.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            txttelrepartidor.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            
            btnregistrar.Text = "Actualizar";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtidrepartidor.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtidrepartidor, "No ha seleccionado ningun registro");
                return;
            }
            else
            {
                Negocio.Bs_Repartidor.dardebajarepartidor(int.Parse(txtidrepartidor.Text.Trim()));
                MessageBox.Show(this, "Eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                Negocio.Bs_Repartidor.llenardgv(dataGridView1);
            }
        }
    }
}
