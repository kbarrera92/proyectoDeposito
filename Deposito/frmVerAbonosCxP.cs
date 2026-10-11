using Negocio;
using System;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmVerAbonosCxP : Form
    {
        private readonly int idCuenta;

        public frmVerAbonosCxP()
        {
            InitializeComponent();
        }

        public frmVerAbonosCxP(int idCuenta, string proveedor) : this()
        {
            this.idCuenta = idCuenta;
            this.Text = "Abonos de la cuenta " + idCuenta + " - " + proveedor;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void frmVerAbonosCxP_Load(object sender, EventArgs e)
        {
            Bs_Compra.mostrarcxpabonos(dataGridView1, idCuenta);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["ID"].HeaderText = "No.";
            dataGridView1.Columns["FECHA"].HeaderText = "Fecha";
            dataGridView1.Columns["FECHA"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["IMPORTE"].HeaderText = "Importe";
            dataGridView1.Columns["IMPORTE"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["IMPORTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["NORECIBO"].HeaderText = "No. recibo";

            if (dataGridView1.Rows.Count == 0)
            {
                label1.Text = "LISTADO DE ABONOS (ESTA CUENTA NO TIENE ABONOS)";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
