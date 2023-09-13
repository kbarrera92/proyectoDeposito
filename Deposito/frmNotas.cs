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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            Negocio.Bs_Notas.llenardgv(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                Entidad.NOTAS nota = new Entidad.NOTAS()
                {
                    FECHA = dateTimePicker1.Value.Date,
                    CUERPO = textBox1.Text
                };

                try
                {
                    Negocio.Bs_Notas.crearNota(nota);
                    MessageBox.Show("Registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Negocio.Bs_Notas.llenardgv(dataGridView1);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int nota = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    Negocio.Bs_Notas.borrar(nota);
                    MessageBox.Show("Eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Negocio.Bs_Notas.llenardgv(dataGridView1);
                }
                catch (Exception)
                {

                    throw;
                }
                

            }
        }
    }
}
