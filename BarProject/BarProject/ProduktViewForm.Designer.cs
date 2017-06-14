namespace BarProject
{
    partial class ProduktViewForm
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
            this.MbyllProduktButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmriBox = new System.Windows.Forms.Label();
            this.CmimiBox = new System.Windows.Forms.Label();
            this.KategoriaBox = new System.Windows.Forms.Label();
            this.PershkrimiBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MbyllProduktButton
            // 
            this.MbyllProduktButton.Location = new System.Drawing.Point(62, 230);
            this.MbyllProduktButton.Name = "MbyllProduktButton";
            this.MbyllProduktButton.Size = new System.Drawing.Size(146, 40);
            this.MbyllProduktButton.TabIndex = 34;
            this.MbyllProduktButton.Text = "MBYLL";
            this.MbyllProduktButton.UseVisualStyleBackColor = true;
            this.MbyllProduktButton.Click += new System.EventHandler(this.MbyllProduktButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Pershkrimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cmimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Emri";
            // 
            // EmriBox
            // 
            this.EmriBox.AutoSize = true;
            this.EmriBox.Location = new System.Drawing.Point(184, 23);
            this.EmriBox.Name = "EmriBox";
            this.EmriBox.Size = new System.Drawing.Size(35, 13);
            this.EmriBox.TabIndex = 35;
            this.EmriBox.Text = "label6";
            // 
            // CmimiBox
            // 
            this.CmimiBox.AutoSize = true;
            this.CmimiBox.Location = new System.Drawing.Point(184, 62);
            this.CmimiBox.Name = "CmimiBox";
            this.CmimiBox.Size = new System.Drawing.Size(35, 13);
            this.CmimiBox.TabIndex = 36;
            this.CmimiBox.Text = "label7";
            // 
            // KategoriaBox
            // 
            this.KategoriaBox.AutoSize = true;
            this.KategoriaBox.Location = new System.Drawing.Point(184, 104);
            this.KategoriaBox.Name = "KategoriaBox";
            this.KategoriaBox.Size = new System.Drawing.Size(35, 13);
            this.KategoriaBox.TabIndex = 37;
            this.KategoriaBox.Text = "label8";
            // 
            // PershkrimiBox
            // 
            this.PershkrimiBox.AutoSize = true;
            this.PershkrimiBox.Location = new System.Drawing.Point(184, 154);
            this.PershkrimiBox.Name = "PershkrimiBox";
            this.PershkrimiBox.Size = new System.Drawing.Size(35, 13);
            this.PershkrimiBox.TabIndex = 38;
            this.PershkrimiBox.Text = "label9";
            // 
            // ProduktViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 312);
            this.Controls.Add(this.PershkrimiBox);
            this.Controls.Add(this.KategoriaBox);
            this.Controls.Add(this.CmimiBox);
            this.Controls.Add(this.EmriBox);
            this.Controls.Add(this.MbyllProduktButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProduktViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProduktViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MbyllProduktButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmriBox;
        private System.Windows.Forms.Label CmimiBox;
        private System.Windows.Forms.Label KategoriaBox;
        private System.Windows.Forms.Label PershkrimiBox;
    }
}