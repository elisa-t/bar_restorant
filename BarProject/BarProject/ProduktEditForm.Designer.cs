namespace BarProject
{
    partial class ProduktEditForm
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
            this.ShtoProduktButton = new System.Windows.Forms.Button();
            this.ProductDescriptionRBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmimiProduktBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmerProduktBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShtoProduktButton
            // 
            this.ShtoProduktButton.Location = new System.Drawing.Point(59, 272);
            this.ShtoProduktButton.Name = "ShtoProduktButton";
            this.ShtoProduktButton.Size = new System.Drawing.Size(146, 40);
            this.ShtoProduktButton.TabIndex = 34;
            this.ShtoProduktButton.Text = "Modifiko";
            this.ShtoProduktButton.UseVisualStyleBackColor = true;
            this.ShtoProduktButton.Click += new System.EventHandler(this.EditProduktButton_Click);
            // 
            // ProductDescriptionRBox
            // 
            this.ProductDescriptionRBox.Location = new System.Drawing.Point(147, 166);
            this.ProductDescriptionRBox.Name = "ProductDescriptionRBox";
            this.ProductDescriptionRBox.Size = new System.Drawing.Size(146, 73);
            this.ProductDescriptionRBox.TabIndex = 30;
            this.ProductDescriptionRBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Pershkrimi";
            // 
            // KategoriaComboBox
            // 
            this.KategoriaComboBox.FormattingEnabled = true;
            this.KategoriaComboBox.Location = new System.Drawing.Point(147, 101);
            this.KategoriaComboBox.Name = "KategoriaComboBox";
            this.KategoriaComboBox.Size = new System.Drawing.Size(146, 21);
            this.KategoriaComboBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kategoria";
            // 
            // CmimiProduktBox
            // 
            this.CmimiProduktBox.Location = new System.Drawing.Point(147, 60);
            this.CmimiProduktBox.Name = "CmimiProduktBox";
            this.CmimiProduktBox.Size = new System.Drawing.Size(146, 20);
            this.CmimiProduktBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cmimi";
            // 
            // EmerProduktBox
            // 
            this.EmerProduktBox.Location = new System.Drawing.Point(147, 21);
            this.EmerProduktBox.Name = "EmerProduktBox";
            this.EmerProduktBox.Size = new System.Drawing.Size(146, 20);
            this.EmerProduktBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Emri";
            // 
            // ProduktEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 344);
            this.Controls.Add(this.ShtoProduktButton);
            this.Controls.Add(this.ProductDescriptionRBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KategoriaComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmimiProduktBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmerProduktBox);
            this.Controls.Add(this.label1);
            this.Name = "ProduktEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProduktEditForm";
            this.Load += new System.EventHandler(this.ProduktEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShtoProduktButton;
        private System.Windows.Forms.RichTextBox ProductDescriptionRBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox KategoriaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CmimiProduktBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmerProduktBox;
        private System.Windows.Forms.Label label1;
    }
}