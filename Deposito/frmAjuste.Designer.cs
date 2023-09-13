namespace Deposito
{
    partial class frmAjuste
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodpro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btndescartar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 56);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ENTRADA",
            "SALIDA"});
            this.comboBox1.Location = new System.Drawing.Point(998, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(880, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de ajuste";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(310, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Concepto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(678, 523);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(492, 24);
            this.label13.TabIndex = 71;
            this.label13.Text = "Deposito Nohemi, Tierras del Pueblo, Mazatenango";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(619, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 17);
            this.label12.TabIndex = 70;
            this.label12.Text = "Detalles del pedido";
            // 
            // txtexistencia
            // 
            this.txtexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.Location = new System.Drawing.Point(14, 512);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.ReadOnly = true;
            this.txtexistencia.Size = new System.Drawing.Size(97, 35);
            this.txtexistencia.TabIndex = 69;
            this.txtexistencia.Text = "0";
            this.txtexistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 496);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 68;
            this.label10.Text = "Existencia";
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = global::Deposito.Properties.Resources.Button_Add_icon;
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnagregar.Location = new System.Drawing.Point(619, 447);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(62, 61);
            this.btnagregar.TabIndex = 67;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(362, 512);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(107, 35);
            this.txtsubtotal.TabIndex = 66;
            this.txtsubtotal.Tag = "";
            this.txtsubtotal.Text = "0.00";
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "Subtotal";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(240, 512);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(107, 35);
            this.txtcantidad.TabIndex = 64;
            this.txtcantidad.Tag = "";
            this.txtcantidad.Text = "0";
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Cantidad";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(118, 512);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(107, 35);
            this.txtprecio.TabIndex = 62;
            this.txtprecio.Tag = "";
            this.txtprecio.Text = "0.00";
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Precio";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(117, 465);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.ReadOnly = true;
            this.txtdesc.Size = new System.Drawing.Size(352, 23);
            this.txtdesc.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Descripcion";
            // 
            // txtcodpro
            // 
            this.txtcodpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodpro.Location = new System.Drawing.Point(14, 465);
            this.txtcodpro.Name = "txtcodpro";
            this.txtcodpro.ReadOnly = true;
            this.txtcodpro.Size = new System.Drawing.Size(97, 23);
            this.txtcodpro.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Id. Producto";
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = global::Deposito.Properties.Resources.delete_icon;
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(839, 446);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(62, 61);
            this.btnsalir.TabIndex = 56;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btndescartar
            // 
            this.btndescartar.BackgroundImage = global::Deposito.Properties.Resources.trash_icon;
            this.btndescartar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndescartar.Location = new System.Drawing.Point(687, 447);
            this.btndescartar.Name = "btndescartar";
            this.btndescartar.Size = new System.Drawing.Size(62, 61);
            this.btndescartar.TabIndex = 55;
            this.btndescartar.UseVisualStyleBackColor = true;
            this.btndescartar.Click += new System.EventHandler(this.btndescartar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = global::Deposito.Properties.Resources.Save_as_icon;
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistrar.Location = new System.Drawing.Point(771, 447);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(62, 61);
            this.btnregistrar.TabIndex = 54;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.Blue;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.Yellow;
            this.txttotal.Location = new System.Drawing.Point(912, 436);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(260, 68);
            this.txttotal.TabIndex = 53;
            this.txttotal.Text = "0.00";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod,
            this.produc,
            this.cant,
            this.precio,
            this.subt});
            this.dataGridView2.Location = new System.Drawing.Point(619, 89);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(551, 347);
            this.dataGridView2.TabIndex = 52;
            // 
            // prod
            // 
            this.prod.HeaderText = "Codigo";
            this.prod.Name = "prod";
            this.prod.ReadOnly = true;
            this.prod.Width = 80;
            // 
            // produc
            // 
            this.produc.HeaderText = "Producto";
            this.produc.Name = "produc";
            this.produc.ReadOnly = true;
            this.produc.Width = 188;
            // 
            // cant
            // 
            this.cant.HeaderText = "Cantidad";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            this.cant.Width = 80;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
            // 
            // subt
            // 
            this.subt.HeaderText = "Subtotal";
            this.subt.Name = "subt";
            this.subt.ReadOnly = true;
            this.subt.Width = 80;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(144, 64);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(452, 23);
            this.txtbuscar.TabIndex = 51;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "Buscar producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 93);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(581, 348);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 554);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcodpro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btndescartar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAjuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste de Existencia de Productos";
            this.Load += new System.EventHandler(this.frmAjuste_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodpro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btndescartar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn produc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subt;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}