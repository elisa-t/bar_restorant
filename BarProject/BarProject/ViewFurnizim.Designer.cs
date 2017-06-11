namespace BarProject
{
    partial class ViewFurnizim
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
            this.fatureLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.furnitorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.furnizimDataGrid = new System.Windows.Forms.DataGridView();
            this.mbyllButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmerProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SasiProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmimProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.furnizimDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NR FATURE";
            // 
            // fatureLabel
            // 
            this.fatureLabel.AutoSize = true;
            this.fatureLabel.Location = new System.Drawing.Point(58, 38);
            this.fatureLabel.Name = "fatureLabel";
            this.fatureLabel.Size = new System.Drawing.Size(35, 13);
            this.fatureLabel.TabIndex = 1;
            this.fatureLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FURNITOR";
            // 
            // furnitorLabel
            // 
            this.furnitorLabel.AutoSize = true;
            this.furnitorLabel.Location = new System.Drawing.Point(58, 97);
            this.furnitorLabel.Name = "furnitorLabel";
            this.furnitorLabel.Size = new System.Drawing.Size(35, 13);
            this.furnitorLabel.TabIndex = 3;
            this.furnitorLabel.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATA FURNIZIM";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(234, 38);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(35, 13);
            this.dataLabel.TabIndex = 5;
            this.dataLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(237, 97);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "label5";
            // 
            // furnizimDataGrid
            // 
            this.furnizimDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.furnizimDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnizimDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EmerProdukt,
            this.SasiProdukt,
            this.CmimProdukt,
            this.TotalProdukt});
            this.furnizimDataGrid.Location = new System.Drawing.Point(34, 140);
            this.furnizimDataGrid.Name = "furnizimDataGrid";
            this.furnizimDataGrid.Size = new System.Drawing.Size(557, 166);
            this.furnizimDataGrid.TabIndex = 8;
            // 
            // mbyllButton
            // 
            this.mbyllButton.Location = new System.Drawing.Point(494, 341);
            this.mbyllButton.Name = "mbyllButton";
            this.mbyllButton.Size = new System.Drawing.Size(97, 44);
            this.mbyllButton.TabIndex = 9;
            this.mbyllButton.Text = "MBYLL";
            this.mbyllButton.UseVisualStyleBackColor = true;
            this.mbyllButton.Click += new System.EventHandler(this.mbyllButton_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            // ViewFurnizim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 416);
            this.Controls.Add(this.mbyllButton);
            this.Controls.Add(this.furnizimDataGrid);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.furnitorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fatureLabel);
            this.Controls.Add(this.label1);
            this.Name = "ViewFurnizim";
            this.Text = "Furnizim";
            this.Load += new System.EventHandler(this.ViewFurnizim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.furnizimDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fatureLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label furnitorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridView furnizimDataGrid;
        private System.Windows.Forms.Button mbyllButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmerProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SasiProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmimProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProdukt;
    }
}