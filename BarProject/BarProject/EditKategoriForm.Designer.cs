namespace BarProject
{
    partial class EditKategoriForm
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
            this.EditKategoriButton = new System.Windows.Forms.Button();
            this.ZgjidhFotoButton = new System.Windows.Forms.Button();
            this.FotoBox = new System.Windows.Forms.PictureBox();
            this.PershkrimBox = new System.Windows.Forms.RichTextBox();
            this.EmriBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EditKategoriButton
            // 
            this.EditKategoriButton.Location = new System.Drawing.Point(63, 264);
            this.EditKategoriButton.Name = "EditKategoriButton";
            this.EditKategoriButton.Size = new System.Drawing.Size(147, 54);
            this.EditKategoriButton.TabIndex = 15;
            this.EditKategoriButton.Text = "Modifiko Kategori";
            this.EditKategoriButton.UseVisualStyleBackColor = true;
            this.EditKategoriButton.Click += new System.EventHandler(this.EditKategoriButton_Click);
            // 
            // ZgjidhFotoButton
            // 
            this.ZgjidhFotoButton.Location = new System.Drawing.Point(33, 200);
            this.ZgjidhFotoButton.Name = "ZgjidhFotoButton";
            this.ZgjidhFotoButton.Size = new System.Drawing.Size(75, 23);
            this.ZgjidhFotoButton.TabIndex = 14;
            this.ZgjidhFotoButton.Text = "Zgjidh Foto";
            this.ZgjidhFotoButton.UseVisualStyleBackColor = true;
            this.ZgjidhFotoButton.Click += new System.EventHandler(this.ZgjidhFotoButton_Click);
            // 
            // FotoBox
            // 
            this.FotoBox.Location = new System.Drawing.Point(125, 174);
            this.FotoBox.Name = "FotoBox";
            this.FotoBox.Size = new System.Drawing.Size(138, 65);
            this.FotoBox.TabIndex = 13;
            this.FotoBox.TabStop = false;
            // 
            // PershkrimBox
            // 
            this.PershkrimBox.Location = new System.Drawing.Point(125, 84);
            this.PershkrimBox.Name = "PershkrimBox";
            this.PershkrimBox.Size = new System.Drawing.Size(138, 70);
            this.PershkrimBox.TabIndex = 12;
            this.PershkrimBox.Text = "";
            // 
            // EmriBox
            // 
            this.EmriBox.Location = new System.Drawing.Point(125, 35);
            this.EmriBox.Name = "EmriBox";
            this.EmriBox.Size = new System.Drawing.Size(138, 20);
            this.EmriBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Foto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pershkrimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Emri";
            // 
            // EditKategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.EditKategoriButton);
            this.Controls.Add(this.ZgjidhFotoButton);
            this.Controls.Add(this.FotoBox);
            this.Controls.Add(this.PershkrimBox);
            this.Controls.Add(this.EmriBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditKategoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Kategori";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditKategoriForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditKategoriButton;
        private System.Windows.Forms.Button ZgjidhFotoButton;
        private System.Windows.Forms.PictureBox FotoBox;
        private System.Windows.Forms.RichTextBox PershkrimBox;
        private System.Windows.Forms.TextBox EmriBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}