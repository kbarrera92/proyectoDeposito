namespace Deposito
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbareasreparto = new System.Windows.Forms.ComboBox();
            this.txtsaldocliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelefonocliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigocliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.Location = new System.Drawing.Point(745, 343);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnnuevo.FlatAppearance.BorderSize = 2;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(334, 342);
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
            this.btnregistrar.Location = new System.Drawing.Point(471, 342);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(131, 52);
            this.btnregistrar.TabIndex = 7;
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
            this.btneliminar.Location = new System.Drawing.Point(608, 343);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(131, 52);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 324);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.obtenerDatos);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmbareasreparto);
            this.groupBox1.Controls.Add(this.txtsaldocliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttelefonocliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtidcliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnombrecliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcodigocliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 382);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // cmbareasreparto
            // 
            this.cmbareasreparto.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbareasreparto.FormattingEnabled = true;
            this.cmbareasreparto.Location = new System.Drawing.Point(21, 196);
            this.cmbareasreparto.Name = "cmbareasreparto";
            this.cmbareasreparto.Size = new System.Drawing.Size(247, 23);
            this.cmbareasreparto.TabIndex = 14;
            // 
            // txtsaldocliente
            // 
            this.txtsaldocliente.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldocliente.Location = new System.Drawing.Point(21, 347);
            this.txtsaldocliente.Name = "txtsaldocliente";
            this.txtsaldocliente.Size = new System.Drawing.Size(249, 22);
            this.txtsaldocliente.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Saldo:";
            // 
            // txttelefonocliente
            // 
            this.txttelefonocliente.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonocliente.Location = new System.Drawing.Point(19, 294);
            this.txttelefonocliente.Name = "txttelefonocliente";
            this.txttelefonocliente.Size = new System.Drawing.Size(249, 22);
            this.txttelefonocliente.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(19, 245);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(251, 22);
            this.txtdireccion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Direccion:";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidcliente.Location = new System.Drawing.Point(19, 48);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.ReadOnly = true;
            this.txtidcliente.Size = new System.Drawing.Size(126, 22);
            this.txtidcliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Area de reparto";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.Location = new System.Drawing.Point(19, 146);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(249, 22);
            this.txtnombrecliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtcodigocliente
            // 
            this.txtcodigocliente.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigocliente.Location = new System.Drawing.Point(19, 97);
            this.txtcodigocliente.Name = "txtcodigocliente";
            this.txtcodigocliente.Size = new System.Drawing.Size(251, 22);
            this.txtcodigocliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Abrir cuenta envases";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCliente";
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnregistrar, 0);
            this.Controls.SetChildIndex(this.btnnuevo, 0);
            this.Controls.SetChildIndex(this.button1, 0);
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
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigocliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbareasreparto;
        private System.Windows.Forms.TextBox txtsaldocliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelefonocliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}