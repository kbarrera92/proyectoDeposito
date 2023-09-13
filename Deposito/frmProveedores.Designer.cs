namespace Deposito
{
    partial class frmProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcontactoprov = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelefonoprov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiireccionprov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombreprov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.Location = new System.Drawing.Point(746, 309);
            this.btnSalir.TabIndex = 12;
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnnuevo.FlatAppearance.BorderSize = 2;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(335, 309);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(131, 52);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnregistrar.FlatAppearance.BorderSize = 2;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(472, 309);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(131, 52);
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btneliminar.FlatAppearance.BorderSize = 2;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(609, 310);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(131, 52);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 278);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtcontactoprov);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttelefonoprov);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtidproveedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdiireccionprov);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnombreprov);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 349);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del proveedor";
            // 
            // txtcontactoprov
            // 
            this.txtcontactoprov.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactoprov.Location = new System.Drawing.Point(19, 296);
            this.txtcontactoprov.Name = "txtcontactoprov";
            this.txtcontactoprov.Size = new System.Drawing.Size(249, 24);
            this.txtcontactoprov.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contacto:";
            // 
            // txttelefonoprov
            // 
            this.txttelefonoprov.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonoprov.Location = new System.Drawing.Point(19, 237);
            this.txttelefonoprov.Name = "txttelefonoprov";
            this.txttelefonoprov.Size = new System.Drawing.Size(249, 24);
            this.txttelefonoprov.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefono:";
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidproveedor.Location = new System.Drawing.Point(22, 43);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.ReadOnly = true;
            this.txtidproveedor.Size = new System.Drawing.Size(126, 24);
            this.txtidproveedor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id:";
            // 
            // txtdiireccionprov
            // 
            this.txtdiireccionprov.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiireccionprov.Location = new System.Drawing.Point(19, 187);
            this.txtdiireccionprov.Name = "txtdiireccionprov";
            this.txtdiireccionprov.Size = new System.Drawing.Size(249, 24);
            this.txtdiireccionprov.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion:";
            // 
            // txtnombreprov
            // 
            this.txtnombreprov.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreprov.Location = new System.Drawing.Point(19, 136);
            this.txtnombreprov.Name = "txtnombreprov";
            this.txtnombreprov.Size = new System.Drawing.Size(249, 24);
            this.txtnombreprov.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtnit
            // 
            this.txtnit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnit.Location = new System.Drawing.Point(19, 88);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(251, 24);
            this.txtnit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 375);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnregistrar, 0);
            this.Controls.SetChildIndex(this.btnnuevo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcontactoprov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelefonoprov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiireccionprov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombreprov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}