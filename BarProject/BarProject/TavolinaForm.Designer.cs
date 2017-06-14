namespace BarProject
{
    partial class TavolinaForm
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
            this.ShtoTavolinaButton = new System.Windows.Forms.Button();
            this.TavolineGridView = new System.Windows.Forms.DataGridView();
            this.idTavoline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emerTavoline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editTavoline = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteTavoline = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShtoKamarier = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TavolineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShtoTavolinaButton
            // 
            this.ShtoTavolinaButton.Location = new System.Drawing.Point(22, 22);
            this.ShtoTavolinaButton.Name = "ShtoTavolinaButton";
            this.ShtoTavolinaButton.Size = new System.Drawing.Size(78, 45);
            this.ShtoTavolinaButton.TabIndex = 0;
            this.ShtoTavolinaButton.Text = "SHTO";
            this.ShtoTavolinaButton.UseVisualStyleBackColor = true;
            this.ShtoTavolinaButton.Click += new System.EventHandler(this.ShtoTavolinaButton_Click);
            // 
            // TavolineGridView
            // 
            this.TavolineGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TavolineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TavolineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTavoline,
            this.emerTavoline,
            this.editTavoline,
            this.deleteTavoline,
            this.ShtoKamarier});
            this.TavolineGridView.Location = new System.Drawing.Point(71, 86);
            this.TavolineGridView.Name = "TavolineGridView";
            this.TavolineGridView.RowHeadersWidth = 80;
            this.TavolineGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TavolineGridView.Size = new System.Drawing.Size(485, 228);
            this.TavolineGridView.TabIndex = 1;
            this.TavolineGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TavolineGridView_CellContentClick);
            // 
            // idTavoline
            // 
            this.idTavoline.HeaderText = "ID";
            this.idTavoline.Name = "idTavoline";
            this.idTavoline.ReadOnly = true;
            // 
            // emerTavoline
            // 
            this.emerTavoline.HeaderText = "Emri";
            this.emerTavoline.Name = "emerTavoline";
            this.emerTavoline.ReadOnly = true;
            // 
            // editTavoline
            // 
            this.editTavoline.HeaderText = "Edit";
            this.editTavoline.Name = "editTavoline";
            // 
            // deleteTavoline
            // 
            this.deleteTavoline.HeaderText = "Delete";
            this.deleteTavoline.Name = "deleteTavoline";
            // 
            // ShtoKamarier
            // 
            this.ShtoKamarier.HeaderText = "Shto Kamarier";
            this.ShtoKamarier.Name = "ShtoKamarier";
            // 
            // TavolinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 326);
            this.Controls.Add(this.TavolineGridView);
            this.Controls.Add(this.ShtoTavolinaButton);
            this.Name = "TavolinaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tavolina";
            this.Load += new System.EventHandler(this.TavolinaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TavolineGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShtoTavolinaButton;
        private System.Windows.Forms.DataGridView TavolineGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTavoline;
        private System.Windows.Forms.DataGridViewTextBoxColumn emerTavoline;
        private System.Windows.Forms.DataGridViewButtonColumn editTavoline;
        private System.Windows.Forms.DataGridViewButtonColumn deleteTavoline;
        private System.Windows.Forms.DataGridViewButtonColumn ShtoKamarier;
    }
}