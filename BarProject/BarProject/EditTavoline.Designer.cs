namespace BarProject
{
    partial class EditTavoline
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
            this.EditEmriBox = new System.Windows.Forms.TextBox();
            this.EditTavolinaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditEmriBox
            // 
            this.EditEmriBox.Location = new System.Drawing.Point(98, 44);
            this.EditEmriBox.Name = "EditEmriBox";
            this.EditEmriBox.Size = new System.Drawing.Size(124, 20);
            this.EditEmriBox.TabIndex = 2;
            // 
            // EditTavolinaButton
            // 
            this.EditTavolinaButton.Location = new System.Drawing.Point(70, 132);
            this.EditTavolinaButton.Name = "EditTavolinaButton";
            this.EditTavolinaButton.Size = new System.Drawing.Size(86, 43);
            this.EditTavolinaButton.TabIndex = 3;
            this.EditTavolinaButton.Text = "OK";
            this.EditTavolinaButton.UseVisualStyleBackColor = true;
            this.EditTavolinaButton.Click += new System.EventHandler(this.EditTavolinaButton_Click);
            // 
            // EditTavoline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.EditTavolinaButton);
            this.Controls.Add(this.EditEmriBox);
            this.Controls.Add(this.label1);
            this.Name = "EditTavoline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Tavoline";
            this.Load += new System.EventHandler(this.EditTavoline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditEmriBox;
        private System.Windows.Forms.Button EditTavolinaButton;
    }
}