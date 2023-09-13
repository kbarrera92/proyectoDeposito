namespace Deposito
{
    partial class frmcuadreAutoventa
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtnautoventa = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcodpro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtabono = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txttotalsalida = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txttotalreal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 379);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(12, 55);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(234, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 220);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(252, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(456, 182);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpro,
            this.desc,
            this.cant,
            this.precio,
            this.subt,
            this.cliente,
            this.abono});
            this.dataGridView3.Location = new System.Drawing.Point(714, 272);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(456, 182);
            this.dataGridView3.TabIndex = 5;
            // 
            // idpro
            // 
            this.idpro.HeaderText = "Código";
            this.idpro.Name = "idpro";
            this.idpro.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripción";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // cant
            // 
            this.cant.HeaderText = "Cantidad";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // subt
            // 
            this.subt.HeaderText = "Subtotal";
            this.subt.Name = "subt";
            this.subt.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // abono
            // 
            this.abono.HeaderText = "Abono";
            this.abono.Name = "abono";
            this.abono.ReadOnly = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(714, 81);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(456, 166);
            this.dataGridView4.TabIndex = 4;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            this.dataGridView4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView4_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtnautoventa
            // 
            this.txtnautoventa.Location = new System.Drawing.Point(9, 528);
            this.txtnautoventa.Name = "txtnautoventa";
            this.txtnautoventa.Size = new System.Drawing.Size(148, 20);
            this.txtnautoventa.TabIndex = 7;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(976, 8);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 48);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1081, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 48);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(163, 528);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(160, 20);
            this.txtfecha.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numero Autoventa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Área de reparto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(329, 528);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(129, 20);
            this.txtcliente.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Listado de autoventas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Productos cargados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(714, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Venta real";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(714, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(714, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Buscar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(489, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Código";
            // 
            // txtcodpro
            // 
            this.txtcodpro.Location = new System.Drawing.Point(492, 528);
            this.txtcodpro.Name = "txtcodpro";
            this.txtcodpro.Size = new System.Drawing.Size(81, 20);
            this.txtcodpro.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(861, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(864, 528);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(98, 20);
            this.txtcantidad.TabIndex = 23;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(757, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Precio";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(760, 527);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(98, 20);
            this.txtprecio.TabIndex = 25;
            this.txtprecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprecio_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(965, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Subtotal";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(968, 528);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(98, 20);
            this.txtsubtotal.TabIndex = 27;
            this.txtsubtotal.TextChanged += new System.EventHandler(this.txtsubtotal_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1069, 510);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Abono";
            // 
            // txtabono
            // 
            this.txtabono.Location = new System.Drawing.Point(1072, 528);
            this.txtabono.Name = "txtabono";
            this.txtabono.Size = new System.Drawing.Size(98, 20);
            this.txtabono.TabIndex = 29;
            this.txtabono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtabono_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(576, 509);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Producto";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(579, 528);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(175, 20);
            this.txtdesc.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(534, 457);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Total";
            // 
            // txttotalsalida
            // 
            this.txttotalsalida.Location = new System.Drawing.Point(579, 456);
            this.txttotalsalida.Name = "txttotalsalida";
            this.txttotalsalida.Size = new System.Drawing.Size(129, 20);
            this.txttotalsalida.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(986, 455);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 15);
            this.label16.TabIndex = 36;
            this.label16.Text = "Total";
            // 
            // txttotalreal
            // 
            this.txttotalreal.Location = new System.Drawing.Point(1031, 455);
            this.txttotalreal.Name = "txttotalreal";
            this.txttotalreal.Size = new System.Drawing.Size(139, 20);
            this.txttotalreal.TabIndex = 35;
            // 
            // frmcuadreAutoventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 551);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txttotalreal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txttotalsalida);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtabono);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcodpro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtnautoventa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.listBox1);
            this.Name = "frmcuadreAutoventa";
            this.Text = "Cuadre de Autoventa";
            this.Load += new System.EventHandler(this.frmcuadreAutoventa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtnautoventa;
        private System.Windows.Forms.Button btnagregar;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcodpro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtabono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttotalsalida;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txttotalreal;
    }
}