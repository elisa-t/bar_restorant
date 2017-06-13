namespace BarProject
{
    partial class ShtoTavolinaForm
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
            this.EmritextBox = new System.Windows.Forms.TextBox();
            this.shtotavolinaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmritextBox
            // 
            this.EmritextBox.Location = new System.Drawing.Point(98, 45);
            this.EmritextBox.Name = "EmritextBox";
            this.EmritextBox.Size = new System.Drawing.Size(124, 20);
            this.EmritextBox.TabIndex = 1;
            // 
            // shtotavolinaButton
            // 
            this.shtotavolinaButton.Location = new System.Drawing.Point(58, 126);
            this.shtotavolinaButton.Name = "shtotavolinaButton";
            this.shtotavolinaButton.Size = new System.Drawing.Size(86, 43);
            this.shtotavolinaButton.TabIndex = 2;
            this.shtotavolinaButton.Text = "SHTO";
            this.shtotavolinaButton.UseVisualStyleBackColor = true;
            this.shtotavolinaButton.Click += new System.EventHandler(this.shtotavolinaButton_Click);
            // 
            // ShtoTavolinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.shtotavolinaButton);
            this.Controls.Add(this.EmritextBox);
            this.Controls.Add(this.label1);
            this.Name = "ShtoTavolinaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto Tavolina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmritextBox;
        private System.Windows.Forms.Button shtotavolinaButton;

    }
}