using System.Windows.Forms;

namespace Deposito
{
    partial class FrmReporteMovimientos
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Button btnGenerar;
        private Button btnRegistrarMovimiento;

        private Panel pnlKpiVentas;
        private Label lblCapVentas;
        private Label lblValVentas;

        private Panel pnlKpiEntrada;
        private Label lblCapEntrada;
        private Label lblValEntrada;

        private Panel pnlKpiCompras;
        private Label lblCapCompras;
        private Label lblValCompras;

        private Panel pnlKpiSalidas;
        private Label lblCapSalidas;
        private Label lblValSalidas;

        private Panel pnlKpiSaldo;
        private Label lblCapSaldo;
        private Label lblValSaldo;

        private DataGridView dgvReporte;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.pnlKpiVentas = new System.Windows.Forms.Panel();
            this.lblCapVentas = new System.Windows.Forms.Label();
            this.lblValVentas = new System.Windows.Forms.Label();
            this.pnlKpiEntrada = new System.Windows.Forms.Panel();
            this.lblCapEntrada = new System.Windows.Forms.Label();
            this.lblValEntrada = new System.Windows.Forms.Label();
            this.pnlKpiCompras = new System.Windows.Forms.Panel();
            this.lblCapCompras = new System.Windows.Forms.Label();
            this.lblValCompras = new System.Windows.Forms.Label();
            this.pnlKpiSalidas = new System.Windows.Forms.Panel();
            this.lblCapSalidas = new System.Windows.Forms.Label();
            this.lblValSalidas = new System.Windows.Forms.Label();
            this.pnlKpiSaldo = new System.Windows.Forms.Panel();
            this.lblCapSaldo = new System.Windows.Forms.Label();
            this.lblValSaldo = new System.Windows.Forms.Label();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.pnlKpiVentas.SuspendLayout();
            this.pnlKpiEntrada.SuspendLayout();
            this.pnlKpiCompras.SuspendLayout();
            this.pnlKpiSalidas.SuspendLayout();
            this.pnlKpiSaldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(12, 18);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(42, 15);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(60, 15);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(130, 23);
            this.dtpDesde.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(210, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(140, 28);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarMovimiento.BackColor = System.Drawing.Color.White;
            this.btnRegistrarMovimiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnRegistrarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMovimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(700, 12);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(188, 28);
            this.btnRegistrarMovimiento.TabIndex = 3;
            this.btnRegistrarMovimiento.Text = "Registrar movimiento";
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = false;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
            // 
            // pnlKpiVentas
            // 
            this.pnlKpiVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlKpiVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiVentas.Controls.Add(this.lblCapVentas);
            this.pnlKpiVentas.Controls.Add(this.lblValVentas);
            this.pnlKpiVentas.Location = new System.Drawing.Point(12, 55);
            this.pnlKpiVentas.Name = "pnlKpiVentas";
            this.pnlKpiVentas.Size = new System.Drawing.Size(167, 65);
            this.pnlKpiVentas.TabIndex = 4;
            // 
            // lblCapVentas
            // 
            this.lblCapVentas.AutoSize = true;
            this.lblCapVentas.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapVentas.Location = new System.Drawing.Point(10, 8);
            this.lblCapVentas.Name = "lblCapVentas";
            this.lblCapVentas.Size = new System.Drawing.Size(43, 12);
            this.lblCapVentas.TabIndex = 0;
            this.lblCapVentas.Text = "VENTAS";
            // 
            // lblValVentas
            // 
            this.lblValVentas.AutoSize = true;
            this.lblValVentas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblValVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblValVentas.Location = new System.Drawing.Point(10, 26);
            this.lblValVentas.Name = "lblValVentas";
            this.lblValVentas.Size = new System.Drawing.Size(47, 25);
            this.lblValVentas.TabIndex = 1;
            this.lblValVentas.Text = "0.00";
            // 
            // pnlKpiEntrada
            // 
            this.pnlKpiEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlKpiEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiEntrada.Controls.Add(this.lblCapEntrada);
            this.pnlKpiEntrada.Controls.Add(this.lblValEntrada);
            this.pnlKpiEntrada.Location = new System.Drawing.Point(189, 55);
            this.pnlKpiEntrada.Name = "pnlKpiEntrada";
            this.pnlKpiEntrada.Size = new System.Drawing.Size(167, 65);
            this.pnlKpiEntrada.TabIndex = 5;
            // 
            // lblCapEntrada
            // 
            this.lblCapEntrada.AutoSize = true;
            this.lblCapEntrada.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapEntrada.Location = new System.Drawing.Point(10, 8);
            this.lblCapEntrada.Name = "lblCapEntrada";
            this.lblCapEntrada.Size = new System.Drawing.Size(52, 12);
            this.lblCapEntrada.TabIndex = 0;
            this.lblCapEntrada.Text = "ENTRADA";
            // 
            // lblValEntrada
            // 
            this.lblValEntrada.AutoSize = true;
            this.lblValEntrada.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblValEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblValEntrada.Location = new System.Drawing.Point(10, 26);
            this.lblValEntrada.Name = "lblValEntrada";
            this.lblValEntrada.Size = new System.Drawing.Size(47, 25);
            this.lblValEntrada.TabIndex = 1;
            this.lblValEntrada.Text = "0.00";
            // 
            // pnlKpiCompras
            // 
            this.pnlKpiCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlKpiCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiCompras.Controls.Add(this.lblCapCompras);
            this.pnlKpiCompras.Controls.Add(this.lblValCompras);
            this.pnlKpiCompras.Location = new System.Drawing.Point(366, 55);
            this.pnlKpiCompras.Name = "pnlKpiCompras";
            this.pnlKpiCompras.Size = new System.Drawing.Size(167, 65);
            this.pnlKpiCompras.TabIndex = 6;
            // 
            // lblCapCompras
            // 
            this.lblCapCompras.AutoSize = true;
            this.lblCapCompras.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapCompras.Location = new System.Drawing.Point(10, 8);
            this.lblCapCompras.Name = "lblCapCompras";
            this.lblCapCompras.Size = new System.Drawing.Size(55, 12);
            this.lblCapCompras.TabIndex = 0;
            this.lblCapCompras.Text = "COMPRAS";
            // 
            // lblValCompras
            // 
            this.lblValCompras.AutoSize = true;
            this.lblValCompras.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblValCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblValCompras.Location = new System.Drawing.Point(10, 26);
            this.lblValCompras.Name = "lblValCompras";
            this.lblValCompras.Size = new System.Drawing.Size(47, 25);
            this.lblValCompras.TabIndex = 1;
            this.lblValCompras.Text = "0.00";
            // 
            // pnlKpiSalidas
            // 
            this.pnlKpiSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlKpiSalidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiSalidas.Controls.Add(this.lblCapSalidas);
            this.pnlKpiSalidas.Controls.Add(this.lblValSalidas);
            this.pnlKpiSalidas.Location = new System.Drawing.Point(543, 55);
            this.pnlKpiSalidas.Name = "pnlKpiSalidas";
            this.pnlKpiSalidas.Size = new System.Drawing.Size(167, 65);
            this.pnlKpiSalidas.TabIndex = 7;
            // 
            // lblCapSalidas
            // 
            this.lblCapSalidas.AutoSize = true;
            this.lblCapSalidas.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapSalidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapSalidas.Location = new System.Drawing.Point(10, 8);
            this.lblCapSalidas.Name = "lblCapSalidas";
            this.lblCapSalidas.Size = new System.Drawing.Size(46, 12);
            this.lblCapSalidas.TabIndex = 0;
            this.lblCapSalidas.Text = "SALIDAS";
            // 
            // lblValSalidas
            // 
            this.lblValSalidas.AutoSize = true;
            this.lblValSalidas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblValSalidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblValSalidas.Location = new System.Drawing.Point(10, 26);
            this.lblValSalidas.Name = "lblValSalidas";
            this.lblValSalidas.Size = new System.Drawing.Size(47, 25);
            this.lblValSalidas.TabIndex = 1;
            this.lblValSalidas.Text = "0.00";
            // 
            // pnlKpiSaldo
            // 
            this.pnlKpiSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKpiSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.pnlKpiSaldo.Controls.Add(this.lblCapSaldo);
            this.pnlKpiSaldo.Controls.Add(this.lblValSaldo);
            this.pnlKpiSaldo.Location = new System.Drawing.Point(720, 55);
            this.pnlKpiSaldo.Name = "pnlKpiSaldo";
            this.pnlKpiSaldo.Size = new System.Drawing.Size(167, 65);
            this.pnlKpiSaldo.TabIndex = 8;
            // 
            // lblCapSaldo
            // 
            this.lblCapSaldo.AutoSize = true;
            this.lblCapSaldo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lblCapSaldo.Location = new System.Drawing.Point(10, 8);
            this.lblCapSaldo.Name = "lblCapSaldo";
            this.lblCapSaldo.Size = new System.Drawing.Size(69, 12);
            this.lblCapSaldo.TabIndex = 0;
            this.lblCapSaldo.Text = "SALDO FINAL";
            // 
            // lblValSaldo
            // 
            this.lblValSaldo.AutoSize = true;
            this.lblValSaldo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblValSaldo.ForeColor = System.Drawing.Color.White;
            this.lblValSaldo.Location = new System.Drawing.Point(10, 26);
            this.lblValSaldo.Name = "lblValSaldo";
            this.lblValSaldo.Size = new System.Drawing.Size(50, 25);
            this.lblValSaldo.TabIndex = 1;
            this.lblValSaldo.Text = "0.00";
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporte.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.dgvReporte.Location = new System.Drawing.Point(12, 132);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.RowTemplate.Height = 30;
            this.dgvReporte.Size = new System.Drawing.Size(876, 416);
            this.dgvReporte.TabIndex = 9;
            // 
            // FrmReporteMovimientos
            // 
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnRegistrarMovimiento);
            this.Controls.Add(this.pnlKpiVentas);
            this.Controls.Add(this.pnlKpiEntrada);
            this.Controls.Add(this.pnlKpiCompras);
            this.Controls.Add(this.pnlKpiSalidas);
            this.Controls.Add(this.pnlKpiSaldo);
            this.Controls.Add(this.dgvReporte);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmReporteMovimientos";
            this.Text = "Reporte de movimientos";
            this.pnlKpiVentas.ResumeLayout(false);
            this.pnlKpiVentas.PerformLayout();
            this.pnlKpiEntrada.ResumeLayout(false);
            this.pnlKpiEntrada.PerformLayout();
            this.pnlKpiCompras.ResumeLayout(false);
            this.pnlKpiCompras.PerformLayout();
            this.pnlKpiSalidas.ResumeLayout(false);
            this.pnlKpiSalidas.PerformLayout();
            this.pnlKpiSaldo.ResumeLayout(false);
            this.pnlKpiSaldo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}