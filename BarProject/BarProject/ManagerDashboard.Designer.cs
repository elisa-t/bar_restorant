namespace BarProject
{
    partial class ManagerDashboard
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
            this.ShitjeButton = new System.Windows.Forms.Button();
            this.FurnizimButton = new System.Windows.Forms.Button();
            this.TavolineButton = new System.Windows.Forms.Button();
            this.FurnitorButton = new System.Windows.Forms.Button();
            this.ProduktButton = new System.Windows.Forms.Button();
            this.KategoriButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CredentialLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShitjeButton
            // 
            this.ShitjeButton.Location = new System.Drawing.Point(434, 225);
            this.ShitjeButton.Name = "ShitjeButton";
            this.ShitjeButton.Size = new System.Drawing.Size(140, 85);
            this.ShitjeButton.TabIndex = 11;
            this.ShitjeButton.Text = "SHITJE";
            this.ShitjeButton.UseVisualStyleBackColor = true;
            this.ShitjeButton.Click += new System.EventHandler(this.ShitjeButton_Click);
            // 
            // FurnizimButton
            // 
            this.FurnizimButton.Location = new System.Drawing.Point(91, 225);
            this.FurnizimButton.Name = "FurnizimButton";
            this.FurnizimButton.Size = new System.Drawing.Size(140, 85);
            this.FurnizimButton.TabIndex = 10;
            this.FurnizimButton.Text = "FURNIZIM";
            this.FurnizimButton.UseVisualStyleBackColor = true;
            this.FurnizimButton.Click += new System.EventHandler(this.FurnizimButton_Click);
            // 
            // TavolineButton
            // 
            this.TavolineButton.Location = new System.Drawing.Point(262, 225);
            this.TavolineButton.Name = "TavolineButton";
            this.TavolineButton.Size = new System.Drawing.Size(140, 85);
            this.TavolineButton.TabIndex = 9;
            this.TavolineButton.Text = "TAVOLINA";
            this.TavolineButton.UseVisualStyleBackColor = true;
            this.TavolineButton.Click += new System.EventHandler(this.TavolineButton_Click);
            // 
            // FurnitorButton
            // 
            this.FurnitorButton.Location = new System.Drawing.Point(434, 72);
            this.FurnitorButton.Name = "FurnitorButton";
            this.FurnitorButton.Size = new System.Drawing.Size(140, 85);
            this.FurnitorButton.TabIndex = 8;
            this.FurnitorButton.Text = "FURNITOR";
            this.FurnitorButton.UseVisualStyleBackColor = true;
            this.FurnitorButton.Click += new System.EventHandler(this.FurnitorButton_Click);
            // 
            // ProduktButton
            // 
            this.ProduktButton.Location = new System.Drawing.Point(262, 72);
            this.ProduktButton.Name = "ProduktButton";
            this.ProduktButton.Size = new System.Drawing.Size(140, 85);
            this.ProduktButton.TabIndex = 7;
            this.ProduktButton.Text = "PRODUKT";
            this.ProduktButton.UseVisualStyleBackColor = true;
            this.ProduktButton.Click += new System.EventHandler(this.ProduktButton_Click);
            // 
            // KategoriButton
            // 
            this.KategoriButton.Location = new System.Drawing.Point(91, 72);
            this.KategoriButton.Name = "KategoriButton";
            this.KategoriButton.Size = new System.Drawing.Size(140, 85);
            this.KategoriButton.TabIndex = 6;
            this.KategoriButton.Text = "KATEGORI";
            this.KategoriButton.UseVisualStyleBackColor = true;
            this.KategoriButton.Click += new System.EventHandler(this.KategoriButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(506, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(114, 41);
            this.LogoutButton.TabIndex = 12;
            this.LogoutButton.Text = "DIL";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CredentialLabel
            // 
            this.CredentialLabel.AutoSize = true;
            this.CredentialLabel.Location = new System.Drawing.Point(401, 26);
            this.CredentialLabel.Name = "CredentialLabel";
            this.CredentialLabel.Size = new System.Drawing.Size(35, 13);
            this.CredentialLabel.TabIndex = 13;
            this.CredentialLabel.Text = "label1";
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 382);
            this.Controls.Add(this.CredentialLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ShitjeButton);
            this.Controls.Add(this.FurnizimButton);
            this.Controls.Add(this.TavolineButton);
            this.Controls.Add(this.FurnitorButton);
            this.Controls.Add(this.ProduktButton);
            this.Controls.Add(this.KategoriButton);
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShitjeButton;
        private System.Windows.Forms.Button FurnizimButton;
        private System.Windows.Forms.Button TavolineButton;
        private System.Windows.Forms.Button FurnitorButton;
        private System.Windows.Forms.Button ProduktButton;
        private System.Windows.Forms.Button KategoriButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label CredentialLabel;
    }
}