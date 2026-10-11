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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlbusqueda = new System.Windows.Forms.Panel();
            this.chkpagadas = new System.Windows.Forms.CheckBox();
            this.txtbuscarcuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlpendientes = new System.Windows.Forms.Panel();
            this.lblpendientes = new System.Windows.Forms.Label();
            this.lblcappendientes = new System.Windows.Forms.Label();
            this.pnlsaldopendiente = new System.Windows.Forms.Panel();
            this.lblsaldopendiente = new System.Windows.Forms.Label();
            this.lblcapsaldopendiente = new System.Windows.Forms.Label();
            this.pnlvencido = new System.Windows.Forms.Panel();
            this.lblvencido = new System.Windows.Forms.Label();
            this.lblcapvencido = new System.Windows.Forms.Label();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.lblcapnocuenta = new System.Windows.Forms.Label();
            this.txtnocuenta = new System.Windows.Forms.TextBox();
            this.lblcapproveedor = new System.Windows.Forms.Label();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.lblcapfechacompra = new System.Windows.Forms.Label();
            this.txtfechacompra = new System.Windows.Forms.TextBox();
            this.lblcapfechalimite = new System.Windows.Forms.Label();
            this.txtfechalimite = new System.Windows.Forms.TextBox();
            this.lblcapestado = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.lblcapdiasrestantes = new System.Windows.Forms.Label();
            this.txtdiasrestantes = new System.Windows.Forms.TextBox();
            this.lblcaptotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lblcapsaldo = new System.Windows.Forms.Label();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.btnVerAbonos = new System.Windows.Forms.Button();
            this.pnlbusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlpendientes.SuspendLayout();
            this.pnlsaldopendiente.SuspendLayout();
            this.pnlvencido.SuspendLayout();
            this.SuspendLayout();
            //
            // btnSalir
            //
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnSalir.FlatAppearance.BorderSize = 1;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnSalir.Image = null;
            this.btnSalir.Location = new System.Drawing.Point(881, 496);
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            //
            // pnlbusqueda
            //
            this.pnlbusqueda.Controls.Add(this.chkpagadas);
            this.pnlbusqueda.Controls.Add(this.txtbuscarcuenta);
            this.pnlbusqueda.Controls.Add(this.label1);
            this.pnlbusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbusqueda.Location = new System.Drawing.Point(0, 0);
            this.pnlbusqueda.Name = "pnlbusqueda";
            this.pnlbusqueda.Size = new System.Drawing.Size(993, 52);
            this.pnlbusqueda.TabIndex = 0;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            //
            // txtbuscarcuenta
            //
            this.txtbuscarcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscarcuenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarcuenta.Location = new System.Drawing.Point(62, 15);
            this.txtbuscarcuenta.Name = "txtbuscarcuenta";
            this.txtbuscarcuenta.Size = new System.Drawing.Size(300, 23);
            this.txtbuscarcuenta.TabIndex = 1;
            this.txtbuscarcuenta.TextChanged += new System.EventHandler(this.txtbuscarcuenta_TextChanged);
            //
            // chkpagadas
            //
            this.chkpagadas.AutoSize = true;
            this.chkpagadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpagadas.Location = new System.Drawing.Point(380, 16);
            this.chkpagadas.Name = "chkpagadas";
            this.chkpagadas.Size = new System.Drawing.Size(158, 19);
            this.chkpagadas.TabIndex = 2;
            this.chkpagadas.Text = "Mostrar cuentas pagadas";
            this.chkpagadas.UseVisualStyleBackColor = true;
            this.chkpagadas.CheckedChanged += new System.EventHandler(this.chkpagadas_CheckedChanged);
            //
            // dataGridView1
            //
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(969, 220);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            //
            // pnlpendientes
            //
            this.pnlpendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlpendientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpendientes.Controls.Add(this.lblpendientes);
            this.pnlpendientes.Controls.Add(this.lblcappendientes);
            this.pnlpendientes.Location = new System.Drawing.Point(12, 290);
            this.pnlpendientes.Name = "pnlpendientes";
            this.pnlpendientes.Size = new System.Drawing.Size(315, 65);
            this.pnlpendientes.TabIndex = 2;
            //
            // lblpendientes
            //
            this.lblpendientes.AutoSize = true;
            this.lblpendientes.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblpendientes.Location = new System.Drawing.Point(10, 26);
            this.lblpendientes.Name = "lblpendientes";
            this.lblpendientes.Size = new System.Drawing.Size(19, 25);
            this.lblpendientes.TabIndex = 3;
            this.lblpendientes.Text = "0";
            //
            // lblcappendientes
            //
            this.lblcappendientes.AutoSize = true;
            this.lblcappendientes.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcappendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcappendientes.Location = new System.Drawing.Point(10, 8);
            this.lblcappendientes.Name = "lblcappendientes";
            this.lblcappendientes.Size = new System.Drawing.Size(105, 12);
            this.lblcappendientes.TabIndex = 2;
            this.lblcappendientes.Text = "CUENTAS PENDIENTES";
            //
            // pnlsaldopendiente
            //
            this.pnlsaldopendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlsaldopendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlsaldopendiente.Controls.Add(this.lblsaldopendiente);
            this.pnlsaldopendiente.Controls.Add(this.lblcapsaldopendiente);
            this.pnlsaldopendiente.Location = new System.Drawing.Point(339, 290);
            this.pnlsaldopendiente.Name = "pnlsaldopendiente";
            this.pnlsaldopendiente.Size = new System.Drawing.Size(315, 65);
            this.pnlsaldopendiente.TabIndex = 3;
            //
            // lblsaldopendiente
            //
            this.lblsaldopendiente.AutoSize = true;
            this.lblsaldopendiente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldopendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblsaldopendiente.Location = new System.Drawing.Point(10, 26);
            this.lblsaldopendiente.Name = "lblsaldopendiente";
            this.lblsaldopendiente.Size = new System.Drawing.Size(66, 25);
            this.lblsaldopendiente.TabIndex = 3;
            this.lblsaldopendiente.Text = "Q 0.00";
            //
            // lblcapsaldopendiente
            //
            this.lblcapsaldopendiente.AutoSize = true;
            this.lblcapsaldopendiente.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapsaldopendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapsaldopendiente.Location = new System.Drawing.Point(10, 8);
            this.lblcapsaldopendiente.Name = "lblcapsaldopendiente";
            this.lblcapsaldopendiente.Size = new System.Drawing.Size(93, 12);
            this.lblcapsaldopendiente.TabIndex = 2;
            this.lblcapsaldopendiente.Text = "SALDO PENDIENTE";
            //
            // pnlvencido
            //
            this.pnlvencido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlvencido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlvencido.Controls.Add(this.lblvencido);
            this.pnlvencido.Controls.Add(this.lblcapvencido);
            this.pnlvencido.Location = new System.Drawing.Point(666, 290);
            this.pnlvencido.Name = "pnlvencido";
            this.pnlvencido.Size = new System.Drawing.Size(315, 65);
            this.pnlvencido.TabIndex = 4;
            //
            // lblvencido
            //
            this.lblvencido.AutoSize = true;
            this.lblvencido.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvencido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblvencido.Location = new System.Drawing.Point(10, 26);
            this.lblvencido.Name = "lblvencido";
            this.lblvencido.Size = new System.Drawing.Size(66, 25);
            this.lblvencido.TabIndex = 3;
            this.lblvencido.Text = "Q 0.00";
            //
            // lblcapvencido
            //
            this.lblcapvencido.AutoSize = true;
            this.lblcapvencido.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapvencido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapvencido.Location = new System.Drawing.Point(10, 8);
            this.lblcapvencido.Name = "lblcapvencido";
            this.lblcapvencido.Size = new System.Drawing.Size(98, 12);
            this.lblcapvencido.TabIndex = 2;
            this.lblcapvencido.Text = "SALDO VENCIDO";
            //
            // lbldetalle
            //
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lbldetalle.Location = new System.Drawing.Point(12, 366);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(130, 13);
            this.lbldetalle.TabIndex = 5;
            this.lbldetalle.Text = "DETALLE DE LA CUENTA";
            //
            // lblcapnocuenta
            //
            this.lblcapnocuenta.AutoSize = true;
            this.lblcapnocuenta.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapnocuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapnocuenta.Location = new System.Drawing.Point(12, 386);
            this.lblcapnocuenta.Name = "lblcapnocuenta";
            this.lblcapnocuenta.Size = new System.Drawing.Size(69, 12);
            this.lblcapnocuenta.TabIndex = 8;
            this.lblcapnocuenta.Text = "NO. CUENTA";
            //
            // txtnocuenta
            //
            this.txtnocuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtnocuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnocuenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnocuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtnocuenta.Location = new System.Drawing.Point(12, 402);
            this.txtnocuenta.Name = "txtnocuenta";
            this.txtnocuenta.ReadOnly = true;
            this.txtnocuenta.Size = new System.Drawing.Size(110, 25);
            this.txtnocuenta.TabIndex = 9;
            this.txtnocuenta.TabStop = false;
            //
            // lblcapproveedor
            //
            this.lblcapproveedor.AutoSize = true;
            this.lblcapproveedor.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapproveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapproveedor.Location = new System.Drawing.Point(134, 386);
            this.lblcapproveedor.Name = "lblcapproveedor";
            this.lblcapproveedor.Size = new System.Drawing.Size(68, 12);
            this.lblcapproveedor.TabIndex = 10;
            this.lblcapproveedor.Text = "PROVEEDOR";
            //
            // txtproveedor
            //
            this.txtproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtproveedor.Location = new System.Drawing.Point(134, 402);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.ReadOnly = true;
            this.txtproveedor.Size = new System.Drawing.Size(350, 25);
            this.txtproveedor.TabIndex = 11;
            this.txtproveedor.TabStop = false;
            //
            // lblcapfechacompra
            //
            this.lblcapfechacompra.AutoSize = true;
            this.lblcapfechacompra.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapfechacompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapfechacompra.Location = new System.Drawing.Point(496, 386);
            this.lblcapfechacompra.Name = "lblcapfechacompra";
            this.lblcapfechacompra.Size = new System.Drawing.Size(81, 12);
            this.lblcapfechacompra.TabIndex = 12;
            this.lblcapfechacompra.Text = "FECHA COMPRA";
            //
            // txtfechacompra
            //
            this.txtfechacompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtfechacompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfechacompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechacompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtfechacompra.Location = new System.Drawing.Point(496, 402);
            this.txtfechacompra.Name = "txtfechacompra";
            this.txtfechacompra.ReadOnly = true;
            this.txtfechacompra.Size = new System.Drawing.Size(150, 25);
            this.txtfechacompra.TabIndex = 13;
            this.txtfechacompra.TabStop = false;
            //
            // lblcapfechalimite
            //
            this.lblcapfechalimite.AutoSize = true;
            this.lblcapfechalimite.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapfechalimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapfechalimite.Location = new System.Drawing.Point(658, 386);
            this.lblcapfechalimite.Name = "lblcapfechalimite";
            this.lblcapfechalimite.Size = new System.Drawing.Size(76, 12);
            this.lblcapfechalimite.TabIndex = 14;
            this.lblcapfechalimite.Text = "FECHA LIMITE";
            //
            // txtfechalimite
            //
            this.txtfechalimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtfechalimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfechalimite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechalimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtfechalimite.Location = new System.Drawing.Point(658, 402);
            this.txtfechalimite.Name = "txtfechalimite";
            this.txtfechalimite.ReadOnly = true;
            this.txtfechalimite.Size = new System.Drawing.Size(150, 25);
            this.txtfechalimite.TabIndex = 15;
            this.txtfechalimite.TabStop = false;
            //
            // lblcapestado
            //
            this.lblcapestado.AutoSize = true;
            this.lblcapestado.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapestado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapestado.Location = new System.Drawing.Point(820, 386);
            this.lblcapestado.Name = "lblcapestado";
            this.lblcapestado.Size = new System.Drawing.Size(45, 12);
            this.lblcapestado.TabIndex = 16;
            this.lblcapestado.Text = "ESTADO";
            //
            // txtestado
            //
            this.txtestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtestado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtestado.Location = new System.Drawing.Point(820, 402);
            this.txtestado.Name = "txtestado";
            this.txtestado.ReadOnly = true;
            this.txtestado.Size = new System.Drawing.Size(161, 25);
            this.txtestado.TabIndex = 17;
            this.txtestado.TabStop = false;
            //
            // lblcapdiasrestantes
            //
            this.lblcapdiasrestantes.AutoSize = true;
            this.lblcapdiasrestantes.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapdiasrestantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapdiasrestantes.Location = new System.Drawing.Point(12, 438);
            this.lblcapdiasrestantes.Name = "lblcapdiasrestantes";
            this.lblcapdiasrestantes.Size = new System.Drawing.Size(85, 12);
            this.lblcapdiasrestantes.TabIndex = 18;
            this.lblcapdiasrestantes.Text = "DIAS RESTANTES";
            //
            // txtdiasrestantes
            //
            this.txtdiasrestantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtdiasrestantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiasrestantes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiasrestantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtdiasrestantes.Location = new System.Drawing.Point(12, 454);
            this.txtdiasrestantes.Name = "txtdiasrestantes";
            this.txtdiasrestantes.ReadOnly = true;
            this.txtdiasrestantes.Size = new System.Drawing.Size(200, 25);
            this.txtdiasrestantes.TabIndex = 19;
            this.txtdiasrestantes.TabStop = false;
            //
            // lblcaptotal
            //
            this.lblcaptotal.AutoSize = true;
            this.lblcaptotal.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaptotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcaptotal.Location = new System.Drawing.Point(224, 438);
            this.lblcaptotal.Name = "lblcaptotal";
            this.lblcaptotal.Size = new System.Drawing.Size(33, 12);
            this.lblcaptotal.TabIndex = 20;
            this.lblcaptotal.Text = "TOTAL";
            //
            // txttotal
            //
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.txttotal.Location = new System.Drawing.Point(224, 454);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(200, 25);
            this.txttotal.TabIndex = 21;
            this.txttotal.TabStop = false;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblcapsaldo
            //
            this.lblcapsaldo.AutoSize = true;
            this.lblcapsaldo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapsaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblcapsaldo.Location = new System.Drawing.Point(436, 438);
            this.lblcapsaldo.Name = "lblcapsaldo";
            this.lblcapsaldo.Size = new System.Drawing.Size(34, 12);
            this.lblcapsaldo.TabIndex = 22;
            this.lblcapsaldo.Text = "SALDO";
            //
            // txtsaldo
            //
            this.txtsaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtsaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsaldo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtsaldo.Location = new System.Drawing.Point(436, 454);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.ReadOnly = true;
            this.txtsaldo.Size = new System.Drawing.Size(200, 25);
            this.txtsaldo.TabIndex = 23;
            this.txtsaldo.TabStop = false;
            this.txtsaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // btnAbonar
            //
            this.btnAbonar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnAbonar.Enabled = false;
            this.btnAbonar.FlatAppearance.BorderSize = 0;
            this.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.ForeColor = System.Drawing.Color.White;
            this.btnAbonar.Location = new System.Drawing.Point(577, 496);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(140, 28);
            this.btnAbonar.TabIndex = 5;
            this.btnAbonar.Text = "Abonar (F2)";
            this.btnAbonar.UseVisualStyleBackColor = false;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            //
            // btnVerAbonos
            //
            this.btnVerAbonos.BackColor = System.Drawing.Color.White;
            this.btnVerAbonos.Enabled = false;
            this.btnVerAbonos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnVerAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerAbonos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAbonos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnVerAbonos.Location = new System.Drawing.Point(729, 496);
            this.btnVerAbonos.Name = "btnVerAbonos";
            this.btnVerAbonos.Size = new System.Drawing.Size(140, 28);
            this.btnVerAbonos.TabIndex = 6;
            this.btnVerAbonos.Text = "Ver abonos (F3)";
            this.btnVerAbonos.UseVisualStyleBackColor = false;
            this.btnVerAbonos.Click += new System.EventHandler(this.btnVerAbonos_Click);
            //
            // frmCxP
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 540);
            this.Controls.Add(this.btnVerAbonos);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.lblcapsaldo);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lblcaptotal);
            this.Controls.Add(this.txtdiasrestantes);
            this.Controls.Add(this.lblcapdiasrestantes);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblcapestado);
            this.Controls.Add(this.txtfechalimite);
            this.Controls.Add(this.lblcapfechalimite);
            this.Controls.Add(this.txtfechacompra);
            this.Controls.Add(this.lblcapfechacompra);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.lblcapproveedor);
            this.Controls.Add(this.txtnocuenta);
            this.Controls.Add(this.lblcapnocuenta);
            this.Controls.Add(this.lbldetalle);
            this.Controls.Add(this.pnlvencido);
            this.Controls.Add(this.pnlsaldopendiente);
            this.Controls.Add(this.pnlpendientes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlbusqueda);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCxP";
            this.Text = "Listado de cuentas por pagar";
            this.Load += new System.EventHandler(this.frmCxP_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCxP_KeyDown);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.pnlbusqueda, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pnlpendientes, 0);
            this.Controls.SetChildIndex(this.pnlsaldopendiente, 0);
            this.Controls.SetChildIndex(this.pnlvencido, 0);
            this.Controls.SetChildIndex(this.lbldetalle, 0);
            this.Controls.SetChildIndex(this.lblcapnocuenta, 0);
            this.Controls.SetChildIndex(this.txtnocuenta, 0);
            this.Controls.SetChildIndex(this.lblcapproveedor, 0);
            this.Controls.SetChildIndex(this.txtproveedor, 0);
            this.Controls.SetChildIndex(this.lblcapfechacompra, 0);
            this.Controls.SetChildIndex(this.txtfechacompra, 0);
            this.Controls.SetChildIndex(this.lblcapfechalimite, 0);
            this.Controls.SetChildIndex(this.txtfechalimite, 0);
            this.Controls.SetChildIndex(this.lblcapestado, 0);
            this.Controls.SetChildIndex(this.txtestado, 0);
            this.Controls.SetChildIndex(this.lblcapdiasrestantes, 0);
            this.Controls.SetChildIndex(this.txtdiasrestantes, 0);
            this.Controls.SetChildIndex(this.lblcaptotal, 0);
            this.Controls.SetChildIndex(this.txttotal, 0);
            this.Controls.SetChildIndex(this.lblcapsaldo, 0);
            this.Controls.SetChildIndex(this.txtsaldo, 0);
            this.Controls.SetChildIndex(this.btnAbonar, 0);
            this.Controls.SetChildIndex(this.btnVerAbonos, 0);
            this.pnlbusqueda.ResumeLayout(false);
            this.pnlbusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlpendientes.ResumeLayout(false);
            this.pnlpendientes.PerformLayout();
            this.pnlsaldopendiente.ResumeLayout(false);
            this.pnlsaldopendiente.PerformLayout();
            this.pnlvencido.ResumeLayout(false);
            this.pnlvencido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscarcuenta;
        private System.Windows.Forms.CheckBox chkpagadas;
        private System.Windows.Forms.Panel pnlpendientes;
        private System.Windows.Forms.Label lblpendientes;
        private System.Windows.Forms.Label lblcappendientes;
        private System.Windows.Forms.Panel pnlsaldopendiente;
        private System.Windows.Forms.Label lblsaldopendiente;
        private System.Windows.Forms.Label lblcapsaldopendiente;
        private System.Windows.Forms.Panel pnlvencido;
        private System.Windows.Forms.Label lblvencido;
        private System.Windows.Forms.Label lblcapvencido;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.Label lblcapnocuenta;
        private System.Windows.Forms.Label lblcapproveedor;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.Label lblcapfechacompra;
        private System.Windows.Forms.TextBox txtfechacompra;
        private System.Windows.Forms.Label lblcapfechalimite;
        private System.Windows.Forms.TextBox txtfechalimite;
        private System.Windows.Forms.Label lblcapestado;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label lblcapdiasrestantes;
        private System.Windows.Forms.TextBox txtdiasrestantes;
        private System.Windows.Forms.Label lblcaptotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lblcapsaldo;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Button btnVerAbonos;
        public System.Windows.Forms.TextBox txtnocuenta;
        public System.Windows.Forms.TextBox txtsaldo;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
