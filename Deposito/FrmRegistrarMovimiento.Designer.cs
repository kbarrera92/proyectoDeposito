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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblCapTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblCapImporte = new System.Windows.Forms.Label();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.lblCapDetalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.lblTitulo.Location = new System.Drawing.Point(16, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar movimiento";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.lblCapTipo);
            this.pnlFormulario.Controls.Add(this.cboTipo);
            this.pnlFormulario.Controls.Add(this.lblCapImporte);
            this.pnlFormulario.Controls.Add(this.nudImporte);
            this.pnlFormulario.Controls.Add(this.lblCapDetalle);
            this.pnlFormulario.Controls.Add(this.txtDetalle);
            this.pnlFormulario.Location = new System.Drawing.Point(16, 50);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(352, 120);
            this.pnlFormulario.TabIndex = 1;
            // 
            // lblCapTipo
            // 
            this.lblCapTipo.AutoSize = true;
            this.lblCapTipo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapTipo.Location = new System.Drawing.Point(14, 10);
            this.lblCapTipo.Name = "lblCapTipo";
            this.lblCapTipo.Size = new System.Drawing.Size(28, 12);
            this.lblCapTipo.TabIndex = 0;
            this.lblCapTipo.Text = "TIPO";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Location = new System.Drawing.Point(14, 26);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(150, 23);
            this.cboTipo.TabIndex = 1;
            // 
            // lblCapImporte
            // 
            this.lblCapImporte.AutoSize = true;
            this.lblCapImporte.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapImporte.Location = new System.Drawing.Point(188, 10);
            this.lblCapImporte.Name = "lblCapImporte";
            this.lblCapImporte.Size = new System.Drawing.Size(50, 12);
            this.lblCapImporte.TabIndex = 2;
            this.lblCapImporte.Text = "IMPORTE";
            // 
            // nudImporte
            // 
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Location = new System.Drawing.Point(188, 26);
            this.nudImporte.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nudImporte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(150, 23);
            this.nudImporte.TabIndex = 3;
            this.nudImporte.ThousandsSeparator = true;
            this.nudImporte.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lblCapDetalle
            // 
            this.lblCapDetalle.AutoSize = true;
            this.lblCapDetalle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapDetalle.Location = new System.Drawing.Point(14, 62);
            this.lblCapDetalle.Name = "lblCapDetalle";
            this.lblCapDetalle.Size = new System.Drawing.Size(44, 12);
            this.lblCapDetalle.TabIndex = 4;
            this.lblCapDetalle.Text = "DETALLE";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(14, 78);
            this.txtDetalle.MaxLength = 150;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(324, 23);
            this.txtDetalle.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(138, 184);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 30);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnCancelar.Location = new System.Drawing.Point(258, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRegistrarMovimiento
            // 
            this.AcceptButton = this.btnGuardar;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(384, 232);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrarMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar movimiento";
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

}