namespace Deposito
{
    partial class frmRepartidores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidrepartidor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelrepartidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombrerepartidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.Location = new System.Drawing.Point(749, 311);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnnuevo.FlatAppearance.BorderSize = 2;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(339, 310);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(131, 52);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnregistrar.FlatAppearance.BorderSize = 2;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(476, 310);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(131, 52);
            this.btnregistrar.TabIndex = 7;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btneliminar.FlatAppearance.BorderSize = 2;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(613, 311);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(131, 52);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 278);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtidrepartidor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttelrepartidor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnombrerepartidor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 349);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del repartidor";
            // 
            // txtidrepartidor
            // 
            this.txtidrepartidor.Location = new System.Drawing.Point(22, 60);
            this.txtidrepartidor.Name = "txtidrepartidor";
            this.txtidrepartidor.ReadOnly = true;
            this.txtidrepartidor.Size = new System.Drawing.Size(126, 30);
            this.txtidrepartidor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id:";
            // 
            // txttelrepartidor
            // 
            this.txttelrepartidor.Location = new System.Drawing.Point(17, 199);
            this.txttelrepartidor.Name = "txttelrepartidor";
            this.txttelrepartidor.Size = new System.Drawing.Size(249, 30);
            this.txttelrepartidor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefono:";
            // 
            // txtnombrerepartidor
            // 
            this.txtnombrerepartidor.Location = new System.Drawing.Point(17, 126);
            this.txtnombrerepartidor.Name = "txtnombrerepartidor";
            this.txtnombrerepartidor.Size = new System.Drawing.Size(251, 30);
            this.txtnombrerepartidor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRepartidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 373);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRepartidores";
            this.Text = "Repartidores";
            this.Load += new System.EventHandler(this.frmRepartidores_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnregistrar, 0);
            this.Controls.SetChildIndex(this.btnnuevo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtidrepartidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttelrepartidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombrerepartidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}