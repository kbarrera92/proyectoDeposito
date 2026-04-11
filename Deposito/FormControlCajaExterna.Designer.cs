namespace Deposito
{
    partial class FormControlCajaExterna
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxPorRegistro = new System.Windows.Forms.CheckBox();
            this.checkBoxPorDia = new System.Windows.Forms.CheckBox();
            this.numericUpDownPorRegistro = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPorDia = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorDia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Historial sin agrupar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(16, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 405);
            this.tabControl1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(857, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownPorRegistro);
            this.groupBox1.Controls.Add(this.checkBoxPorRegistro);
            this.groupBox1.Location = new System.Drawing.Point(395, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por registro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownPorDia);
            this.groupBox2.Controls.Add(this.checkBoxPorDia);
            this.groupBox2.Location = new System.Drawing.Point(588, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 42);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por días";
            // 
            // checkBoxPorRegistro
            // 
            this.checkBoxPorRegistro.AutoSize = true;
            this.checkBoxPorRegistro.Checked = true;
            this.checkBoxPorRegistro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPorRegistro.Location = new System.Drawing.Point(7, 20);
            this.checkBoxPorRegistro.Name = "checkBoxPorRegistro";
            this.checkBoxPorRegistro.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPorRegistro.TabIndex = 0;
            this.checkBoxPorRegistro.UseVisualStyleBackColor = true;
            this.checkBoxPorRegistro.CheckedChanged += new System.EventHandler(this.checkBoxPorRegistro_CheckedChanged);
            // 
            // checkBoxPorDia
            // 
            this.checkBoxPorDia.AutoSize = true;
            this.checkBoxPorDia.Location = new System.Drawing.Point(6, 20);
            this.checkBoxPorDia.Name = "checkBoxPorDia";
            this.checkBoxPorDia.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPorDia.TabIndex = 1;
            this.checkBoxPorDia.UseVisualStyleBackColor = true;
            this.checkBoxPorDia.CheckedChanged += new System.EventHandler(this.checkBoxPorDia_CheckedChanged);
            // 
            // numericUpDownPorRegistro
            // 
            this.numericUpDownPorRegistro.Location = new System.Drawing.Point(34, 16);
            this.numericUpDownPorRegistro.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPorRegistro.Name = "numericUpDownPorRegistro";
            this.numericUpDownPorRegistro.Size = new System.Drawing.Size(104, 20);
            this.numericUpDownPorRegistro.TabIndex = 1;
            this.numericUpDownPorRegistro.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownPorDia
            // 
            this.numericUpDownPorDia.Location = new System.Drawing.Point(34, 16);
            this.numericUpDownPorDia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPorDia.Name = "numericUpDownPorDia";
            this.numericUpDownPorDia.Size = new System.Drawing.Size(104, 20);
            this.numericUpDownPorDia.TabIndex = 2;
            this.numericUpDownPorDia.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(775, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormControlCajaExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormControlCajaExterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de saldos de caja";
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPorDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownPorRegistro;
        private System.Windows.Forms.CheckBox checkBoxPorRegistro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownPorDia;
        private System.Windows.Forms.CheckBox checkBoxPorDia;
        private System.Windows.Forms.Button button1;
    }
}