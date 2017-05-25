namespace BarProject
{
    partial class ProduktForm
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
            this.ShtoButton = new System.Windows.Forms.Button();
            this.KategoriComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProduktDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmriColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmimiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FotoColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ViewColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProduktDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ShtoButton
            // 
            this.ShtoButton.Location = new System.Drawing.Point(12, 26);
            this.ShtoButton.Name = "ShtoButton";
            this.ShtoButton.Size = new System.Drawing.Size(88, 37);
            this.ShtoButton.TabIndex = 0;
            this.ShtoButton.Text = "SHTO";
            this.ShtoButton.UseVisualStyleBackColor = true;
            this.ShtoButton.Click += new System.EventHandler(this.ShtoButton_Click);
            // 
            // KategoriComboBox
            // 
            this.KategoriComboBox.FormattingEnabled = true;
            this.KategoriComboBox.Location = new System.Drawing.Point(132, 42);
            this.KategoriComboBox.Name = "KategoriComboBox";
            this.KategoriComboBox.Size = new System.Drawing.Size(437, 21);
            this.KategoriComboBox.TabIndex = 1;
            this.KategoriComboBox.SelectedIndexChanged += new System.EventHandler(this.KategoriComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Perzgjidh Kategori";
            // 
            // ProduktDataGrid
            // 
            this.ProduktDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProduktDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProduktDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EmriColumn,
            this.CmimiColumn,
            this.KategoriaColumn,
            this.FotoColumn,
            this.ViewColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.ProduktDataGrid.Location = new System.Drawing.Point(28, 94);
            this.ProduktDataGrid.Name = "ProduktDataGrid";
            this.ProduktDataGrid.Size = new System.Drawing.Size(607, 252);
            this.ProduktDataGrid.TabIndex = 3;
            this.ProduktDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProduktDataGrid_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // EmriColumn
            // 
            this.EmriColumn.HeaderText = "Emri";
            this.EmriColumn.Name = "EmriColumn";
            this.EmriColumn.ReadOnly = true;
            // 
            // CmimiColumn
            // 
            this.CmimiColumn.HeaderText = "Cmimi";
            this.CmimiColumn.Name = "CmimiColumn";
            this.CmimiColumn.ReadOnly = true;
            // 
            // KategoriaColumn
            // 
            this.KategoriaColumn.HeaderText = "Kategoria";
            this.KategoriaColumn.Name = "KategoriaColumn";
            this.KategoriaColumn.ReadOnly = true;
            // 
            // FotoColumn
            // 
            this.FotoColumn.HeaderText = "Foto";
            this.FotoColumn.Name = "FotoColumn";
            this.FotoColumn.ReadOnly = true;
            // 
            // ViewColumn
            // 
            this.ViewColumn.HeaderText = "View";
            this.ViewColumn.Name = "ViewColumn";
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit";
            this.EditColumn.Name = "EditColumn";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            // 
            // ProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 428);
            this.Controls.Add(this.ProduktDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KategoriComboBox);
            this.Controls.Add(this.ShtoButton);
            this.Name = "ProduktForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProduktForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProduktDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShtoButton;
        private System.Windows.Forms.ComboBox KategoriComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProduktDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmriColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmimiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriaColumn;
        private System.Windows.Forms.DataGridViewImageColumn FotoColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}