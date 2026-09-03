using System.Windows.Forms;

namespace Deposito
{
    partial class FormDetallePedido
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlFicha;
        private Label lblCapId;
        private Label lblValId;
        private Label lblCapFecha;
        private Label lblValFecha;
        private Label lblCapCliente;
        private Label lblValCliente;
        private Label lblCapRepartidor;
        private Label lblValRepartidor;

        private Panel pnlTotal;
        private Label lblCapTotal;
        private Label lblValTotal;

        private Label lblCapDetalle;
        private DataGridView dgvDetalle;

        private Label lblCapTotalGeneral;
        private Label lblValTotalGeneral;
        private Button btnCerrar;

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
            this.pnlFicha = new System.Windows.Forms.Panel();
            this.lblCapId = new System.Windows.Forms.Label();
            this.lblValId = new System.Windows.Forms.Label();
            this.lblCapFecha = new System.Windows.Forms.Label();
            this.lblValFecha = new System.Windows.Forms.Label();
            this.lblCapCliente = new System.Windows.Forms.Label();
            this.lblValCliente = new System.Windows.Forms.Label();
            this.lblCapRepartidor = new System.Windows.Forms.Label();
            this.lblValRepartidor = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblCapTotal = new System.Windows.Forms.Label();
            this.lblValTotal = new System.Windows.Forms.Label();
            this.lblCapDetalle = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblCapTotalGeneral = new System.Windows.Forms.Label();
            this.lblValTotalGeneral = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlFicha.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFicha
            // 
            this.pnlFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFicha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFicha.Controls.Add(this.lblCapId);
            this.pnlFicha.Controls.Add(this.lblValId);
            this.pnlFicha.Controls.Add(this.lblCapFecha);
            this.pnlFicha.Controls.Add(this.lblValFecha);
            this.pnlFicha.Controls.Add(this.lblCapCliente);
            this.pnlFicha.Controls.Add(this.lblValCliente);
            this.pnlFicha.Controls.Add(this.lblCapRepartidor);
            this.pnlFicha.Controls.Add(this.lblValRepartidor);
            this.pnlFicha.Location = new System.Drawing.Point(12, 12);
            this.pnlFicha.Name = "pnlFicha";
            this.pnlFicha.Size = new System.Drawing.Size(430, 96);
            this.pnlFicha.TabIndex = 0;
            // 
            // lblCapId
            // 
            this.lblCapId.AutoSize = true;
            this.lblCapId.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapId.Location = new System.Drawing.Point(14, 10);
            this.lblCapId.Name = "lblCapId";
            this.lblCapId.Size = new System.Drawing.Size(54, 12);
            this.lblCapId.TabIndex = 0;
            this.lblCapId.Text = "ID PEDIDO";
            // 
            // lblValId
            // 
            this.lblValId.AutoSize = true;
            this.lblValId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblValId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblValId.Location = new System.Drawing.Point(14, 27);
            this.lblValId.Name = "lblValId";
            this.lblValId.Size = new System.Drawing.Size(15, 19);
            this.lblValId.TabIndex = 1;
            this.lblValId.Text = "-";
            // 
            // lblCapFecha
            // 
            this.lblCapFecha.AutoSize = true;
            this.lblCapFecha.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapFecha.Location = new System.Drawing.Point(224, 10);
            this.lblCapFecha.Name = "lblCapFecha";
            this.lblCapFecha.Size = new System.Drawing.Size(36, 12);
            this.lblCapFecha.TabIndex = 2;
            this.lblCapFecha.Text = "FECHA";
            // 
            // lblValFecha
            // 
            this.lblValFecha.AutoSize = true;
            this.lblValFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblValFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblValFecha.Location = new System.Drawing.Point(224, 27);
            this.lblValFecha.Name = "lblValFecha";
            this.lblValFecha.Size = new System.Drawing.Size(15, 19);
            this.lblValFecha.TabIndex = 3;
            this.lblValFecha.Text = "-";
            // 
            // lblCapCliente
            // 
            this.lblCapCliente.AutoSize = true;
            this.lblCapCliente.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapCliente.Location = new System.Drawing.Point(14, 52);
            this.lblCapCliente.Name = "lblCapCliente";
            this.lblCapCliente.Size = new System.Drawing.Size(43, 12);
            this.lblCapCliente.TabIndex = 4;
            this.lblCapCliente.Text = "CLIENTE";
            // 
            // lblValCliente
            // 
            this.lblValCliente.AutoSize = true;
            this.lblValCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblValCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblValCliente.Location = new System.Drawing.Point(14, 69);
            this.lblValCliente.Name = "lblValCliente";
            this.lblValCliente.Size = new System.Drawing.Size(15, 19);
            this.lblValCliente.TabIndex = 5;
            this.lblValCliente.Text = "-";
            // 
            // lblCapRepartidor
            // 
            this.lblCapRepartidor.AutoSize = true;
            this.lblCapRepartidor.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapRepartidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapRepartidor.Location = new System.Drawing.Point(224, 52);
            this.lblCapRepartidor.Name = "lblCapRepartidor";
            this.lblCapRepartidor.Size = new System.Drawing.Size(67, 12);
            this.lblCapRepartidor.TabIndex = 6;
            this.lblCapRepartidor.Text = "REPARTIDOR";
            // 
            // lblValRepartidor
            // 
            this.lblValRepartidor.AutoSize = true;
            this.lblValRepartidor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblValRepartidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblValRepartidor.Location = new System.Drawing.Point(224, 69);
            this.lblValRepartidor.Name = "lblValRepartidor";
            this.lblValRepartidor.Size = new System.Drawing.Size(15, 19);
            this.lblValRepartidor.TabIndex = 7;
            this.lblValRepartidor.Text = "-";
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.pnlTotal.Controls.Add(this.lblCapTotal);
            this.pnlTotal.Controls.Add(this.lblValTotal);
            this.pnlTotal.Location = new System.Drawing.Point(454, 12);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(174, 96);
            this.pnlTotal.TabIndex = 1;
            // 
            // lblCapTotal
            // 
            this.lblCapTotal.AutoSize = true;
            this.lblCapTotal.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lblCapTotal.Location = new System.Drawing.Point(14, 16);
            this.lblCapTotal.Name = "lblCapTotal";
            this.lblCapTotal.Size = new System.Drawing.Size(75, 12);
            this.lblCapTotal.TabIndex = 0;
            this.lblCapTotal.Text = "TOTAL PEDIDO";
            // 
            // lblValTotal
            // 
            this.lblValTotal.AutoSize = true;
            this.lblValTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblValTotal.ForeColor = System.Drawing.Color.White;
            this.lblValTotal.Location = new System.Drawing.Point(14, 36);
            this.lblValTotal.Name = "lblValTotal";
            this.lblValTotal.Size = new System.Drawing.Size(81, 30);
            this.lblValTotal.TabIndex = 1;
            this.lblValTotal.Text = "Q 0.00";
            // 
            // lblCapDetalle
            // 
            this.lblCapDetalle.AutoSize = true;
            this.lblCapDetalle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapDetalle.Location = new System.Drawing.Point(12, 122);
            this.lblCapDetalle.Name = "lblCapDetalle";
            this.lblCapDetalle.Size = new System.Drawing.Size(103, 12);
            this.lblCapDetalle.TabIndex = 2;
            this.lblCapDetalle.Text = "DETALLE DEL PEDIDO";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.dgvDetalle.Location = new System.Drawing.Point(12, 140);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowTemplate.Height = 30;
            this.dgvDetalle.Size = new System.Drawing.Size(616, 280);
            this.dgvDetalle.TabIndex = 3;
            // 
            // lblCapTotalGeneral
            // 
            this.lblCapTotalGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCapTotalGeneral.AutoSize = true;
            this.lblCapTotalGeneral.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCapTotalGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCapTotalGeneral.Location = new System.Drawing.Point(12, 452);
            this.lblCapTotalGeneral.Name = "lblCapTotalGeneral";
            this.lblCapTotalGeneral.Size = new System.Drawing.Size(83, 12);
            this.lblCapTotalGeneral.TabIndex = 4;
            this.lblCapTotalGeneral.Text = "TOTAL GENERAL";
            // 
            // lblValTotalGeneral
            // 
            this.lblValTotalGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValTotalGeneral.AutoSize = true;
            this.lblValTotalGeneral.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblValTotalGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.lblValTotalGeneral.Location = new System.Drawing.Point(12, 468);
            this.lblValTotalGeneral.Name = "lblValTotalGeneral";
            this.lblValTotalGeneral.Size = new System.Drawing.Size(66, 25);
            this.lblValTotalGeneral.TabIndex = 5;
            this.lblValTotalGeneral.Text = "Q 0.00";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(98)))));
            this.btnCerrar.Location = new System.Drawing.Point(506, 458);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 32);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormDetallePedido
            // 
            this.ClientSize = new System.Drawing.Size(640, 510);
            this.Controls.Add(this.pnlFicha);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.lblCapDetalle);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lblCapTotalGeneral);
            this.Controls.Add(this.lblValTotalGeneral);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetallePedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de pedido";
            this.Load += new System.EventHandler(this.FormDetallePedido_Load);
            this.pnlFicha.ResumeLayout(false);
            this.pnlFicha.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}