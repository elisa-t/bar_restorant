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
    public partial class EditFurnizim : Form
    {
        public EditFurnizim(DataModel modelFurnizim, ArrayList produketList, string furnitoriName)
        {
            InitializeComponent();

            furnizim = modelFurnizim;
            produktetFurnizim = produketList;
            furnitori = furnitoriName;

        }

        DataModel furnizim = new DataModel();
        ArrayList produktetFurnizim = new ArrayList();
        string furnitori = string.Empty;
        decimal totalFurnizim = Convert.ToDecimal(0.00);

        private void EditFurnizim_Load(object sender, EventArgs e)
        {
            DataController dc = new DataController();
            foreach(DataModel furnitor in dc.ngarkoTFurnitor())
            {
                FurnitorComboBox.Items.Add(furnitor.Emri);
            }

            FurnitorComboBox.SelectedText = furnitori;

            foreach(DataModel produkt in produktetFurnizim)
            {
                furnizimDataGrid.Rows.Add(produkt.ID, produkt.Emri, produkt.Sasia, produkt.Cmimi, produkt.Total);
            }

            faturaBox.Text = furnizim.fatura;

            totalLabel.Text = Convert.ToString(furnizim.Total);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Furnizim form = new Furnizim();
            this.Close();
            form.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            emriBox.Text = string.Empty;
            sasiaBox.Text = string.Empty;
            cmimiBox.Text = string.Empty;
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
                furnizimDataGrid.Rows.Add(emriBox.Text, sasiaBox.Text, cmimiBox.Text, totali);

                totalFurnizim += totali;

                totalLabel.Text = totalFurnizim.ToString();

                emriBox.Text = String.Empty;
                sasiaBox.Text = String.Empty;
                cmimiBox.Text = String.Empty;
            }
        }

        private void furnizimDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Konfirmoni fshirjen?", "Kujdes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataModel model = new DataModel();

                    DataController dc = new DataController();

                    int Id = Convert.ToInt32(furnizimDataGrid.Rows[e.RowIndex].Cells["ID"].Value);

                    decimal total = Convert.ToDecimal(furnizimDataGrid.Rows[e.RowIndex].Cells["TotalProdukt"].Value);

                    if (dc.fshiProduktFurnizim(Id))
                    {

                        MessageBox.Show("Fshirja u krye!");
                        furnizimDataGrid.Rows.RemoveAt(e.RowIndex);
                        furnizim.Total = furnizim.Total - total;
                        totalLabel.Text = Convert.ToString(furnizim.Total);
                    }
                    else
                    {
                        MessageBox.Show("Fshirja nuk u krye!");
                    }

                }
            }
        }

        private void ruajButton_Click(object sender, EventArgs e)
        {
            ArrayList produktFurnizim = new ArrayList();

            DataController dc = new DataController();

            foreach (DataGridViewRow row in furnizimDataGrid.Rows)
            {
                try
                {
                    DataModel produkt = new DataModel();

                    produkt.ID = Convert.ToInt32(row.Cells["ID"].Value);
                    produkt.Emri = row.Cells["EmerProdukt"].Value.ToString();
                    produkt.Sasia = Convert.ToInt32(row.Cells["SasiProdukt"].Value);
                    produkt.Cmimi = Convert.ToDecimal(row.Cells["CmimProdukt"].Value);
                    produkt.Total = Convert.ToDecimal(row.Cells["TotalProdukt"].Value);

                    produktFurnizim.Add(produkt);
                }
                catch
                {
                    //nuk ka me rreshta ne datagrid
                }

                furnizim.fatura = faturaBox.Text;

                //string selectedFurnitorName = FurnitorComboBox.SelectedItem.ToString();

                string selectedFurnitorName = this.FurnitorComboBox.GetItemText(this.FurnitorComboBox.SelectedItem);

                furnizim.furnitorID = dc.getFurnitorID(selectedFurnitorName);

                if(dc.editFurnizim(furnizim, produktFurnizim))
                {
                    if (MessageBox.Show("Furnizimi u modifikua") == DialogResult.OK)
                    {
                        this.Close();
                        Furnizim furnizimForm = new Furnizim();
                        furnizimForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Furnizimi nuk u modifikua!");
                }



            }
        }

        
    }
}
