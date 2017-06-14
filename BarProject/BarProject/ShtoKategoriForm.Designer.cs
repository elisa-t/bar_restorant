namespace BarProject
{
    partial class ShtoKategoriForm
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
            this.EmriBox = new System.Windows.Forms.TextBox();
            this.PershkrimBox = new System.Windows.Forms.RichTextBox();
            this.ShtoKategoriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pershkrimi";
            // 
            // EmriBox
            // 
            this.EmriBox.Location = new System.Drawing.Point(131, 26);
            this.EmriBox.Name = "EmriBox";
            this.EmriBox.Size = new System.Drawing.Size(146, 20);
            this.EmriBox.TabIndex = 3;
            // 
            // PershkrimBox
            // 
            this.PershkrimBox.Location = new System.Drawing.Point(131, 75);
            this.PershkrimBox.Name = "PershkrimBox";
            this.PershkrimBox.Size = new System.Drawing.Size(146, 70);
            this.PershkrimBox.TabIndex = 4;
            this.PershkrimBox.Text = "";
            // 
            // ShtoKategoriButton
            // 
            this.ShtoKategoriButton.Location = new System.Drawing.Point(71, 189);
            this.ShtoKategoriButton.Name = "ShtoKategoriButton";
            this.ShtoKategoriButton.Size = new System.Drawing.Size(147, 54);
            this.ShtoKategoriButton.TabIndex = 7;
            this.ShtoKategoriButton.Text = "Shto Kategori";
            this.ShtoKategoriButton.UseVisualStyleBackColor = true;
            this.ShtoKategoriButton.Click += new System.EventHandler(this.ShtoKategoriButton_Click);
            // 
            // ShtoKategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 273);
            this.Controls.Add(this.ShtoKategoriButton);
            this.Controls.Add(this.PershkrimBox);
            this.Controls.Add(this.EmriBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShtoKategoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto Kategori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmriBox;
        private System.Windows.Forms.RichTextBox PershkrimBox;
        private System.Windows.Forms.Button ShtoKategoriButton;
    }
}