namespace BarProject
{
    partial class ShtoFurnizim
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
            this.faturaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FurnitorComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.shtoButton = new System.Windows.Forms.Button();
            this.cmimiBox = new System.Windows.Forms.TextBox();
            this.sasiaBox = new System.Windows.Forms.TextBox();
            this.emriBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.furnizimiDataGrid = new System.Windows.Forms.DataGridView();
            this.EmerProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SasiProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmimProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ruajButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnizimiDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura";
            // 
            // faturaBox
            // 
            this.faturaBox.Location = new System.Drawing.Point(101, 26);
            this.faturaBox.Name = "faturaBox";
            this.faturaBox.Size = new System.Drawing.Size(139, 20);
            this.faturaBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Furnitor";
            // 
            // FurnitorComboBox
            // 
            this.FurnitorComboBox.FormattingEnabled = true;
            this.FurnitorComboBox.Location = new System.Drawing.Point(101, 60);
            this.FurnitorComboBox.Name = "FurnitorComboBox";
            this.FurnitorComboBox.Size = new System.Drawing.Size(139, 21);
            this.FurnitorComboBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.shtoButton);
            this.groupBox1.Controls.Add(this.cmimiBox);
            this.groupBox1.Controls.Add(this.sasiaBox);
            this.groupBox1.Controls.Add(this.emriBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(33, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 229);
            this.groupBox1.TabIndex = 4;
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
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // shtoButton
            // 
            this.shtoButton.Location = new System.Drawing.Point(110, 179);
            this.shtoButton.Name = "shtoButton";
            this.shtoButton.Size = new System.Drawing.Size(63, 28);
            this.shtoButton.TabIndex = 6;
            this.shtoButton.Text = "SHTO";
            this.shtoButton.UseVisualStyleBackColor = true;
            this.shtoButton.Click += new System.EventHandler(this.shtoButton_Click);
            // 
            // cmimiBox
            // 
            this.cmimiBox.Location = new System.Drawing.Point(26, 144);
            this.cmimiBox.Name = "cmimiBox";
            this.cmimiBox.Size = new System.Drawing.Size(159, 20);
            this.cmimiBox.TabIndex = 5;
            // 
            // sasiaBox
            // 
            this.sasiaBox.Location = new System.Drawing.Point(26, 89);
            this.sasiaBox.Name = "sasiaBox";
            this.sasiaBox.Size = new System.Drawing.Size(159, 20);
            this.sasiaBox.TabIndex = 4;
            // 
            // emriBox
            // 
            this.emriBox.Location = new System.Drawing.Point(26, 37);
            this.emriBox.Name = "emriBox";
            this.emriBox.Size = new System.Drawing.Size(159, 20);
            this.emriBox.TabIndex = 3;
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
            // furnizimiDataGrid
            // 
            this.furnizimiDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.furnizimiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnizimiDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmerProdukt,
            this.SasiProdukt,
            this.CmimProdukt,
            this.TotalProdukt,
            this.Delete});
            this.furnizimiDataGrid.Location = new System.Drawing.Point(312, 33);
            this.furnizimiDataGrid.Name = "furnizimiDataGrid";
            this.furnizimiDataGrid.Size = new System.Drawing.Size(313, 228);
            this.furnizimiDataGrid.TabIndex = 5;
            this.furnizimiDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.furnizimiDataGrid_CellContentClick);
            // 
            // EmerProdukt
            // 
            this.EmerProdukt.HeaderText = "Emri";
            this.EmerProdukt.Name = "EmerProdukt";
            this.EmerProdukt.ReadOnly = true;
            // 
            // SasiProdukt
            // 
            this.SasiProdukt.HeaderText = "Sasia";
            this.SasiProdukt.Name = "SasiProdukt";
            this.SasiProdukt.ReadOnly = true;
            // 
            // CmimProdukt
            // 
            this.CmimProdukt.HeaderText = "Cmimi";
            this.CmimProdukt.Name = "CmimProdukt";
            this.CmimProdukt.ReadOnly = true;
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
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(415, 315);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 35);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ruajButton
            // 
            this.ruajButton.Location = new System.Drawing.Point(534, 315);
            this.ruajButton.Name = "ruajButton";
            this.ruajButton.Size = new System.Drawing.Size(91, 35);
            this.ruajButton.TabIndex = 7;
            this.ruajButton.Text = "RUAJ";
            this.ruajButton.UseVisualStyleBackColor = true;
            this.ruajButton.Click += new System.EventHandler(this.ruajButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "TOTAL";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(376, 282);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(28, 13);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "0.00";
            // 
            // ShtoFurnizim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 376);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ruajButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.furnizimiDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FurnitorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.faturaBox);
            this.Controls.Add(this.label1);
            this.Name = "ShtoFurnizim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto Furnizim";
            this.Load += new System.EventHandler(this.ShtoFurnizim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnizimiDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox faturaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FurnitorComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView furnizimiDataGrid;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button shtoButton;
        private System.Windows.Forms.TextBox cmimiBox;
        private System.Windows.Forms.TextBox sasiaBox;
        private System.Windows.Forms.TextBox emriBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmerProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SasiProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmimProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProdukt;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button ruajButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalLabel;
    }
}