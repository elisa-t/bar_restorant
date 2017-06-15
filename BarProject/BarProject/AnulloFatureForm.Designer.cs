namespace BarProject
{
    partial class AnulloFatureForm
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
            this.AnulloDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kamarier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tavoline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnulloColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AnulloDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AnulloDataGrid
            // 
            this.AnulloDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AnulloDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnulloDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Produkt,
            this.Data,
            this.Kamarier,
            this.Total,
            this.Tavoline,
            this.AnulloColumn});
            this.AnulloDataGrid.Location = new System.Drawing.Point(34, 56);
            this.AnulloDataGrid.Name = "AnulloDataGrid";
            this.AnulloDataGrid.Size = new System.Drawing.Size(585, 250);
            this.AnulloDataGrid.TabIndex = 5;
            this.AnulloDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnulloDataGrid_CellContentClick);
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
            // Kamarier
            // 
            this.Kamarier.HeaderText = "Kamarier";
            this.Kamarier.Name = "Kamarier";
            this.Kamarier.ReadOnly = true;
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
            // AnulloFatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 365);
            this.Controls.Add(this.AnulloDataGrid);
            this.Name = "AnulloFatureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anullo Fature";
            this.Load += new System.EventHandler(this.AnulloFatureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnulloDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AnulloDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kamarier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tavoline;
        private System.Windows.Forms.DataGridViewButtonColumn AnulloColumn;
    }
}