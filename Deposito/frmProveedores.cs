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
    public partial class frmProveedores : frmBase
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Proveedor.llenardgv(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            txtidproveedor.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            txtnit.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            txtnombreprov.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            txtdiireccionprov.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            txttelefonoprov.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            txtcontactoprov.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
            btnregistrar.Text = "Actualizar";
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (btnregistrar.Text.Equals("Registrar"))
            {
                if (txtnit.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtnit, "Este campo es obligatorio");
                    return;
                }
                if (txtnombreprov.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtnombreprov, "Este campo es obligatorio");
                    return;
                }
                if (txtdiireccionprov.Text.Trim().Equals(""))
                {
                    errorProvider1.SetError(txtdiireccionprov, "Este campo es obligatorio");
                    return;
                }

                Entidad.PROVEEDOR user = new Entidad.PROVEEDOR
                {
                    NIT = txtnit.Text.Trim(),
                    NOMBRE = txtnombreprov.Text.Trim(),
                    DIRECCION = txtdiireccionprov.Text.Trim(),
                    TELEFONO = txttelefonoprov.Text.Trim(),
                    CONTACTO = txtcontactoprov.Text.Trim(),
                    ESTADO = true
                };

                try
                {
                    Negocio.Bs_Proveedor.crearProveedor(user);
                    MessageBox.Show(this, "Usuario creado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    Negocio.Bs_Proveedor.llenardgv(dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: " + ex.Message, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                //Actualizar registro
                Negocio.Bs_Proveedor.actualizarProveedor(int.Parse(txtidproveedor.Text.Trim()), txtnit.Text.Trim(), txtnombreprov.Text.Trim(), txtdiireccionprov.Text.Trim(), txttelefonoprov.Text.Trim(), txtcontactoprov.Text.Trim());
                limpiar();
                Negocio.Bs_Proveedor.llenardgv(dataGridView1);
            }
        }

        public void limpiar()
        {
            txtidproveedor.Clear();
            txtnombreprov.Clear();
            txtnit.Clear();
            txtdiireccionprov.Clear();
            txttelefonoprov.Clear();
            txtcontactoprov.Clear();
            txtnit.Focus();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Negocio.Bs_Proveedor.dardebajaproveedor(int.Parse(txtidproveedor.Text.Trim()));
            limpiar();
        }
    }
}
