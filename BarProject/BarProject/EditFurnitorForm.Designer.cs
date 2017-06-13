namespace BarProject
{
    partial class EditFurnitorForm
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
            this.FurnitorEmriBox = new System.Windows.Forms.TextBox();
            this.EditFurnitorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FurnitorEmriBox
            // 
            this.FurnitorEmriBox.Location = new System.Drawing.Point(96, 46);
            this.FurnitorEmriBox.Name = "FurnitorEmriBox";
            this.FurnitorEmriBox.Size = new System.Drawing.Size(114, 20);
            this.FurnitorEmriBox.TabIndex = 3;
            // 
            // EditFurnitorButton
            // 
            this.EditFurnitorButton.Location = new System.Drawing.Point(60, 142);
            this.EditFurnitorButton.Name = "EditFurnitorButton";
            this.EditFurnitorButton.Size = new System.Drawing.Size(86, 43);
            this.EditFurnitorButton.TabIndex = 4;
            this.EditFurnitorButton.Text = "OK";
            this.EditFurnitorButton.UseVisualStyleBackColor = true;
            this.EditFurnitorButton.Click += new System.EventHandler(this.EditFurnitorButton_Click);
            // 
            // EditFurnitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 214);
            this.Controls.Add(this.EditFurnitorButton);
            this.Controls.Add(this.FurnitorEmriBox);
            this.Controls.Add(this.label1);
            this.Name = "EditFurnitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFurnitorForm";
            this.Load += new System.EventHandler(this.EditFurnitorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FurnitorEmriBox;
        private System.Windows.Forms.Button EditFurnitorButton;
    }
}