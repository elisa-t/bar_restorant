namespace BarProject
{
    partial class ShitjeForm
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
            this.produktDropBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kamarierDropBox = new System.Windows.Forms.ComboBox();
            this.shitjeDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kamarier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tavoline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tavolineDropBox = new System.Windows.Forms.ComboBox();
            this.pastroButton = new System.Windows.Forms.Button();
            this.dataFillimPicker = new System.Windows.Forms.DateTimePicker();
            this.dataMbarimPicker = new System.Windows.Forms.DateTimePicker();
            this.kerkoButton = new System.Windows.Forms.Button();
            this.AnulloButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shitjeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // produktDropBox
            // 
            this.produktDropBox.FormattingEnabled = true;
            this.produktDropBox.Location = new System.Drawing.Point(34, 45);
            this.produktDropBox.Name = "produktDropBox";
            this.produktDropBox.Size = new System.Drawing.Size(129, 21);
            this.produktDropBox.TabIndex = 0;
            this.produktDropBox.SelectedIndexChanged += new System.EventHandler(this.produktDropBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produkt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kamarier";
            // 
            // kamarierDropBox
            // 
            this.kamarierDropBox.FormattingEnabled = true;
            this.kamarierDropBox.Location = new System.Drawing.Point(178, 45);
            this.kamarierDropBox.Name = "kamarierDropBox";
            this.kamarierDropBox.Size = new System.Drawing.Size(129, 21);
            this.kamarierDropBox.TabIndex = 3;
            this.kamarierDropBox.SelectedIndexChanged += new System.EventHandler(this.kamarierDropBox_SelectedIndexChanged);
            // 
            // shitjeDataGrid
            // 
            this.shitjeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shitjeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shitjeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Produkt,
            this.Data,
            this.Kamarier,
            this.Total,
            this.Tavoline});
            this.shitjeDataGrid.Location = new System.Drawing.Point(34, 135);
            this.shitjeDataGrid.Name = "shitjeDataGrid";
            this.shitjeDataGrid.Size = new System.Drawing.Size(640, 241);
            this.shitjeDataGrid.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tavoline";
            // 
            // tavolineDropBox
            // 
            this.tavolineDropBox.FormattingEnabled = true;
            this.tavolineDropBox.Location = new System.Drawing.Point(324, 45);
            this.tavolineDropBox.Name = "tavolineDropBox";
            this.tavolineDropBox.Size = new System.Drawing.Size(129, 21);
            this.tavolineDropBox.TabIndex = 6;
            this.tavolineDropBox.SelectedIndexChanged += new System.EventHandler(this.tavolineDropBox_SelectedIndexChanged);
            // 
            // pastroButton
            // 
            this.pastroButton.Location = new System.Drawing.Point(599, 85);
            this.pastroButton.Name = "pastroButton";
            this.pastroButton.Size = new System.Drawing.Size(75, 23);
            this.pastroButton.TabIndex = 7;
            this.pastroButton.Text = "PASTRO";
            this.pastroButton.UseVisualStyleBackColor = true;
            this.pastroButton.Click += new System.EventHandler(this.pastroButton_Click);
            // 
            // dataFillimPicker
            // 
            this.dataFillimPicker.Location = new System.Drawing.Point(34, 88);
            this.dataFillimPicker.Name = "dataFillimPicker";
            this.dataFillimPicker.Size = new System.Drawing.Size(200, 20);
            this.dataFillimPicker.TabIndex = 8;
            this.dataFillimPicker.ValueChanged += new System.EventHandler(this.dataFillimPicker_ValueChanged);
            // 
            // dataMbarimPicker
            // 
            this.dataMbarimPicker.Location = new System.Drawing.Point(253, 88);
            this.dataMbarimPicker.Name = "dataMbarimPicker";
            this.dataMbarimPicker.Size = new System.Drawing.Size(200, 20);
            this.dataMbarimPicker.TabIndex = 9;
            this.dataMbarimPicker.ValueChanged += new System.EventHandler(this.dataMbarimPicker_ValueChanged);
            // 
            // kerkoButton
            // 
            this.kerkoButton.Location = new System.Drawing.Point(508, 85);
            this.kerkoButton.Name = "kerkoButton";
            this.kerkoButton.Size = new System.Drawing.Size(75, 26);
            this.kerkoButton.TabIndex = 10;
            this.kerkoButton.Text = "KERKO";
            this.kerkoButton.UseVisualStyleBackColor = true;
            this.kerkoButton.Click += new System.EventHandler(this.kerkoButton_Click);
            // 
            // AnulloButton
            // 
            this.AnulloButton.Location = new System.Drawing.Point(553, 25);
            this.AnulloButton.Name = "AnulloButton";
            this.AnulloButton.Size = new System.Drawing.Size(121, 41);
            this.AnulloButton.TabIndex = 11;
            this.AnulloButton.Text = "ANULLIME";
            this.AnulloButton.UseVisualStyleBackColor = true;
            this.AnulloButton.Click += new System.EventHandler(this.AnulloButton_Click);
            // 
            // ShitjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 414);
            this.Controls.Add(this.AnulloButton);
            this.Controls.Add(this.kerkoButton);
            this.Controls.Add(this.dataMbarimPicker);
            this.Controls.Add(this.dataFillimPicker);
            this.Controls.Add(this.pastroButton);
            this.Controls.Add(this.tavolineDropBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shitjeDataGrid);
            this.Controls.Add(this.kamarierDropBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produktDropBox);
            this.Name = "ShitjeForm";
            this.Text = "ShitjeForm";
            this.Load += new System.EventHandler(this.ShitjeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shitjeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox produktDropBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kamarierDropBox;
        private System.Windows.Forms.DataGridView shitjeDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tavolineDropBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kamarier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tavoline;
        private System.Windows.Forms.Button pastroButton;
        private System.Windows.Forms.DateTimePicker dataFillimPicker;
        private System.Windows.Forms.DateTimePicker dataMbarimPicker;
        private System.Windows.Forms.Button kerkoButton;
        private System.Windows.Forms.Button AnulloButton;
    }
}