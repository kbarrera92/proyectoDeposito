using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Deposito
{
    public partial class frmVerAbonos : Form
    {
        public frmVerAbonos()
        {
            InitializeComponent();
        }

        private void frmVerAbonos_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].DataPropertyName = "NOMBRE";
            dataGridView1.Columns[2].DataPropertyName = "FECHA";
            dataGridView1.Columns[3].DataPropertyName = "IMPORTE";
            cargarAbonos(dateTimePicker1.Value);
            txttotal.Text = getTotal(3).ToString();
        }

        private decimal getTotal(int column)
        {
            decimal total = 0m;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += decimal.Parse(dataGridView1[column, i].Value.ToString());
            }

            return total;
        }
        private void cargarAbonos(DateTime fecha)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var abonos = from abono in db.ABONOASALDO
                             join client in db.CLIENTE on abono.CLIENTE equals client.ID
                             where DbFunctions.TruncateTime(abono.FECHA) == fecha.Date
                             select new
                             {
                                 abono.ID,
                                 client.NOMBRE,
                                 abono.FECHA,
                                 abono.IMPORTE
                             };

                dataGridView1.DataSource = abonos.ToList();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cargarAbonos(dateTimePicker1.Value);
            txttotal.Text = $@"{getTotal(3):N2}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filtrarAbonos(dateTimePicker1.Value, textBox1.Text);
        }

        private void filtrarAbonos(DateTime fecha, string texto)
        {
            using (DEPOSITOEntities1 db = new DEPOSITOEntities1())
            {
                var abonos = from abono in db.ABONOASALDO
                             join client in db.CLIENTE on abono.CLIENTE equals client.ID
                             where DbFunctions.TruncateTime(abono.FECHA) == fecha.Date && client.NOMBRE.Contains(texto)
                             select new
                             {
                                 abono.ID,
                                 client.NOMBRE,
                                 abono.FECHA,
                                 abono.IMPORTE
                             };

                dataGridView1.DataSource = abonos.ToList();
            }
        }
    }
}
