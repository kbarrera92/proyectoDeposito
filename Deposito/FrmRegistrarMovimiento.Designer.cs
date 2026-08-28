using System.Windows.Forms;

namespace Deposito
{
    partial class FrmRegistrarMovimiento
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Panel pnlFormulario;
        private Label lblCapTipo;
        private ComboBox cboTipo;
        private Label lblCapImporte;
        private NumericUpDown nudImporte;
        private Label lblCapDetalle;
        private TextBox txtDetalle;
        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.pnlFormulario = new Panel();
            this.lblCapTipo = new Label();
            this.cboTipo = new ComboBox();
            this.lblCapImporte = new Label();
            this.nudImporte = new NumericUpDown();
            this.lblCapDetalle = new Label();
            this.txtDetalle = new TextBox();
            this.btnGuardar = new Button();
            this.btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(16, 14);
            this.lblTitulo.Text = "Registrar movimiento";
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(15, 111, 98);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // pnlFormulario
            this.pnlFormulario.Location = new System.Drawing.Point(16, 50);
            this.pnlFormulario.Size = new System.Drawing.Size(352, 120);
            this.pnlFormulario.BorderStyle = BorderStyle.FixedSingle;
            this.pnlFormulario.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            // lblCapTipo
            this.lblCapTipo.AutoSize = true;
            this.lblCapTipo.Location = new System.Drawing.Point(14, 10);
            this.lblCapTipo.Text = "TIPO";
            this.lblCapTipo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCapTipo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);

            // cboTipo
            this.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTipo.Location = new System.Drawing.Point(14, 26);
            this.cboTipo.Width = 150;

            // lblCapImporte
            this.lblCapImporte.AutoSize = true;
            this.lblCapImporte.Location = new System.Drawing.Point(188, 10);
            this.lblCapImporte.Text = "IMPORTE";
            this.lblCapImporte.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCapImporte.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);

            // nudImporte
            this.nudImporte.Location = new System.Drawing.Point(188, 26);
            this.nudImporte.Width = 150;
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Minimum = 0.01M;
            this.nudImporte.Maximum = 99999999.99M;
            this.nudImporte.ThousandsSeparator = true;

            // lblCapDetalle
            this.lblCapDetalle.AutoSize = true;
            this.lblCapDetalle.Location = new System.Drawing.Point(14, 62);
            this.lblCapDetalle.Text = "DETALLE";
            this.lblCapDetalle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCapDetalle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);

            // txtDetalle
            this.txtDetalle.Location = new System.Drawing.Point(14, 78);
            this.txtDetalle.Width = 324;
            this.txtDetalle.MaxLength = 150;

            this.pnlFormulario.Controls.Add(this.lblCapTipo);
            this.pnlFormulario.Controls.Add(this.cboTipo);
            this.pnlFormulario.Controls.Add(this.lblCapImporte);
            this.pnlFormulario.Controls.Add(this.nudImporte);
            this.pnlFormulario.Controls.Add(this.lblCapDetalle);
            this.pnlFormulario.Controls.Add(this.txtDetalle);

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(138, 184);
            this.btnGuardar.Size = new System.Drawing.Size(110, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.FlatStyle = FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(15, 111, 98);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(258, 184);
            this.btnCancelar.Size = new System.Drawing.Size(110, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 1;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(15, 111, 98);
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(15, 111, 98);
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FrmRegistrarMovimiento
            this.AcceptButton = this.btnGuardar;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(384, 232);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Registrar movimiento";
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}