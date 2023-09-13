namespace Deposito
{
    partial class frmAgregarDetallePedido
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdescpro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcodigopro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsubtdet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecioprod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcantdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtnpedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(725, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(74, 10);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(664, 21);
            this.txtbuscar.TabIndex = 3;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(582, 350);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(107, 21);
            this.txtstock.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(579, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Stock";
            // 
            // txtdescpro
            // 
            this.txtdescpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescpro.Location = new System.Drawing.Point(242, 351);
            this.txtdescpro.Name = "txtdescpro";
            this.txtdescpro.ReadOnly = true;
            this.txtdescpro.Size = new System.Drawing.Size(334, 21);
            this.txtdescpro.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(239, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Descripcion";
            // 
            // txtcodigopro
            // 
            this.txtcodigopro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigopro.Location = new System.Drawing.Point(129, 351);
            this.txtcodigopro.Name = "txtcodigopro";
            this.txtcodigopro.ReadOnly = true;
            this.txtcodigopro.Size = new System.Drawing.Size(107, 21);
            this.txtcodigopro.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Codigo";
            // 
            // txtsubtdet
            // 
            this.txtsubtdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtdet.Location = new System.Drawing.Point(242, 403);
            this.txtsubtdet.Name = "txtsubtdet";
            this.txtsubtdet.Size = new System.Drawing.Size(107, 21);
            this.txtsubtdet.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Subtotal";
            // 
            // txtprecioprod
            // 
            this.txtprecioprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioprod.Location = new System.Drawing.Point(15, 401);
            this.txtprecioprod.Name = "txtprecioprod";
            this.txtprecioprod.Size = new System.Drawing.Size(107, 21);
            this.txtprecioprod.TabIndex = 34;
            this.txtprecioprod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprecioprod_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio";
            // 
            // txtcantdet
            // 
            this.txtcantdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantdet.Location = new System.Drawing.Point(128, 402);
            this.txtcantdet.Name = "txtcantdet";
            this.txtcantdet.Size = new System.Drawing.Size(107, 21);
            this.txtcantdet.TabIndex = 32;
            this.txtcantdet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantdet_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cantidad";
            // 
            // btnagregar
            // 
            this.btnagregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(392, 402);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(170, 23);
            this.btnagregar.TabIndex = 43;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(568, 402);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(170, 23);
            this.btnsalir.TabIndex = 44;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // txtnpedido
            // 
            this.txtnpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnpedido.Location = new System.Drawing.Point(12, 350);
            this.txtnpedido.Name = "txtnpedido";
            this.txtnpedido.ReadOnly = true;
            this.txtnpedido.Size = new System.Drawing.Size(107, 21);
            this.txtnpedido.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "No. Pedido";
            // 
            // frmAgregarDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 436);
            this.Controls.Add(this.txtnpedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdescpro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcodigopro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsubtdet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtprecioprod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcantdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAgregarDetallePedido";
            this.Text = "Agregar un detalle al pedido";
            this.Load += new System.EventHandler(this.frmAgregarDetallePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdescpro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcodigopro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsubtdet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecioprod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcantdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtnpedido;
        private System.Windows.Forms.Label label2;
    }
}