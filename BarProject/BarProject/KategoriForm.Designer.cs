namespace BarProject
{
    partial class KategoriForm
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
            this.ShtoKategoriButton = new System.Windows.Forms.Button();
            this.KategoriListDataGridView = new System.Windows.Forms.DataGridView();
            this.KategoriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriEmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.ViewKategori = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditKategori = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteKategori = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KategoriListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShtoKategoriButton
            // 
            this.ShtoKategoriButton.Location = new System.Drawing.Point(31, 29);
            this.ShtoKategoriButton.Name = "ShtoKategoriButton";
            this.ShtoKategoriButton.Size = new System.Drawing.Size(75, 43);
            this.ShtoKategoriButton.TabIndex = 0;
            this.ShtoKategoriButton.Text = "SHTO";
            this.ShtoKategoriButton.UseVisualStyleBackColor = true;
            this.ShtoKategoriButton.Click += new System.EventHandler(this.ShtoKategoriButton_Click);
            // 
            // KategoriListDataGridView
            // 
            this.KategoriListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KategoriListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategoriID,
            this.KategoriEmer,
            this.KategoriFoto,
            this.ViewKategori,
            this.EditKategori,
            this.DeleteKategori});
            this.KategoriListDataGridView.Location = new System.Drawing.Point(13, 94);
            this.KategoriListDataGridView.Name = "KategoriListDataGridView";
            this.KategoriListDataGridView.RowTemplate.Height = 30;
            this.KategoriListDataGridView.Size = new System.Drawing.Size(650, 202);
            this.KategoriListDataGridView.TabIndex = 1;
            this.KategoriListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KategoriListDataGridView_CellContentClick);
            // 
            // KategoriID
            // 
            this.KategoriID.HeaderText = "ID";
            this.KategoriID.Name = "KategoriID";
            this.KategoriID.ReadOnly = true;
            // 
            // KategoriEmer
            // 
            this.KategoriEmer.HeaderText = "Emri";
            this.KategoriEmer.Name = "KategoriEmer";
            this.KategoriEmer.ReadOnly = true;
            // 
            // KategoriFoto
            // 
            this.KategoriFoto.HeaderText = "Foto";
            this.KategoriFoto.Name = "KategoriFoto";
            this.KategoriFoto.ReadOnly = true;
            // 
            // ViewKategori
            // 
            this.ViewKategori.HeaderText = "View";
            this.ViewKategori.Name = "ViewKategori";
            // 
            // EditKategori
            // 
            this.EditKategori.HeaderText = "Edit";
            this.EditKategori.Name = "EditKategori";
            // 
            // DeleteKategori
            // 
            this.DeleteKategori.HeaderText = "Delete";
            this.DeleteKategori.Name = "DeleteKategori";
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 328);
            this.Controls.Add(this.KategoriListDataGridView);
            this.Controls.Add(this.ShtoKategoriButton);
            this.Name = "KategoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori";
            ((System.ComponentModel.ISupportInitialize)(this.KategoriListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShtoKategoriButton;
        private System.Windows.Forms.DataGridView KategoriListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriEmer;
        private System.Windows.Forms.DataGridViewImageColumn KategoriFoto;
        private System.Windows.Forms.DataGridViewButtonColumn ViewKategori;
        private System.Windows.Forms.DataGridViewButtonColumn EditKategori;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteKategori;
    }
}