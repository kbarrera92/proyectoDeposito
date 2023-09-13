namespace Deposito
{
    partial class frmVerUtilidad
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txttotalUtilidades = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.desc,
            this.cant,
            this.pventa,
            this.pcosto,
            this.uti});
            this.dataGridView4.Location = new System.Drawing.Point(11, 59);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(850, 353);
            this.dataGridView4.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(231, 33);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta";
            // 
            // button2
            // 
            this.button2.Image = global::Deposito.Properties.Resources.Actions_edit_clear_icon;
            this.button2.Location = new System.Drawing.Point(465, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Image = global::Deposito.Properties.Resources.Magnifying_Glass_icon;
            this.button1.Location = new System.Drawing.Point(437, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txttotalUtilidades
            // 
            this.txttotalUtilidades.BackColor = System.Drawing.Color.Blue;
            this.txttotalUtilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalUtilidades.ForeColor = System.Drawing.Color.Yellow;
            this.txttotalUtilidades.Location = new System.Drawing.Point(664, 411);
            this.txttotalUtilidades.Name = "txttotalUtilidades";
            this.txttotalUtilidades.Size = new System.Drawing.Size(197, 44);
            this.txttotalUtilidades.TabIndex = 29;
            this.txttotalUtilidades.Text = "0.00";
            this.txttotalUtilidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
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
            // pventa
            // 
            this.pventa.HeaderText = "P. Venta";
            this.pventa.Name = "pventa";
            this.pventa.ReadOnly = true;
            // 
            // pcosto
            // 
            this.pcosto.HeaderText = "P. Costo";
            this.pcosto.Name = "pcosto";
            this.pcosto.ReadOnly = true;
            // 
            // uti
            // 
            this.uti.HeaderText = "Utilidad";
            this.uti.Name = "uti";
            this.uti.ReadOnly = true;
            // 
            // frmVerUtilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 466);
            this.Controls.Add(this.txttotalUtilidades);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView4);
            this.Name = "frmVerUtilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de utilidad por fechas";
            this.Load += new System.EventHandler(this.frmVerUtilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttotalUtilidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn pventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn uti;
    }
}