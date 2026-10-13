namespace Deposito
{
    partial class frmSolicitarClave
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
            this.lblicono = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.lblcapclave = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.chkmostrar = new System.Windows.Forms.CheckBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblicono
            //
            this.lblicono.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblicono.Location = new System.Drawing.Point(20, 16);
            this.lblicono.Name = "lblicono";
            this.lblicono.Size = new System.Drawing.Size(52, 48);
            this.lblicono.TabIndex = 0;
            this.lblicono.Text = "🔒";
            this.lblicono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lbltitulo
            //
            this.lbltitulo.AutoEllipsis = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbltitulo.Location = new System.Drawing.Point(78, 16);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(302, 26);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Acceso restringido";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblsubtitulo
            //
            this.lblsubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblsubtitulo.Location = new System.Drawing.Point(78, 42);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(302, 22);
            this.lblsubtitulo.TabIndex = 2;
            this.lblsubtitulo.Text = "Ingrese su contraseña";
            this.lblsubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblcapclave
            //
            this.lblcapclave.AutoSize = true;
            this.lblcapclave.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapclave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapclave.Location = new System.Drawing.Point(20, 84);
            this.lblcapclave.Name = "lblcapclave";
            this.lblcapclave.Size = new System.Drawing.Size(70, 12);
            this.lblcapclave.TabIndex = 3;
            this.lblcapclave.Text = "CONTRASEÑA";
            //
            // txtclave
            //
            this.txtclave.BackColor = System.Drawing.Color.White;
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtclave.Location = new System.Drawing.Point(20, 100);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(360, 32);
            this.txtclave.TabIndex = 0;
            this.txtclave.UseSystemPasswordChar = true;
            this.txtclave.TextChanged += new System.EventHandler(this.txtclave_TextChanged);
            //
            // chkmostrar
            //
            this.chkmostrar.AutoSize = true;
            this.chkmostrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.chkmostrar.Location = new System.Drawing.Point(20, 140);
            this.chkmostrar.Name = "chkmostrar";
            this.chkmostrar.Size = new System.Drawing.Size(120, 19);
            this.chkmostrar.TabIndex = 1;
            this.chkmostrar.TabStop = false;
            this.chkmostrar.Text = "Mostrar contraseña";
            this.chkmostrar.UseVisualStyleBackColor = true;
            this.chkmostrar.CheckedChanged += new System.EventHandler(this.chkmostrar_CheckedChanged);
            //
            // lblerror
            //
            this.lblerror.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblerror.Location = new System.Drawing.Point(20, 166);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(360, 20);
            this.lblerror.TabIndex = 4;
            this.lblerror.Visible = false;
            //
            // btnIngresar
            //
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(160, 196);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(120, 38);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnCancelar.FlatAppearance.BorderSize = 1;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnCancelar.Location = new System.Drawing.Point(290, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            //
            // frmSolicitarClave
            //
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(400, 254);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.chkmostrar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.lblcapclave);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblicono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSolicitarClave";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Validando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblicono;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Label lblcapclave;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.CheckBox chkmostrar;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
