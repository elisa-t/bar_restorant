namespace BarProject
{
    partial class ViewKategoriForm
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
            this.EmriBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FotoBox = new System.Windows.Forms.PictureBox();
            this.PershkrimiBox = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emri";
            // 
            // EmriBox
            // 
            this.EmriBox.AutoSize = true;
            this.EmriBox.Location = new System.Drawing.Point(127, 31);
            this.EmriBox.Name = "EmriBox";
            this.EmriBox.Size = new System.Drawing.Size(35, 13);
            this.EmriBox.TabIndex = 1;
            this.EmriBox.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pershkrimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Foto";
            // 
            // FotoBox
            // 
            this.FotoBox.Location = new System.Drawing.Point(53, 121);
            this.FotoBox.Name = "FotoBox";
            this.FotoBox.Size = new System.Drawing.Size(175, 95);
            this.FotoBox.TabIndex = 4;
            this.FotoBox.TabStop = false;
            // 
            // PershkrimiBox
            // 
            this.PershkrimiBox.AutoSize = true;
            this.PershkrimiBox.Location = new System.Drawing.Point(127, 75);
            this.PershkrimiBox.Name = "PershkrimiBox";
            this.PershkrimiBox.Size = new System.Drawing.Size(35, 13);
            this.PershkrimiBox.TabIndex = 5;
            this.PershkrimiBox.Text = "label5";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(83, 251);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(96, 48);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Mbyll";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ViewKategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 321);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PershkrimiBox);
            this.Controls.Add(this.FotoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmriBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewKategoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewKategoriForm";
            this.Load += new System.EventHandler(this.ViewKategoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmriBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox FotoBox;
        private System.Windows.Forms.Label PershkrimiBox;
        private System.Windows.Forms.Button CloseButton;
    }
}