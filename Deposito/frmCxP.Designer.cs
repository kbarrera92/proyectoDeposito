namespace Deposito
{
    partial class frmCxP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscarcuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfechacompra = new System.Windows.Forms.TextBox();
            this.txtfechalimite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnocuenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiasrestantes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.Location = new System.Drawing.Point(846, 380);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(965, 245);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // txtbuscarcuenta
            // 
            this.txtbuscarcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarcuenta.Location = new System.Drawing.Point(84, 15);
            this.txtbuscarcuenta.Name = "txtbuscarcuenta";
            this.txtbuscarcuenta.Size = new System.Drawing.Size(684, 26);
            this.txtbuscarcuenta.TabIndex = 3;
            this.txtbuscarcuenta.TextChanged += new System.EventHandler(this.txtbuscarcuenta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha compra:";
            // 
            // txtfechacompra
            // 
            this.txtfechacompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechacompra.Location = new System.Drawing.Point(141, 307);
            this.txtfechacompra.Name = "txtfechacompra";
            this.txtfechacompra.Size = new System.Drawing.Size(165, 26);
            this.txtfechacompra.TabIndex = 7;
            // 
            // txtfechalimite
            // 
            this.txtfechalimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechalimite.Location = new System.Drawing.Point(512, 307);
            this.txtfechalimite.Name = "txtfechalimite";
            this.txtfechalimite.Size = new System.Drawing.Size(165, 26);
            this.txtfechalimite.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha limite:";
            // 
            // txtproveedor
            // 
            this.txtproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproveedor.Location = new System.Drawing.Point(141, 347);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(536, 26);
            this.txtproveedor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Proveedor:";
            // 
            // txtnocuenta
            // 
            this.txtnocuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnocuenta.Location = new System.Drawing.Point(812, 307);
            this.txtnocuenta.Name = "txtnocuenta";
            this.txtnocuenta.Size = new System.Drawing.Size(165, 26);
            this.txtnocuenta.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. Cuenta:";
            // 
            // txtestado
            // 
            this.txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.Location = new System.Drawing.Point(812, 344);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(165, 26);
            this.txtestado.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(736, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado:";
            // 
            // txtdiasrestantes
            // 
            this.txtdiasrestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiasrestantes.Location = new System.Drawing.Point(141, 392);
            this.txtdiasrestantes.Name = "txtdiasrestantes";
            this.txtdiasrestantes.Size = new System.Drawing.Size(103, 26);
            this.txtdiasrestantes.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dias restantes:";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(315, 389);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(142, 26);
            this.txttotal.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(260, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total:";
            // 
            // txtsaldo
            // 
            this.txtsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldo.Location = new System.Drawing.Point(536, 389);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(141, 26);
            this.txtsaldo.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(470, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Saldo:";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(709, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 52);
            this.button6.TabIndex = 22;
            this.button6.Text = "Abonar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(809, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver Abonos de Cuenta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmCxP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 435);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdiasrestantes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnocuenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfechalimite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfechacompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbuscarcuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCxP";
            this.Text = "Listado de cuentas por pagar";
            this.Load += new System.EventHandler(this.frmCxP_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtbuscarcuenta, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtfechacompra, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtfechalimite, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtproveedor, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtnocuenta, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtestado, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtdiasrestantes, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txttotal, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtsaldo, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscarcuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfechacompra;
        private System.Windows.Forms.TextBox txtfechalimite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiasrestantes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.TextBox txtnocuenta;
        public System.Windows.Forms.TextBox txtsaldo;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}