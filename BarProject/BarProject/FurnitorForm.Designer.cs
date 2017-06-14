namespace BarProject
{
    partial class FurnitorForm
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
            this.ShtoFurnitorButton = new System.Windows.Forms.Button();
            this.FurnitorGridView = new System.Windows.Forms.DataGridView();
            this.idFurnitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emerFurnitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editFurnitor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteFurnitor = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShtoFurnitorButton
            // 
            this.ShtoFurnitorButton.Location = new System.Drawing.Point(25, 23);
            this.ShtoFurnitorButton.Name = "ShtoFurnitorButton";
            this.ShtoFurnitorButton.Size = new System.Drawing.Size(78, 45);
            this.ShtoFurnitorButton.TabIndex = 1;
            this.ShtoFurnitorButton.Text = "SHTO";
            this.ShtoFurnitorButton.UseVisualStyleBackColor = true;
            this.ShtoFurnitorButton.Click += new System.EventHandler(this.ShtoFurnitorButton_Click);
            // 
            // FurnitorGridView
            // 
            this.FurnitorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FurnitorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FurnitorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFurnitor,
            this.emerFurnitor,
            this.editFurnitor,
            this.deleteFurnitor});
            this.FurnitorGridView.Location = new System.Drawing.Point(25, 88);
            this.FurnitorGridView.Name = "FurnitorGridView";
            this.FurnitorGridView.RowHeadersWidth = 80;
            this.FurnitorGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FurnitorGridView.Size = new System.Drawing.Size(485, 228);
            this.FurnitorGridView.TabIndex = 2;
            this.FurnitorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FurnitorGridView_CellContentClick);
            // 
            // idFurnitor
            // 
            this.idFurnitor.HeaderText = "ID";
            this.idFurnitor.Name = "idFurnitor";
            this.idFurnitor.ReadOnly = true;
            // 
            // emerFurnitor
            // 
            this.emerFurnitor.HeaderText = "Emri";
            this.emerFurnitor.Name = "emerFurnitor";
            this.emerFurnitor.ReadOnly = true;
            // 
            // editFurnitor
            // 
            this.editFurnitor.HeaderText = "Edit";
            this.editFurnitor.Name = "editFurnitor";
            // 
            // deleteFurnitor
            // 
            this.deleteFurnitor.HeaderText = "Delete";
            this.deleteFurnitor.Name = "deleteFurnitor";
            // 
            // FurnitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 341);
            this.Controls.Add(this.FurnitorGridView);
            this.Controls.Add(this.ShtoFurnitorButton);
            this.Name = "FurnitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furnitor";
            this.Load += new System.EventHandler(this.FurnitorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FurnitorGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShtoFurnitorButton;
        private System.Windows.Forms.DataGridView FurnitorGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn emerFurnitor;
        private System.Windows.Forms.DataGridViewButtonColumn editFurnitor;
        private System.Windows.Forms.DataGridViewButtonColumn deleteFurnitor;
    }
}