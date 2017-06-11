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
            this.tavolinatGroupBox.SuspendLayout();
            this.kategoriGroupBox.SuspendLayout();
            this.produktetGroupBox.SuspendLayout();
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
            this.CredentialLabel.Location = new System.Drawing.Point(656, 39);
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
            // 
            // KamarierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 498);
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

    }
}