namespace BarProject
{
    partial class ShtoKamarierForn
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
            this.TavolinaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KamarieriComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ShtoKamarierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tavolina";
            // 
            // TavolinaLabel
            // 
            this.TavolinaLabel.AutoSize = true;
            this.TavolinaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TavolinaLabel.Location = new System.Drawing.Point(128, 42);
            this.TavolinaLabel.Name = "TavolinaLabel";
            this.TavolinaLabel.Size = new System.Drawing.Size(35, 13);
            this.TavolinaLabel.TabIndex = 1;
            this.TavolinaLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kamarieri";
            // 
            // KamarieriComboBox
            // 
            this.KamarieriComboBox.FormattingEnabled = true;
            this.KamarieriComboBox.Location = new System.Drawing.Point(131, 93);
            this.KamarieriComboBox.Name = "KamarieriComboBox";
            this.KamarieriComboBox.Size = new System.Drawing.Size(117, 21);
            this.KamarieriComboBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(27, 166);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(92, 44);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ShtoKamarierButton
            // 
            this.ShtoKamarierButton.Location = new System.Drawing.Point(146, 166);
            this.ShtoKamarierButton.Name = "ShtoKamarierButton";
            this.ShtoKamarierButton.Size = new System.Drawing.Size(92, 44);
            this.ShtoKamarierButton.TabIndex = 5;
            this.ShtoKamarierButton.Text = "RUAJ";
            this.ShtoKamarierButton.UseVisualStyleBackColor = true;
            this.ShtoKamarierButton.Click += new System.EventHandler(this.ShtoKamarierButton_Click);
            // 
            // ShtoKamarierForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 251);
            this.Controls.Add(this.ShtoKamarierButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.KamarieriComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TavolinaLabel);
            this.Controls.Add(this.label1);
            this.Name = "ShtoKamarierForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto Kamarier";
            this.Load += new System.EventHandler(this.ShtoKamarierForn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TavolinaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox KamarieriComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ShtoKamarierButton;
    }
}