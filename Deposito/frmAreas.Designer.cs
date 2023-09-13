namespace Deposito
{
    partial class frmAreas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnombrearea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtiduser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigoarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.Location = new System.Drawing.Point(748, 250);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtnombrearea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtiduser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcodigoarea);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de las Áreas";
            // 
            // txtnombrearea
            // 
            this.txtnombrearea.Location = new System.Drawing.Point(22, 198);
            this.txtnombrearea.Name = "txtnombrearea";
            this.txtnombrearea.Size = new System.Drawing.Size(251, 30);
            this.txtnombrearea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // txtiduser
            // 
            this.txtiduser.Location = new System.Drawing.Point(22, 60);
            this.txtiduser.Name = "txtiduser";
            this.txtiduser.ReadOnly = true;
            this.txtiduser.Size = new System.Drawing.Size(126, 30);
            this.txtiduser.TabIndex = 1;
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
            // txtcodigoarea
            // 
            this.txtcodigoarea.Location = new System.Drawing.Point(17, 126);
            this.txtcodigoarea.Name = "txtcodigoarea";
            this.txtcodigoarea.Size = new System.Drawing.Size(251, 30);
            this.txtcodigoarea.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 218);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnnuevo.FlatAppearance.BorderSize = 2;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(333, 249);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(131, 52);
            this.btnnuevo.TabIndex = 7;
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
            this.btnregistrar.Location = new System.Drawing.Point(470, 249);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(131, 52);
            this.btnregistrar.TabIndex = 5;
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
            this.btneliminar.Location = new System.Drawing.Point(607, 250);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(131, 52);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 313);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAreas";
            this.Text = "Áreas de reparto";
            this.Load += new System.EventHandler(this.frmAreas_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnregistrar, 0);
            this.Controls.SetChildIndex(this.btnnuevo, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtiduser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigoarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnombrearea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}