namespace BarProject
{
    partial class KamarierDashboard
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
            this.tavolinatGroupBox = new System.Windows.Forms.GroupBox();
            this.tavolinatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.kategoriGroupBox = new System.Windows.Forms.GroupBox();
            this.kategoritePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.produktetGroupBox = new System.Windows.Forms.GroupBox();
            this.produktetPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CredentialLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.produkteDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmriProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmimProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SasiProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.tavolinatGroupBox.SuspendLayout();
            this.kategoriGroupBox.SuspendLayout();
            this.produktetGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produkteDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tavolinatGroupBox
            // 
            this.tavolinatGroupBox.Controls.Add(this.tavolinatPanel);
            this.tavolinatGroupBox.Location = new System.Drawing.Point(22, 25);
            this.tavolinatGroupBox.Name = "tavolinatGroupBox";
            this.tavolinatGroupBox.Size = new System.Drawing.Size(481, 136);
            this.tavolinatGroupBox.TabIndex = 0;
            this.tavolinatGroupBox.TabStop = false;
            this.tavolinatGroupBox.Text = "TAVOLINAT";
            // 
            // tavolinatPanel
            // 
            this.tavolinatPanel.Location = new System.Drawing.Point(7, 20);
            this.tavolinatPanel.Name = "tavolinatPanel";
            this.tavolinatPanel.Size = new System.Drawing.Size(468, 100);
            this.tavolinatPanel.TabIndex = 0;
            // 
            // kategoriGroupBox
            // 
            this.kategoriGroupBox.Controls.Add(this.kategoritePanel);
            this.kategoriGroupBox.Location = new System.Drawing.Point(22, 181);
            this.kategoriGroupBox.Name = "kategoriGroupBox";
            this.kategoriGroupBox.Size = new System.Drawing.Size(481, 123);
            this.kategoriGroupBox.TabIndex = 1;
            this.kategoriGroupBox.TabStop = false;
            this.kategoriGroupBox.Text = "KATEGORITE";
            // 
            // kategoritePanel
            // 
            this.kategoritePanel.Location = new System.Drawing.Point(6, 11);
            this.kategoritePanel.Name = "kategoritePanel";
            this.kategoritePanel.Size = new System.Drawing.Size(468, 100);
            this.kategoritePanel.TabIndex = 1;
            // 
            // produktetGroupBox
            // 
            this.produktetGroupBox.Controls.Add(this.produktetPanel);
            this.produktetGroupBox.Location = new System.Drawing.Point(22, 329);
            this.produktetGroupBox.Name = "produktetGroupBox";
            this.produktetGroupBox.Size = new System.Drawing.Size(481, 168);
            this.produktetGroupBox.TabIndex = 2;
            this.produktetGroupBox.TabStop = false;
            this.produktetGroupBox.Text = "PRODUKTET";
            // 
            // produktetPanel
            // 
            this.produktetPanel.Location = new System.Drawing.Point(6, 19);
            this.produktetPanel.Name = "produktetPanel";
            this.produktetPanel.Size = new System.Drawing.Size(468, 131);
            this.produktetPanel.TabIndex = 1;
            // 
            // CredentialLabel
            // 
            this.CredentialLabel.AutoSize = true;
            this.CredentialLabel.Location = new System.Drawing.Point(618, 39);
            this.CredentialLabel.Name = "CredentialLabel";
            this.CredentialLabel.Size = new System.Drawing.Size(35, 13);
            this.CredentialLabel.TabIndex = 15;
            this.CredentialLabel.Text = "label1";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(716, 25);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(114, 41);
            this.LogoutButton.TabIndex = 14;
            this.LogoutButton.Text = "DIL";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.produkteDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(509, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 347);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SHITJE";
            // 
            // produkteDataGrid
            // 
            this.produkteDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produkteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produkteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EmriProdukt,
            this.CmimProdukt,
            this.SasiProdukt,
            this.TotalProdukt,
            this.Delete});
            this.produkteDataGrid.Location = new System.Drawing.Point(7, 23);
            this.produkteDataGrid.Name = "produkteDataGrid";
            this.produkteDataGrid.Size = new System.Drawing.Size(328, 301);
            this.produkteDataGrid.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // EmriProdukt
            // 
            this.EmriProdukt.HeaderText = "Emri";
            this.EmriProdukt.Name = "EmriProdukt";
            this.EmriProdukt.ReadOnly = true;
            // 
            // CmimProdukt
            // 
            this.CmimProdukt.HeaderText = "Cmimi";
            this.CmimProdukt.Name = "CmimProdukt";
            this.CmimProdukt.ReadOnly = true;
            // 
            // SasiProdukt
            // 
            this.SasiProdukt.HeaderText = "Sasia";
            this.SasiProdukt.Name = "SasiProdukt";
            this.SasiProdukt.ReadOnly = true;
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
            this.Delete.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "TOTAL FATURE";
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(531, 454);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 18;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(676, 438);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(110, 36);
            this.checkoutButton.TabIndex = 19;
            this.checkoutButton.Text = "Mbyll Fature";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // KamarierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 498);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CredentialLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.produktetGroupBox);
            this.Controls.Add(this.kategoriGroupBox);
            this.Controls.Add(this.tavolinatGroupBox);
            this.Name = "KamarierDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.KamarierDashboard_Load_1);
            this.tavolinatGroupBox.ResumeLayout(false);
            this.kategoriGroupBox.ResumeLayout(false);
            this.produktetGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produkteDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tavolinatGroupBox;
        private System.Windows.Forms.FlowLayoutPanel tavolinatPanel;
        private System.Windows.Forms.GroupBox kategoriGroupBox;
        private System.Windows.Forms.FlowLayoutPanel kategoritePanel;
        private System.Windows.Forms.GroupBox produktetGroupBox;
        private System.Windows.Forms.FlowLayoutPanel produktetPanel;
        private System.Windows.Forms.Label CredentialLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView produkteDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmriProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmimProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SasiProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProdukt;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Button checkoutButton;

    }
}