namespace Deposito
{
    partial class frmCompras
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblcodigoproveedor = new System.Windows.Forms.Label();
            this.txtnodocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombreprov = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnitprov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcostopro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmarcapro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpresentacionpro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdescpro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcodpro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtfiltrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvdetalles = new System.Windows.Forms.DataGridView();
            this.idpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costopro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txttotalcompra = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lblcodigoproveedor);
            this.panel1.Controls.Add(this.txtnodocumento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtnombreprov);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnitprov);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbFP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 69);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(748, 53);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver proveedores";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblcodigoproveedor
            // 
            this.lblcodigoproveedor.AutoSize = true;
            this.lblcodigoproveedor.Location = new System.Drawing.Point(915, 53);
            this.lblcodigoproveedor.Name = "lblcodigoproveedor";
            this.lblcodigoproveedor.Size = new System.Drawing.Size(41, 13);
            this.lblcodigoproveedor.TabIndex = 15;
            this.lblcodigoproveedor.Text = "label18";
            this.lblcodigoproveedor.Visible = false;
            // 
            // txtnodocumento
            // 
            this.txtnodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnodocumento.Location = new System.Drawing.Point(583, 30);
            this.txtnodocumento.Name = "txtnodocumento";
            this.txtnodocumento.Size = new System.Drawing.Size(159, 23);
            this.txtnodocumento.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "No. Factura";
            // 
            // txtnombreprov
            // 
            this.txtnombreprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreprov.Location = new System.Drawing.Point(914, 29);
            this.txtnombreprov.Name = "txtnombreprov";
            this.txtnombreprov.Size = new System.Drawing.Size(350, 23);
            this.txtnombreprov.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(911, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre proveedor";
            // 
            // txtnitprov
            // 
            this.txtnitprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnitprov.Location = new System.Drawing.Point(748, 30);
            this.txtnitprov.Name = "txtnitprov";
            this.txtnitprov.Size = new System.Drawing.Size(131, 23);
            this.txtnitprov.TabIndex = 7;
            this.txtnitprov.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnitprov_KeyDown);
            this.txtnitprov.Validating += new System.ComponentModel.CancelEventHandler(this.txtnitprov_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "NIT";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(300, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 23);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de pago";
            // 
            // cmbFP
            // 
            this.cmbFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFP.FormattingEnabled = true;
            this.cmbFP.Location = new System.Drawing.Point(141, 29);
            this.cmbFP.Name = "cmbFP";
            this.cmbFP.Size = new System.Drawing.Size(153, 24);
            this.cmbFP.TabIndex = 3;
            this.cmbFP.SelectionChangeCommitted += new System.EventHandler(this.cmbFP_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forma de pago";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtsubtotal);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtcantidad);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtcostopro);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtexistencia);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtmarcapro);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtpresentacionpro);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtdescpro);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtcodpro);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dgvProductos);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 455);
            this.panel2.TabIndex = 1;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.BackColor = System.Drawing.Color.Blue;
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.ForeColor = System.Drawing.Color.Yellow;
            this.txtsubtotal.Location = new System.Drawing.Point(426, 392);
            this.txtsubtotal.Multiline = true;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(199, 50);
            this.txtsubtotal.TabIndex = 17;
            this.txtsubtotal.Text = "0.0";
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(423, 374);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Subtotal";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.Blue;
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.Yellow;
            this.txtcantidad.Location = new System.Drawing.Point(300, 392);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(120, 50);
            this.txtcantidad.TabIndex = 15;
            this.txtcantidad.Text = "0";
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(297, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Cantidad";
            // 
            // txtcostopro
            // 
            this.txtcostopro.BackColor = System.Drawing.Color.Blue;
            this.txtcostopro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcostopro.ForeColor = System.Drawing.Color.Yellow;
            this.txtcostopro.Location = new System.Drawing.Point(142, 392);
            this.txtcostopro.Multiline = true;
            this.txtcostopro.Name = "txtcostopro";
            this.txtcostopro.Size = new System.Drawing.Size(152, 50);
            this.txtcostopro.TabIndex = 13;
            this.txtcostopro.Text = "0.0";
            this.txtcostopro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcostopro.TextChanged += new System.EventHandler(this.txtcostopro_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(139, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Costo";
            // 
            // txtexistencia
            // 
            this.txtexistencia.BackColor = System.Drawing.Color.Blue;
            this.txtexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexistencia.ForeColor = System.Drawing.Color.Yellow;
            this.txtexistencia.Location = new System.Drawing.Point(16, 392);
            this.txtexistencia.Multiline = true;
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(119, 50);
            this.txtexistencia.TabIndex = 11;
            this.txtexistencia.Text = "0";
            this.txtexistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Existencia";
            // 
            // txtmarcapro
            // 
            this.txtmarcapro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarcapro.Location = new System.Drawing.Point(326, 344);
            this.txtmarcapro.Name = "txtmarcapro";
            this.txtmarcapro.Size = new System.Drawing.Size(299, 23);
            this.txtmarcapro.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(323, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Marca";
            // 
            // txtpresentacionpro
            // 
            this.txtpresentacionpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpresentacionpro.Location = new System.Drawing.Point(15, 344);
            this.txtpresentacionpro.Name = "txtpresentacionpro";
            this.txtpresentacionpro.Size = new System.Drawing.Size(305, 23);
            this.txtpresentacionpro.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Presentacion";
            // 
            // txtdescpro
            // 
            this.txtdescpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescpro.Location = new System.Drawing.Point(122, 298);
            this.txtdescpro.Name = "txtdescpro";
            this.txtdescpro.Size = new System.Drawing.Size(503, 23);
            this.txtdescpro.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(119, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Descripcion";
            // 
            // txtcodpro
            // 
            this.txtcodpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodpro.Location = new System.Drawing.Point(16, 298);
            this.txtcodpro.Name = "txtcodpro";
            this.txtcodpro.Size = new System.Drawing.Size(100, 23);
            this.txtcodpro.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Codigo";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(16, 49);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(609, 215);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtfiltrar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 48);
            this.panel3.TabIndex = 0;
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltrar.Location = new System.Drawing.Point(86, 12);
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(537, 26);
            this.txtfiltrar.TabIndex = 1;
            this.txtfiltrar.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Buscar:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(640, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(639, 48);
            this.panel4.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(212, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "Detalles de la compra";
            // 
            // dgvdetalles
            // 
            this.dgvdetalles.AllowUserToAddRows = false;
            this.dgvdetalles.AllowUserToDeleteRows = false;
            this.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpro,
            this.descpro,
            this.costopro,
            this.cantpro,
            this.subtpro});
            this.dgvdetalles.Location = new System.Drawing.Point(655, 118);
            this.dgvdetalles.Name = "dgvdetalles";
            this.dgvdetalles.ReadOnly = true;
            this.dgvdetalles.Size = new System.Drawing.Size(609, 272);
            this.dgvdetalles.TabIndex = 3;
            // 
            // idpro
            // 
            this.idpro.HeaderText = "Codigo";
            this.idpro.Name = "idpro";
            this.idpro.ReadOnly = true;
            this.idpro.Width = 80;
            // 
            // descpro
            // 
            this.descpro.HeaderText = "Descripcion";
            this.descpro.Name = "descpro";
            this.descpro.ReadOnly = true;
            this.descpro.Width = 250;
            // 
            // costopro
            // 
            this.costopro.HeaderText = "Costo";
            this.costopro.Name = "costopro";
            this.costopro.ReadOnly = true;
            this.costopro.Width = 80;
            // 
            // cantpro
            // 
            this.cantpro.HeaderText = "Cantidad";
            this.cantpro.Name = "cantpro";
            this.cantpro.ReadOnly = true;
            this.cantpro.Width = 80;
            // 
            // subtpro
            // 
            this.subtpro.HeaderText = "Importe";
            this.subtpro.Name = "subtpro";
            this.subtpro.ReadOnly = true;
            this.subtpro.Width = 80;
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnnuevo.FlatAppearance.BorderSize = 2;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(659, 458);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(119, 53);
            this.btnnuevo.TabIndex = 4;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnregistrar.FlatAppearance.BorderSize = 2;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(781, 458);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(119, 53);
            this.btnregistrar.TabIndex = 5;
            this.btnregistrar.Text = "Agregar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btneliminar.FlatAppearance.BorderSize = 2;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(903, 458);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(119, 53);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnsalir.FlatAppearance.BorderSize = 2;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(1145, 458);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(119, 53);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1024, 458);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 53);
            this.button6.TabIndex = 8;
            this.button6.Text = "Registrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txttotalcompra
            // 
            this.txttotalcompra.BackColor = System.Drawing.Color.Blue;
            this.txttotalcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcompra.ForeColor = System.Drawing.Color.Yellow;
            this.txttotalcompra.Location = new System.Drawing.Point(1065, 390);
            this.txttotalcompra.Multiline = true;
            this.txttotalcompra.Name = "txttotalcompra";
            this.txttotalcompra.Size = new System.Drawing.Size(199, 50);
            this.txttotalcompra.TabIndex = 18;
            this.txttotalcompra.Text = "0.0";
            this.txttotalcompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(970, 403);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 31);
            this.label17.TabIndex = 19;
            this.label17.Text = "Total:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "NORMAL",
            "ESPECIAL"});
            this.cmbTipo.Location = new System.Drawing.Point(426, 29);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(115, 24);
            this.cmbTipo.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(423, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "Tipo Compra";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 524);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txttotalcompra);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dgvdetalles);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Mercaderias al Almacen";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnombreprov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnitprov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnodocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcostopro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmarcapro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpresentacionpro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdescpro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcodpro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtfiltrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvdetalles;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txttotalcompra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn costopro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtpro;
        private System.Windows.Forms.Label lblcodigoproveedor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label18;
    }
}