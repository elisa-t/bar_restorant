namespace BarProject
{
    partial class ShitjeKamarierForm
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
            this.ShitjeDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tavoline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnulloColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ShitjeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ShitjeDataGrid
            // 
            this.ShitjeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShitjeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShitjeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Produkt,
            this.Data,
            this.Column1,
            this.Total,
            this.Tavoline,
            this.AnulloColumn});
            this.ShitjeDataGrid.Location = new System.Drawing.Point(24, 38);
            this.ShitjeDataGrid.Name = "ShitjeDataGrid";
            this.ShitjeDataGrid.Size = new System.Drawing.Size(566, 241);
            this.ShitjeDataGrid.TabIndex = 5;
            this.ShitjeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shitjeDataGrid_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Produkt
            // 
            this.Produkt.HeaderText = "Produkt";
            this.Produkt.Name = "Produkt";
            this.Produkt.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kamarier";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Tavoline
            // 
            this.Tavoline.HeaderText = "Tavoline";
            this.Tavoline.Name = "Tavoline";
            this.Tavoline.ReadOnly = true;
            // 
            // AnulloColumn
            // 
            this.AnulloColumn.HeaderText = "Anullo";
            this.AnulloColumn.Name = "AnulloColumn";
            // 
            // ShitjeKamarierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 323);
            this.Controls.Add(this.ShitjeDataGrid);
            this.Name = "ShitjeKamarierForm";
            this.Text = "Kerkese per anullim shitjesh";
            this.Load += new System.EventHandler(this.ShitjeKamarierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShitjeDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShitjeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tavoline;
        private System.Windows.Forms.DataGridViewButtonColumn AnulloColumn;
    }
}