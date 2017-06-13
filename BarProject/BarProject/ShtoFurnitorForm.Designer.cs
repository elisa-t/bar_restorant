namespace BarProject
{
    partial class ShtoFurnitorForm
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
            this.EmriFurnitortextBox = new System.Windows.Forms.TextBox();
            this.shtoFurnitorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmriFurnitortextBox
            // 
            this.EmriFurnitortextBox.Location = new System.Drawing.Point(112, 56);
            this.EmriFurnitortextBox.Name = "EmriFurnitortextBox";
            this.EmriFurnitortextBox.Size = new System.Drawing.Size(129, 20);
            this.EmriFurnitortextBox.TabIndex = 2;
            // 
            // shtoFurnitorButton
            // 
            this.shtoFurnitorButton.Location = new System.Drawing.Point(77, 150);
            this.shtoFurnitorButton.Name = "shtoFurnitorButton";
            this.shtoFurnitorButton.Size = new System.Drawing.Size(86, 43);
            this.shtoFurnitorButton.TabIndex = 3;
            this.shtoFurnitorButton.Text = "SHTO";
            this.shtoFurnitorButton.UseVisualStyleBackColor = true;
            this.shtoFurnitorButton.Click += new System.EventHandler(this.shtoFurnitorButton_Click);
            // 
            // ShtoFurnitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 229);
            this.Controls.Add(this.shtoFurnitorButton);
            this.Controls.Add(this.EmriFurnitortextBox);
            this.Controls.Add(this.label1);
            this.Name = "ShtoFurnitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto Furnitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmriFurnitortextBox;
        private System.Windows.Forms.Button shtoFurnitorButton;
    }
}