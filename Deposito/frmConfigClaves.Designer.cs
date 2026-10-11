namespace Deposito
{
    partial class frmConfigClaves
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblcapadmins = new System.Windows.Forms.Label();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClave1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClave2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.lbledicion = new System.Windows.Forms.Label();
            this.lblayuda = new System.Windows.Forms.Label();
            this.lblcapclave1 = new System.Windows.Forms.Label();
            this.txtclave1 = new System.Windows.Forms.TextBox();
            this.txtconfirmar1 = new System.Windows.Forms.TextBox();
            this.lblcapclave2 = new System.Windows.Forms.Label();
            this.txtclave2 = new System.Windows.Forms.TextBox();
            this.txtconfirmar2 = new System.Windows.Forms.TextBox();
            this.chkmostrar = new System.Windows.Forms.CheckBox();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnGuardarClaves = new System.Windows.Forms.Button();
            this.lblcappantallas = new System.Windows.Forms.Label();
            this.dgvPantallas = new System.Windows.Forms.DataGridView();
            this.colPantalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoClave = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblaviso = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardarAsignacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.pnlEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPantallas)).BeginInit();
            this.SuspendLayout();
            //
            // lblcapadmins
            //
            this.lblcapadmins.AutoSize = true;
            this.lblcapadmins.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapadmins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapadmins.Location = new System.Drawing.Point(20, 16);
            this.lblcapadmins.Name = "lblcapadmins";
            this.lblcapadmins.Size = new System.Drawing.Size(98, 12);
            this.lblcapadmins.TabIndex = 0;
            this.lblcapadmins.Text = "ADMINISTRADORES";
            //
            // dgvAdmins
            //
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.AllowUserToResizeRows = false;
            this.dgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colUsuario,
            this.colClave1,
            this.colClave2});
            this.dgvAdmins.Location = new System.Drawing.Point(20, 32);
            this.dgvAdmins.MultiSelect = false;
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersVisible = false;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmins.Size = new System.Drawing.Size(390, 316);
            this.dgvAdmins.TabIndex = 1;
            this.dgvAdmins.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAdmins_CellFormatting);
            this.dgvAdmins.SelectionChanged += new System.EventHandler(this.dgvAdmins_SelectionChanged);
            //
            // colNombre
            //
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.FillWeight = 120F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            //
            // colUsuario
            //
            this.colUsuario.DataPropertyName = "Usuario";
            this.colUsuario.FillWeight = 80F;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            //
            // colClave1
            //
            this.colClave1.DataPropertyName = "TieneClave1";
            this.colClave1.FillWeight = 85F;
            this.colClave1.HeaderText = "Clave 1";
            this.colClave1.Name = "colClave1";
            this.colClave1.ReadOnly = true;
            //
            // colClave2
            //
            this.colClave2.DataPropertyName = "TieneClave2";
            this.colClave2.FillWeight = 85F;
            this.colClave2.HeaderText = "Clave 2";
            this.colClave2.Name = "colClave2";
            this.colClave2.ReadOnly = true;
            //
            // pnlEdicion
            //
            this.pnlEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdicion.Controls.Add(this.btnGuardarClaves);
            this.pnlEdicion.Controls.Add(this.lblmensaje);
            this.pnlEdicion.Controls.Add(this.chkmostrar);
            this.pnlEdicion.Controls.Add(this.txtconfirmar2);
            this.pnlEdicion.Controls.Add(this.txtclave2);
            this.pnlEdicion.Controls.Add(this.lblcapclave2);
            this.pnlEdicion.Controls.Add(this.txtconfirmar1);
            this.pnlEdicion.Controls.Add(this.txtclave1);
            this.pnlEdicion.Controls.Add(this.lblcapclave1);
            this.pnlEdicion.Controls.Add(this.lblayuda);
            this.pnlEdicion.Controls.Add(this.lbledicion);
            this.pnlEdicion.Location = new System.Drawing.Point(430, 32);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(330, 316);
            this.pnlEdicion.TabIndex = 2;
            //
            // lbledicion
            //
            this.lbledicion.AutoEllipsis = true;
            this.lbledicion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbledicion.Location = new System.Drawing.Point(14, 12);
            this.lbledicion.Name = "lbledicion";
            this.lbledicion.Size = new System.Drawing.Size(300, 24);
            this.lbledicion.TabIndex = 0;
            this.lbledicion.Text = "Seleccione un administrador";
            //
            // lblayuda
            //
            this.lblayuda.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblayuda.Location = new System.Drawing.Point(14, 38);
            this.lblayuda.Name = "lblayuda";
            this.lblayuda.Size = new System.Drawing.Size(300, 32);
            this.lblayuda.TabIndex = 1;
            this.lblayuda.Text = "Escriba la nueva clave y confírmela. Deje los campos vacíos para conservar la clave actual.";
            //
            // lblcapclave1
            //
            this.lblcapclave1.AutoSize = true;
            this.lblcapclave1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapclave1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapclave1.Location = new System.Drawing.Point(14, 82);
            this.lblcapclave1.Name = "lblcapclave1";
            this.lblcapclave1.Size = new System.Drawing.Size(170, 12);
            this.lblcapclave1.TabIndex = 2;
            this.lblcapclave1.Text = "CLAVE 1  (NUEVA  /  CONFIRMAR)";
            //
            // txtclave1
            //
            this.txtclave1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclave1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave1.Location = new System.Drawing.Point(14, 98);
            this.txtclave1.Name = "txtclave1";
            this.txtclave1.Size = new System.Drawing.Size(145, 25);
            this.txtclave1.TabIndex = 0;
            this.txtclave1.UseSystemPasswordChar = true;
            this.txtclave1.TextChanged += new System.EventHandler(this.campoClave_TextChanged);
            //
            // txtconfirmar1
            //
            this.txtconfirmar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconfirmar1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmar1.Location = new System.Drawing.Point(169, 98);
            this.txtconfirmar1.Name = "txtconfirmar1";
            this.txtconfirmar1.Size = new System.Drawing.Size(145, 25);
            this.txtconfirmar1.TabIndex = 1;
            this.txtconfirmar1.UseSystemPasswordChar = true;
            this.txtconfirmar1.TextChanged += new System.EventHandler(this.campoClave_TextChanged);
            //
            // lblcapclave2
            //
            this.lblcapclave2.AutoSize = true;
            this.lblcapclave2.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapclave2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapclave2.Location = new System.Drawing.Point(14, 140);
            this.lblcapclave2.Name = "lblcapclave2";
            this.lblcapclave2.Size = new System.Drawing.Size(170, 12);
            this.lblcapclave2.TabIndex = 5;
            this.lblcapclave2.Text = "CLAVE 2  (NUEVA  /  CONFIRMAR)";
            //
            // txtclave2
            //
            this.txtclave2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclave2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave2.Location = new System.Drawing.Point(14, 156);
            this.txtclave2.Name = "txtclave2";
            this.txtclave2.Size = new System.Drawing.Size(145, 25);
            this.txtclave2.TabIndex = 2;
            this.txtclave2.UseSystemPasswordChar = true;
            this.txtclave2.TextChanged += new System.EventHandler(this.campoClave_TextChanged);
            //
            // txtconfirmar2
            //
            this.txtconfirmar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconfirmar2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmar2.Location = new System.Drawing.Point(169, 156);
            this.txtconfirmar2.Name = "txtconfirmar2";
            this.txtconfirmar2.Size = new System.Drawing.Size(145, 25);
            this.txtconfirmar2.TabIndex = 3;
            this.txtconfirmar2.UseSystemPasswordChar = true;
            this.txtconfirmar2.TextChanged += new System.EventHandler(this.campoClave_TextChanged);
            //
            // chkmostrar
            //
            this.chkmostrar.AutoSize = true;
            this.chkmostrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.chkmostrar.Location = new System.Drawing.Point(14, 194);
            this.chkmostrar.Name = "chkmostrar";
            this.chkmostrar.Size = new System.Drawing.Size(125, 19);
            this.chkmostrar.TabIndex = 4;
            this.chkmostrar.TabStop = false;
            this.chkmostrar.Text = "Mostrar contraseñas";
            this.chkmostrar.UseVisualStyleBackColor = true;
            this.chkmostrar.CheckedChanged += new System.EventHandler(this.chkmostrar_CheckedChanged);
            //
            // lblmensaje
            //
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(14, 222);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(300, 36);
            this.lblmensaje.TabIndex = 8;
            this.lblmensaje.Visible = false;
            //
            // btnGuardarClaves
            //
            this.btnGuardarClaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnGuardarClaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarClaves.FlatAppearance.BorderSize = 0;
            this.btnGuardarClaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarClaves.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarClaves.ForeColor = System.Drawing.Color.White;
            this.btnGuardarClaves.Location = new System.Drawing.Point(14, 262);
            this.btnGuardarClaves.Name = "btnGuardarClaves";
            this.btnGuardarClaves.Size = new System.Drawing.Size(300, 38);
            this.btnGuardarClaves.TabIndex = 5;
            this.btnGuardarClaves.Text = "Guardar claves";
            this.btnGuardarClaves.UseVisualStyleBackColor = false;
            this.btnGuardarClaves.Click += new System.EventHandler(this.btnGuardarClaves_Click);
            //
            // lblcappantallas
            //
            this.lblcappantallas.AutoSize = true;
            this.lblcappantallas.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcappantallas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcappantallas.Location = new System.Drawing.Point(20, 366);
            this.lblcappantallas.Name = "lblcappantallas";
            this.lblcappantallas.Size = new System.Drawing.Size(188, 12);
            this.lblcappantallas.TabIndex = 3;
            this.lblcappantallas.Text = "CLAVE QUE SOLICITA CADA PANTALLA";
            //
            // dgvPantallas
            //
            this.dgvPantallas.AllowUserToAddRows = false;
            this.dgvPantallas.AllowUserToDeleteRows = false;
            this.dgvPantallas.AllowUserToResizeRows = false;
            this.dgvPantallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPantalla,
            this.colDescripcion,
            this.colTipoClave});
            this.dgvPantallas.Location = new System.Drawing.Point(20, 382);
            this.dgvPantallas.MultiSelect = false;
            this.dgvPantallas.Name = "dgvPantallas";
            this.dgvPantallas.RowHeadersVisible = false;
            this.dgvPantallas.Size = new System.Drawing.Size(740, 150);
            this.dgvPantallas.TabIndex = 4;
            this.dgvPantallas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPantallas_CurrentCellDirtyStateChanged);
            this.dgvPantallas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPantallas_CellValueChanged);
            //
            // colPantalla
            //
            this.colPantalla.HeaderText = "Código";
            this.colPantalla.Name = "colPantalla";
            this.colPantalla.ReadOnly = true;
            this.colPantalla.Visible = false;
            //
            // colDescripcion
            //
            this.colDescripcion.FillWeight = 160F;
            this.colDescripcion.HeaderText = "Pantalla";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            //
            // colTipoClave
            //
            this.colTipoClave.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colTipoClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTipoClave.HeaderText = "Clave que solicita";
            this.colTipoClave.Name = "colTipoClave";
            //
            // lblaviso
            //
            this.lblaviso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblaviso.Location = new System.Drawing.Point(20, 540);
            this.lblaviso.Name = "lblaviso";
            this.lblaviso.Size = new System.Drawing.Size(740, 36);
            this.lblaviso.TabIndex = 5;
            this.lblaviso.Visible = false;
            //
            // btnCerrar
            //
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnCerrar.FlatAppearance.BorderSize = 1;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnCerrar.Location = new System.Drawing.Point(480, 580);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 38);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // btnGuardarAsignacion
            //
            this.btnGuardarAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnGuardarAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAsignacion.FlatAppearance.BorderSize = 0;
            this.btnGuardarAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAsignacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsignacion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAsignacion.Location = new System.Drawing.Point(590, 580);
            this.btnGuardarAsignacion.Name = "btnGuardarAsignacion";
            this.btnGuardarAsignacion.Size = new System.Drawing.Size(170, 38);
            this.btnGuardarAsignacion.TabIndex = 6;
            this.btnGuardarAsignacion.Text = "Guardar asignación";
            this.btnGuardarAsignacion.UseVisualStyleBackColor = false;
            this.btnGuardarAsignacion.Click += new System.EventHandler(this.btnGuardarAsignacion_Click);
            //
            // frmConfigClaves
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(780, 636);
            this.Controls.Add(this.btnGuardarAsignacion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblaviso);
            this.Controls.Add(this.dgvPantallas);
            this.Controls.Add(this.lblcappantallas);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(this.dgvAdmins);
            this.Controls.Add(this.lblcapadmins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConfigClaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración de contraseñas";
            this.Load += new System.EventHandler(this.frmConfigClaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPantallas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcapadmins;
        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClave1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClave2;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Label lbledicion;
        private System.Windows.Forms.Label lblayuda;
        private System.Windows.Forms.Label lblcapclave1;
        private System.Windows.Forms.TextBox txtclave1;
        private System.Windows.Forms.TextBox txtconfirmar1;
        private System.Windows.Forms.Label lblcapclave2;
        private System.Windows.Forms.TextBox txtclave2;
        private System.Windows.Forms.TextBox txtconfirmar2;
        private System.Windows.Forms.CheckBox chkmostrar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnGuardarClaves;
        private System.Windows.Forms.Label lblcappantallas;
        private System.Windows.Forms.DataGridView dgvPantallas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPantalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTipoClave;
        private System.Windows.Forms.Label lblaviso;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardarAsignacion;
    }
}
