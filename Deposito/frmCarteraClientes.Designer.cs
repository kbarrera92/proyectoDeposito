namespace Deposito
{
    partial class frmCarteraClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnabonoasaldo = new System.Windows.Forms.Button();
            this.btnverpedidos = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txttotalsaldos = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar cliente";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(16, 29);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(470, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcli,
            this.id,
            this.nombre,
            this.area,
            this.direccion,
            this.tel,
            this.saldo});
            this.dataGridView1.Location = new System.Drawing.Point(16, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(685, 376);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idcli
            // 
            this.idcli.HeaderText = "ID";
            this.idcli.Name = "idcli";
            this.idcli.ReadOnly = true;
            this.idcli.Width = 50;
            // 
            // id
            // 
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Cliente";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 225;
            // 
            // area
            // 
            this.area.HeaderText = "Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.Width = 150;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 150;
            // 
            // tel
            // 
            this.tel.HeaderText = "Telefono";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Width = 90;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Width = 80;
            // 
            // btnabonoasaldo
            // 
            this.btnabonoasaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabonoasaldo.Location = new System.Drawing.Point(708, 362);
            this.btnabonoasaldo.Name = "btnabonoasaldo";
            this.btnabonoasaldo.Size = new System.Drawing.Size(358, 24);
            this.btnabonoasaldo.TabIndex = 3;
            this.btnabonoasaldo.Text = "Abonar";
            this.btnabonoasaldo.UseVisualStyleBackColor = true;
            this.btnabonoasaldo.Click += new System.EventHandler(this.btnabonoasaldo_Click);
            // 
            // btnverpedidos
            // 
            this.btnverpedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverpedidos.Location = new System.Drawing.Point(708, 422);
            this.btnverpedidos.Name = "btnverpedidos";
            this.btnverpedidos.Size = new System.Drawing.Size(358, 24);
            this.btnverpedidos.TabIndex = 4;
            this.btnverpedidos.Text = "Ver pedidos del cliente";
            this.btnverpedidos.UseVisualStyleBackColor = true;
            this.btnverpedidos.Click += new System.EventHandler(this.btnverpedidos_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(707, 452);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(358, 24);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(723, 29);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(107, 20);
            this.txtidcliente.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(723, 73);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(107, 20);
            this.txtcodigo.TabIndex = 11;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(720, 52);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(58, 17);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Codigo";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(724, 118);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(341, 20);
            this.txtcliente.TabIndex = 13;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(721, 97);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(58, 17);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Cliente";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(724, 160);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(341, 20);
            this.txtdireccion.TabIndex = 15;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(721, 139);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(76, 17);
            this.lbl4.TabIndex = 14;
            this.lbl4.Text = "Direccion";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(725, 204);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(341, 20);
            this.txttelefono.TabIndex = 17;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(722, 183);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(72, 17);
            this.lbl5.TabIndex = 16;
            this.lbl5.Text = "Telefono";
            // 
            // txtsaldo
            // 
            this.txtsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldo.Location = new System.Drawing.Point(725, 249);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(226, 53);
            this.txtsaldo.TabIndex = 19;
            this.txtsaldo.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(722, 228);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(49, 17);
            this.lbl6.TabIndex = 18;
            this.lbl6.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Criterio";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NOMBRE",
            "AREA"});
            this.comboBox1.Location = new System.Drawing.Point(557, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Image = global::Deposito.Properties.Resources.Actions_edit_clear_icon;
            this.button2.Location = new System.Drawing.Point(520, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Deposito.Properties.Resources.Magnifying_Glass_icon;
            this.button3.Location = new System.Drawing.Point(492, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txttotalsaldos
            // 
            this.txttotalsaldos.BackColor = System.Drawing.Color.Blue;
            this.txttotalsaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalsaldos.ForeColor = System.Drawing.Color.Yellow;
            this.txttotalsaldos.Location = new System.Drawing.Point(445, 432);
            this.txttotalsaldos.Name = "txttotalsaldos";
            this.txttotalsaldos.Size = new System.Drawing.Size(256, 44);
            this.txttotalsaldos.TabIndex = 29;
            this.txttotalsaldos.Text = "0.00";
            this.txttotalsaldos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Image = global::Deposito.Properties.Resources.prints;
            this.button4.Location = new System.Drawing.Point(969, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 53);
            this.button4.TabIndex = 30;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(707, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(358, 24);
            this.button5.TabIndex = 31;
            this.button5.Text = "Imprimir hoja para autoventa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmCarteraClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 488);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txttotalsaldos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnverpedidos);
            this.Controls.Add(this.btnabonoasaldo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Name = "frmCarteraClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartera de  Clientes";
            this.Load += new System.EventHandler(this.frmCarteraClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcli;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.Button btnabonoasaldo;
        private System.Windows.Forms.Button btnverpedidos;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txttotalsaldos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}