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
            this.ZgjidhFotoButton = new System.Windows.Forms.Button();
            this.ZgjidhFotoBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductDescriptionRBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmimiProduktBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmerProduktBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ZgjidhFotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShtoProduktButton
            // 
            this.ShtoProduktButton.Location = new System.Drawing.Point(91, 383);
            this.ShtoProduktButton.Name = "ShtoProduktButton";
            this.ShtoProduktButton.Size = new System.Drawing.Size(146, 40);
            this.ShtoProduktButton.TabIndex = 34;
            this.ShtoProduktButton.Text = "Modifiko";
            this.ShtoProduktButton.UseVisualStyleBackColor = true;
            this.ShtoProduktButton.Click += new System.EventHandler(this.EditProduktButton_Click);
            // 
            // ZgjidhFotoButton
            // 
            this.ZgjidhFotoButton.Location = new System.Drawing.Point(42, 304);
            this.ZgjidhFotoButton.Name = "ZgjidhFotoButton";
            this.ZgjidhFotoButton.Size = new System.Drawing.Size(85, 23);
            this.ZgjidhFotoButton.TabIndex = 33;
            this.ZgjidhFotoButton.Text = "Zgjidh Foto";
            this.ZgjidhFotoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZgjidhFotoButton.UseVisualStyleBackColor = true;
            this.ZgjidhFotoButton.Click += new System.EventHandler(this.ZgjidhFotoButton_Click);
            // 
            // ZgjidhFotoBox
            // 
            this.ZgjidhFotoBox.Location = new System.Drawing.Point(147, 254);
            this.ZgjidhFotoBox.Name = "ZgjidhFotoBox";
            this.ZgjidhFotoBox.Size = new System.Drawing.Size(146, 102);
            this.ZgjidhFotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ZgjidhFotoBox.TabIndex = 32;
            this.ZgjidhFotoBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Foto";
            // 
            // ProductDescriptionRBox
            // 
            this.ProductDescriptionRBox.Location = new System.Drawing.Point(147, 149);
            this.ProductDescriptionRBox.Name = "ProductDescriptionRBox";
            this.ProductDescriptionRBox.Size = new System.Drawing.Size(146, 73);
            this.ProductDescriptionRBox.TabIndex = 30;
            this.ProductDescriptionRBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 167);
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
            this.label3.Location = new System.Drawing.Point(57, 105);
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
            this.label2.Location = new System.Drawing.Point(57, 61);
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
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Emri";
            // 
            // ProduktEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 437);
            this.Controls.Add(this.ShtoProduktButton);
            this.Controls.Add(this.ZgjidhFotoButton);
            this.Controls.Add(this.ZgjidhFotoBox);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.ZgjidhFotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShtoProduktButton;
        private System.Windows.Forms.Button ZgjidhFotoButton;
        private System.Windows.Forms.PictureBox ZgjidhFotoBox;
        private System.Windows.Forms.Label label5;
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