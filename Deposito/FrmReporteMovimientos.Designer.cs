using System.Windows.Forms;

namespace Deposito
{
    partial class FrmReporteMovimientos
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Button btnGenerar;
        private DataGridView dgvReporte;
        private Panel pnlTotales;
        private Label lblTotalVentasCap, lblTotalVentas;
        private Label lblTotalEntradaCap, lblTotalEntrada;
        private Label lblTotalComprasCap, lblTotalCompras;
        private Label lblTotalSalidasCap, lblTotalSalidas;
        private Label lblSaldoFinalCap, lblSaldoFinal;
        private Button btnRegistrarMovimiento;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.lblTotalVentasCap = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblTotalEntradaCap = new System.Windows.Forms.Label();
            this.lblTotalEntrada = new System.Windows.Forms.Label();
            this.lblTotalComprasCap = new System.Windows.Forms.Label();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.lblTotalSalidasCap = new System.Windows.Forms.Label();
            this.lblTotalSalidas = new System.Windows.Forms.Label();
            this.lblSaldoFinalCap = new System.Windows.Forms.Label();
            this.lblSaldoFinal = new System.Windows.Forms.Label();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(12, 15);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(60, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(130, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(210, 10);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 25);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporte.Location = new System.Drawing.Point(12, 45);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.Size = new System.Drawing.Size(760, 380);
            this.dgvReporte.TabIndex = 3;
            // 
            // pnlTotales
            // 
            this.pnlTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotales.Controls.Add(this.lblTotalVentasCap);
            this.pnlTotales.Controls.Add(this.lblTotalVentas);
            this.pnlTotales.Controls.Add(this.lblTotalEntradaCap);
            this.pnlTotales.Controls.Add(this.lblTotalEntrada);
            this.pnlTotales.Controls.Add(this.lblTotalComprasCap);
            this.pnlTotales.Controls.Add(this.lblTotalCompras);
            this.pnlTotales.Controls.Add(this.lblTotalSalidasCap);
            this.pnlTotales.Controls.Add(this.lblTotalSalidas);
            this.pnlTotales.Controls.Add(this.lblSaldoFinalCap);
            this.pnlTotales.Controls.Add(this.lblSaldoFinal);
            this.pnlTotales.Location = new System.Drawing.Point(12, 435);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(760, 30);
            this.pnlTotales.TabIndex = 4;
            // 
            // lblTotalVentasCap
            // 
            this.lblTotalVentasCap.AutoSize = true;
            this.lblTotalVentasCap.Location = new System.Drawing.Point(0, 8);
            this.lblTotalVentasCap.Name = "lblTotalVentasCap";
            this.lblTotalVentasCap.Size = new System.Drawing.Size(43, 13);
            this.lblTotalVentasCap.TabIndex = 0;
            this.lblTotalVentasCap.Text = "Ventas:";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(70, 8);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(28, 13);
            this.lblTotalVentas.TabIndex = 1;
            this.lblTotalVentas.Text = "0.00";
            // 
            // lblTotalEntradaCap
            // 
            this.lblTotalEntradaCap.AutoSize = true;
            this.lblTotalEntradaCap.Location = new System.Drawing.Point(140, 8);
            this.lblTotalEntradaCap.Name = "lblTotalEntradaCap";
            this.lblTotalEntradaCap.Size = new System.Drawing.Size(47, 13);
            this.lblTotalEntradaCap.TabIndex = 2;
            this.lblTotalEntradaCap.Text = "Entrada:";
            // 
            // lblTotalEntrada
            // 
            this.lblTotalEntrada.AutoSize = true;
            this.lblTotalEntrada.Location = new System.Drawing.Point(210, 8);
            this.lblTotalEntrada.Name = "lblTotalEntrada";
            this.lblTotalEntrada.Size = new System.Drawing.Size(28, 13);
            this.lblTotalEntrada.TabIndex = 3;
            this.lblTotalEntrada.Text = "0.00";
            // 
            // lblTotalComprasCap
            // 
            this.lblTotalComprasCap.AutoSize = true;
            this.lblTotalComprasCap.Location = new System.Drawing.Point(280, 8);
            this.lblTotalComprasCap.Name = "lblTotalComprasCap";
            this.lblTotalComprasCap.Size = new System.Drawing.Size(51, 13);
            this.lblTotalComprasCap.TabIndex = 4;
            this.lblTotalComprasCap.Text = "Compras:";
            // 
            // lblTotalCompras
            // 
            this.lblTotalCompras.AutoSize = true;
            this.lblTotalCompras.Location = new System.Drawing.Point(350, 8);
            this.lblTotalCompras.Name = "lblTotalCompras";
            this.lblTotalCompras.Size = new System.Drawing.Size(28, 13);
            this.lblTotalCompras.TabIndex = 5;
            this.lblTotalCompras.Text = "0.00";
            // 
            // lblTotalSalidasCap
            // 
            this.lblTotalSalidasCap.AutoSize = true;
            this.lblTotalSalidasCap.Location = new System.Drawing.Point(420, 8);
            this.lblTotalSalidasCap.Name = "lblTotalSalidasCap";
            this.lblTotalSalidasCap.Size = new System.Drawing.Size(44, 13);
            this.lblTotalSalidasCap.TabIndex = 6;
            this.lblTotalSalidasCap.Text = "Salidas:";
            // 
            // lblTotalSalidas
            // 
            this.lblTotalSalidas.AutoSize = true;
            this.lblTotalSalidas.Location = new System.Drawing.Point(490, 8);
            this.lblTotalSalidas.Name = "lblTotalSalidas";
            this.lblTotalSalidas.Size = new System.Drawing.Size(28, 13);
            this.lblTotalSalidas.TabIndex = 7;
            this.lblTotalSalidas.Text = "0.00";
            // 
            // lblSaldoFinalCap
            // 
            this.lblSaldoFinalCap.AutoSize = true;
            this.lblSaldoFinalCap.Location = new System.Drawing.Point(560, 8);
            this.lblSaldoFinalCap.Name = "lblSaldoFinalCap";
            this.lblSaldoFinalCap.Size = new System.Drawing.Size(59, 13);
            this.lblSaldoFinalCap.TabIndex = 8;
            this.lblSaldoFinalCap.Text = "Saldo final:";
            // 
            // lblSaldoFinal
            // 
            this.lblSaldoFinal.AutoSize = true;
            this.lblSaldoFinal.Location = new System.Drawing.Point(640, 8);
            this.lblSaldoFinal.Name = "lblSaldoFinal";
            this.lblSaldoFinal.Size = new System.Drawing.Size(28, 13);
            this.lblSaldoFinal.TabIndex = 9;
            this.lblSaldoFinal.Text = "0.00";
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(330, 10);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(150, 25);
            this.btnRegistrarMovimiento.TabIndex = 5;
            this.btnRegistrarMovimiento.Text = "Registrar movimiento";
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
            // 
            // FrmReporteMovimientos
            // 
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.pnlTotales);
            this.Controls.Add(this.btnRegistrarMovimiento);
            this.Name = "FrmReporteMovimientos";
            this.Text = "Reporte de movimientos";
            this.Load += new System.EventHandler(this.FrmReporteMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}