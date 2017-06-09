namespace BarProject
{
    partial class EditFurnizim
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
            this.ruajButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.shtoButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FurnitorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.faturaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmerProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SasiProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmimProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruajButton
            // 
            this.ruajButton.Location = new System.Drawing.Point(546, 310);
            this.ruajButton.Name = "ruajButton";
            this.ruajButton.Size = new System.Drawing.Size(91, 35);
            this.ruajButton.TabIndex = 15;
            this.ruajButton.Text = "RUAJ";
            this.ruajButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(427, 310);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 35);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmerProdukt,
            this.SasiProdukt,
            this.CmimProdukt,
            this.TotalProdukt,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(324, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 259);
            this.dataGridView1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.shtoButton);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(45, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 229);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "...";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(26, 179);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(63, 27);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // shtoButton
            // 
            this.shtoButton.Location = new System.Drawing.Point(110, 179);
            this.shtoButton.Name = "shtoButton";
            this.shtoButton.Size = new System.Drawing.Size(63, 28);
            this.shtoButton.TabIndex = 6;
            this.shtoButton.Text = "SHTO";
            this.shtoButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cmimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sasia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Emri";
            // 
            // FurnitorComboBox
            // 
            this.FurnitorComboBox.FormattingEnabled = true;
            this.FurnitorComboBox.Location = new System.Drawing.Point(113, 55);
            this.FurnitorComboBox.Name = "FurnitorComboBox";
            this.FurnitorComboBox.Size = new System.Drawing.Size(139, 21);
            this.FurnitorComboBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Furnitor";
            // 
            // faturaBox
            // 
            this.faturaBox.Location = new System.Drawing.Point(113, 21);
            this.faturaBox.Name = "faturaBox";
            this.faturaBox.Size = new System.Drawing.Size(139, 20);
            this.faturaBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fatura";
            // 
            // EmerProdukt
            // 
            this.EmerProdukt.HeaderText = "Emri";
            this.EmerProdukt.Name = "EmerProdukt";
            // 
            // SasiProdukt
            // 
            this.SasiProdukt.HeaderText = "Sasia";
            this.SasiProdukt.Name = "SasiProdukt";
            // 
            // CmimProdukt
            // 
            this.CmimProdukt.HeaderText = "Cmimi";
            this.CmimProdukt.Name = "CmimProdukt";
            // 
            // TotalProdukt
            // 
            this.TotalProdukt.HeaderText = "Totali";
            this.TotalProdukt.Name = "TotalProdukt";
            this.TotalProdukt.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // EditFurnizim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 367);
            this.Controls.Add(this.ruajButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FurnitorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.faturaBox);
            this.Controls.Add(this.label1);
            this.Name = "EditFurnizim";
            this.Text = "Modifiko Furnizim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ruajButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmerProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SasiProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmimProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProdukt;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button shtoButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FurnitorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox faturaBox;
        private System.Windows.Forms.Label label1;
    }
}