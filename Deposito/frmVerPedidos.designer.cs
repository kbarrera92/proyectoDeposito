namespace Deposito
{
    partial class frmVerPedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnpedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfechapedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotalpedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iddet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detsabores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminarpedido = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.buttonBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(16, 37);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(573, 21);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(573, 295);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtnpedido
            // 
            this.txtnpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnpedido.Location = new System.Drawing.Point(16, 395);
            this.txtnpedido.Name = "txtnpedido";
            this.txtnpedido.Size = new System.Drawing.Size(107, 21);
            this.txtnpedido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. de pedido";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.Location = new System.Drawing.Point(129, 443);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(460, 21);
            this.txtnombrecliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // txtfechapedido
            // 
            this.txtfechapedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechapedido.Location = new System.Drawing.Point(16, 443);
            this.txtfechapedido.Name = "txtfechapedido";
            this.txtfechapedido.Size = new System.Drawing.Size(107, 21);
            this.txtfechapedido.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // txttotalpedido
            // 
            this.txttotalpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpedido.Location = new System.Drawing.Point(1031, 360);
            this.txttotalpedido.Name = "txttotalpedido";
            this.txttotalpedido.Size = new System.Drawing.Size(174, 26);
            this.txttotalpedido.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(980, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Detalles del pedido";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddet,
            this.codpro,
            this.desc,
            this.cant,
            this.precio,
            this.subt,
            this.detsabores});
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(609, 65);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(596, 295);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // iddet
            // 
            this.iddet.HeaderText = "ID";
            this.iddet.Name = "iddet";
            this.iddet.Width = 70;
            // 
            // codpro
            // 
            this.codpro.HeaderText = "Codigo";
            this.codpro.Name = "codpro";
            this.codpro.Width = 80;
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripcion";
            this.desc.Name = "desc";
            this.desc.Width = 175;
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
            // detsabores
            // 
            this.detsabores.HeaderText = "Det. Sabores";
            this.detsabores.Name = "detsabores";
            // 
            // btneliminarpedido
            // 
            this.btneliminarpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarpedido.Location = new System.Drawing.Point(933, 412);
            this.btneliminarpedido.Name = "btneliminarpedido";
            this.btneliminarpedido.Size = new System.Drawing.Size(133, 23);
            this.btneliminarpedido.TabIndex = 14;
            this.btneliminarpedido.Text = "Eliminar pedido";
            this.btneliminarpedido.UseVisualStyleBackColor = true;
            this.btneliminarpedido.Click += new System.EventHandler(this.btneliminarpedido_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(1072, 473);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(133, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1072, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidcliente.Location = new System.Drawing.Point(190, 422);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(23, 17);
            this.lblidcliente.TabIndex = 33;
            this.lblidcliente.Text = "ID";
            this.lblidcliente.Visible = false;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(1072, 412);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(133, 23);
            this.buttonBorrar.TabIndex = 34;
            this.buttonBorrar.Text = "Borrar detalle";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // frmVerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 505);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.lblidcliente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminarpedido);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotalpedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfechapedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnpedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Name = "frmVerPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de pedidos registrados";
            this.Load += new System.EventHandler(this.frmVerPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnpedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfechapedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotalpedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btneliminarpedido;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddet;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subt;
        private System.Windows.Forms.DataGridViewTextBoxColumn detsabores;
        private System.Windows.Forms.Button buttonBorrar;
    }
}