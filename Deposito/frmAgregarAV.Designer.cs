namespace Deposito
{
    partial class frmAgregarAV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtab = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbliddeta = new System.Windows.Forms.Label();
            this.lblnav = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(39, 14);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(112, 26);
            this.txtid.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID:";
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(252, 12);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(342, 26);
            this.txtproducto.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Producto:";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(252, 44);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(112, 26);
            this.txtprecio.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Precio:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(505, 44);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(89, 26);
            this.txtcantidad.TabIndex = 23;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad:";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(252, 76);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(112, 26);
            this.txtsubtotal.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Subtotal:";
            // 
            // btnsalir
            // 
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(529, 104);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(88, 23);
            this.btnsalir.TabIndex = 53;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btngrabar
            // 
            this.btngrabar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btngrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrabar.Location = new System.Drawing.Point(417, 104);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(106, 23);
            this.btngrabar.TabIndex = 52;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(31, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 24);
            this.checkBox1.TabIndex = 54;
            this.checkBox1.Text = "Cliente:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 28);
            this.comboBox1.TabIndex = 55;
            this.comboBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Abono:";
            // 
            // txtab
            // 
            this.txtab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtab.Location = new System.Drawing.Point(125, 168);
            this.txtab.Name = "txtab";
            this.txtab.Size = new System.Drawing.Size(112, 26);
            this.txtab.TabIndex = 57;
            this.txtab.Text = "0.0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbliddeta
            // 
            this.lbliddeta.AutoSize = true;
            this.lbliddeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliddeta.Location = new System.Drawing.Point(6, 50);
            this.lbliddeta.Name = "lbliddeta";
            this.lbliddeta.Size = new System.Drawing.Size(28, 20);
            this.lbliddeta.TabIndex = 58;
            this.lbliddeta.Text = "ID";
            // 
            // lblnav
            // 
            this.lblnav.AutoSize = true;
            this.lblnav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnav.Location = new System.Drawing.Point(6, 79);
            this.lblnav.Name = "lblnav";
            this.lblnav.Size = new System.Drawing.Size(52, 20);
            this.lblnav.TabIndex = 59;
            this.lblnav.Text = "IDAV";
            // 
            // frmAgregarAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 200);
            this.Controls.Add(this.lblnav);
            this.Controls.Add(this.lbliddeta);
            this.Controls.Add(this.txtab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Name = "frmAgregarAV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar registro";
            this.Load += new System.EventHandler(this.frmAgregarAV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtab;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label lbliddeta;
        public System.Windows.Forms.Label lblnav;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}