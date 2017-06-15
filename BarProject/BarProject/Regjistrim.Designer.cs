namespace BarProject
{
    partial class Regjistrim
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmriBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.RoliBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.RegjistrohuButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regjsitrohu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Roli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // EmriBox
            // 
            this.EmriBox.Location = new System.Drawing.Point(58, 75);
            this.EmriBox.Name = "EmriBox";
            this.EmriBox.Size = new System.Drawing.Size(163, 20);
            this.EmriBox.TabIndex = 5;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(60, 124);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(161, 20);
            this.EmailBox.TabIndex = 6;
            // 
            // RoliBox
            // 
            this.RoliBox.Location = new System.Drawing.Point(58, 178);
            this.RoliBox.Name = "RoliBox";
            this.RoliBox.Size = new System.Drawing.Size(163, 20);
            this.RoliBox.TabIndex = 7;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(58, 227);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(163, 20);
            this.PasswordBox.TabIndex = 8;
            // 
            // RegjistrohuButton
            // 
            this.RegjistrohuButton.Location = new System.Drawing.Point(12, 283);
            this.RegjistrohuButton.Name = "RegjistrohuButton";
            this.RegjistrohuButton.Size = new System.Drawing.Size(105, 35);
            this.RegjistrohuButton.TabIndex = 9;
            this.RegjistrohuButton.Text = "Regjistrohu";
            this.RegjistrohuButton.UseVisualStyleBackColor = true;
            this.RegjistrohuButton.Click += new System.EventHandler(this.RegjistrohuButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(140, 283);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 35);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Regjistrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.RegjistrohuButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.RoliBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.EmriBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Regjistrim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regjistrim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regjistrim_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmriBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox RoliBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button RegjistrohuButton;
        private System.Windows.Forms.Button cancelButton;
    }
}