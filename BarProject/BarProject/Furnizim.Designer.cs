namespace BarProject
{
    partial class Furnizim
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
            this.label1 = new System.Windows.Forms.Label();
            this.FurnitorComboBox = new System.Windows.Forms.ComboBox();
            this.furnizimDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrFature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Furnitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.furnizimDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ShtoFurnitorButton
            // 
            this.ShtoFurnitorButton.Location = new System.Drawing.Point(34, 28);
            this.ShtoFurnitorButton.Name = "ShtoFurnitorButton";
            this.ShtoFurnitorButton.Size = new System.Drawing.Size(88, 55);
            this.ShtoFurnitorButton.TabIndex = 0;
            this.ShtoFurnitorButton.Text = "SHTO FURNIZIM";
            this.ShtoFurnitorButton.UseVisualStyleBackColor = true;
            this.ShtoFurnitorButton.Click += new System.EventHandler(this.ShtoFurnitorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perzgjidh Furnitor";
            // 
            // FurnitorComboBox
            // 
            this.FurnitorComboBox.FormattingEnabled = true;
            this.FurnitorComboBox.Location = new System.Drawing.Point(153, 53);
            this.FurnitorComboBox.Name = "FurnitorComboBox";
            this.FurnitorComboBox.Size = new System.Drawing.Size(407, 21);
            this.FurnitorComboBox.TabIndex = 2;
            this.FurnitorComboBox.SelectedIndexChanged += new System.EventHandler(this.FurnitorComboBox_SelectedIndexChanged);
            // 
            // furnizimDataGrid
            // 
            this.furnizimDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.furnizimDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnizimDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NrFature,
            this.Furnitor,
            this.Data,
            this.Total,
            this.View,
            this.Edit,
            this.Delete});
            this.furnizimDataGrid.Location = new System.Drawing.Point(34, 115);
            this.furnizimDataGrid.Name = "furnizimDataGrid";
            this.furnizimDataGrid.Size = new System.Drawing.Size(526, 215);
            this.furnizimDataGrid.TabIndex = 3;
            this.furnizimDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NrFature
            // 
            this.NrFature.HeaderText = "Nr Fature";
            this.NrFature.Name = "NrFature";
            this.NrFature.ReadOnly = true;
            // 
            // Furnitor
            // 
            this.Furnitor.HeaderText = "Furnitor";
            this.Furnitor.Name = "Furnitor";
            this.Furnitor.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data ";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // Furnizim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 429);
            this.Controls.Add(this.furnizimDataGrid);
            this.Controls.Add(this.FurnitorComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShtoFurnitorButton);
            this.Name = "Furnizim";
            this.Text = "Furnizim";
            this.Load += new System.EventHandler(this.Furnizim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.furnizimDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShtoFurnitorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FurnitorComboBox;
        private System.Windows.Forms.DataGridView furnizimDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrFature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Furnitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}