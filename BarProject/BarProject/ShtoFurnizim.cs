using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BarProject
{
    public partial class ShtoFurnizim : Form
    {
        public ShtoFurnizim()
        {
            InitializeComponent();
        }

        decimal totalFurnizim = Convert.ToDecimal(0.00);

        private void ShtoFurnizim_Load(object sender, EventArgs e)
        {
            DataController dc = new DataController();


            foreach(DataModel furnitor in dc.ngarkoTFurnitor())
            {
                FurnitorComboBox.Items.Add(furnitor.Emri);

            }
            //FurnitorComboBox.SelectedIndex = 0;
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

        private void ruajButton_Click(object sender, EventArgs e)
        {
            DataController dc = new DataController();

            DataModel furnizim = new DataModel();
            furnizim.fatura = faturaBox.Text;
            furnizim.dataFature = DateTime.Now;

            string selectedFurnitorName = FurnitorComboBox.SelectedItem.ToString();

            furnizim.furnitorID = dc.getFurnitorID(selectedFurnitorName);

            furnizim.Total = totalFurnizim;

            ArrayList produktet = new ArrayList();

            foreach(DataGridViewRow row in furnizimiDataGrid.Rows)
            {
                try
                {
                    DataModel produkt = new DataModel();

                    produkt.Emri = row.Cells["EmerProdukt"].Value.ToString();
                    produkt.Sasia = Convert.ToInt32(row.Cells["SasiProdukt"].Value);
                    produkt.Cmimi = Convert.ToDecimal(row.Cells["CmimProdukt"].Value);
                    produkt.Total = Convert.ToDecimal(row.Cells["TotalProdukt"].Value);

                    produktet.Add(produkt);
                }
                catch
                {
                    //nuk ka me rreshta ne datagrid
                }
            }

            if (dc.shtoFurnizim(furnizim, produktet))
            {
                MessageBox.Show("Furnizimi u shtua");
            }
            else
            {
                MessageBox.Show("Furnizimi nuk u shtua!!");
            }

        }

        private void furnizimiDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (furnizimiDataGrid.Rows != null)
             {
                 if (furnizimiDataGrid.Columns[e.ColumnIndex].Name == "Delete")
                 {
                     furnizimiDataGrid.Rows.RemoveAt(e.RowIndex);
                 }

             }
        }
    }
}
