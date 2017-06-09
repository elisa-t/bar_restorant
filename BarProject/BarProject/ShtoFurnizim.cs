using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarProject
{
    public partial class ShtoFurnizim : Form
    {
        public ShtoFurnizim()
        {
            InitializeComponent();
        }

        private void ShtoFurnizim_Load(object sender, EventArgs e)
        {
            DataController dc = new DataController();
            foreach(DataModel furnitor in dc.ngarkoTFurnitor())
            {
                FurnitorComboBox.Items.Add(furnitor.Emri);

            }
            FurnitorComboBox.SelectedIndex = 0;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            emriBox.Text = String.Empty;
            sasiaBox.Text = String.Empty;
            cmimiBox.Text = String.Empty;
        }

        private void shtoButton_Click(object sender, EventArgs e)
        {
            if (emriBox.Text == String.Empty || emriBox.Text == "" 
                || sasiaBox.Text == String.Empty || sasiaBox.Text == ""
                || cmimiBox.Text == String.Empty || cmimiBox.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat!");
            }
            else
            {
                decimal totali = Convert.ToInt32(sasiaBox.Text) * Convert.ToDecimal(cmimiBox.Text);
                furnizimiDataGrid.Rows.Add(emriBox.Text, sasiaBox.Text, cmimiBox.Text, totali);

                decimal totalFurnizim = Convert.ToDecimal(totalLabel.Text);

                totalFurnizim += totali;

                totalLabel.Text = totalFurnizim.ToString();

                emriBox.Text = String.Empty;
                sasiaBox.Text = String.Empty;
                cmimiBox.Text = String.Empty;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Furnizim form = new Furnizim();
            this.Close();
            form.Show();
        }
    }
}
