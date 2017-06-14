namespace BarProject
{
    partial class ShtoProduktForm
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
            this.EmerProduktBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmimiProduktBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductDescriptionRBox = new System.Windows.Forms.RichTextBox();
            this.ShtoProduktButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Emri";
            // 
            // EmerProduktBox
            // 
            this.EmerProduktBox.Location = new System.Drawing.Point(117, 29);
            this.EmerProduktBox.Name = "EmerProduktBox";
            this.EmerProduktBox.Size = new System.Drawing.Size(146, 20);
            this.EmerProduktBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cmimi";
            // 
            // CmimiProduktBox
            // 
            this.CmimiProduktBox.Location = new System.Drawing.Point(117, 68);
            this.CmimiProduktBox.Name = "CmimiProduktBox";
            this.CmimiProduktBox.Size = new System.Drawing.Size(146, 20);
            this.CmimiProduktBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kategoria";
            // 
            // KategoriaComboBox
            // 
            this.KategoriaComboBox.FormattingEnabled = true;
            this.KategoriaComboBox.Location = new System.Drawing.Point(117, 109);
            this.KategoriaComboBox.Name = "KategoriaComboBox";
            this.KategoriaComboBox.Size = new System.Drawing.Size(146, 21);
            this.KategoriaComboBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pershkrimi";
            // 
            // ProductDescriptionRBox
            // 
            this.ProductDescriptionRBox.Location = new System.Drawing.Point(117, 157);
            this.ProductDescriptionRBox.Name = "ProductDescriptionRBox";
            this.ProductDescriptionRBox.Size = new System.Drawing.Size(146, 73);
            this.ProductDescriptionRBox.TabIndex = 18;
            this.ProductDescriptionRBox.Text = "";
            // 
            // ShtoProduktButton
            // 
            this.ShtoProduktButton.Location = new System.Drawing.Point(55, 273);
            this.ShtoProduktButton.Name = "ShtoProduktButton";
            this.ShtoProduktButton.Size = new System.Drawing.Size(146, 47);
            this.ShtoProduktButton.TabIndex = 22;
            this.ShtoProduktButton.Text = "Shto Produkt";
            this.ShtoProduktButton.UseVisualStyleBackColor = true;
            this.ShtoProduktButton.Click += new System.EventHandler(this.ShtoProduktButton_Click);
            // 
            // ShtoProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 353);
            this.Controls.Add(this.ShtoProduktButton);
            this.Controls.Add(this.ProductDescriptionRBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KategoriaComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmimiProduktBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmerProduktBox);
            this.Controls.Add(this.label1);
            this.Name = "ShtoProduktForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShtoProduktForm";
            this.Load += new System.EventHandler(this.ShtoProduktForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmerProduktBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CmimiProduktBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox KategoriaComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ProductDescriptionRBox;
        private System.Windows.Forms.Button ShtoProduktButton;
    }
}