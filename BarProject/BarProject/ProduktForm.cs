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
    public partial class ProduktForm : Form
    {
        public ProduktForm()
        {
            InitializeComponent();

            DataController dc = new DataController();

            KategoriComboBox.Items.Add("Te gjitha kategorite");

            foreach (DataModel kategoria in dc.ngarkoKategorite())
            {
                KategoriComboBox.Items.Add(kategoria.Emri);
            }

            KategoriComboBox.SelectedIndex = 0;
        }

        private void KategoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProduktDataGrid.Rows.Clear();

            DataController dc = new DataController();

            if (KategoriComboBox.SelectedIndex == 0)
            { 
                foreach(DataModel produkt in dc.ngarkoTeGjitheProduktet())
                {
                    ProduktDataGrid.Rows.Add(produkt.ID, produkt.Emri, produkt.Cmimi, produkt.Kategoria, produkt.Foto);
                }
            }
            else if (KategoriComboBox.SelectedIndex > 0)
            {
                string kategoriEmer = KategoriComboBox.SelectedItem.ToString();

                int kategoriID = dc.getKategori(kategoriEmer);

                foreach (DataModel produkt in dc.ngarkoProduktetNgaKategoria(kategoriID))
                {
                    ProduktDataGrid.Rows.Add(produkt.ID, produkt.Emri, produkt.Cmimi, produkt.Kategoria, produkt.Foto);
                }
            }
        }

        


        private void ShtoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ShtoProduktForm produkt = new ShtoProduktForm();
            produkt.Show();
        }

        private void ProduktDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProduktDataGrid.Columns[e.ColumnIndex].Name == "ViewColumn")
                {
                    DataModel produkt = new DataModel();
                    int produktID = Convert.ToInt32(ProduktDataGrid.Rows[e.RowIndex].Cells["ID"].Value);

                    DataController dc = new DataController();

                    produkt = dc.getProdukt(produktID);

                    string kategoriaName = dc.getKategoriaNameFromProdukt(produktID);

                    ProduktViewForm viewProdukt = new ProduktViewForm(produkt, kategoriaName);



                    viewProdukt.Show();
                }
                else if (ProduktDataGrid.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    DataModel produkti = new DataModel();
                    int Id = Convert.ToInt32(ProduktDataGrid.Rows[e.RowIndex].Cells["ID"].Value);

                    DataController dc = new DataController();

                    produkti = dc.getProdukt(Id);

                    string kateg = dc.getKategoriaNameFromProdukt(Id);

                    ProduktEditForm editProduktForm = new ProduktEditForm(produkti, kateg);

                    this.Close();

                    editProduktForm.Show();
                }
                else if (ProduktDataGrid.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    if (MessageBox.Show("Konfirmoni fshirjen?", "Kujdes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int produktID = Convert.ToInt32(ProduktDataGrid.Rows[e.RowIndex].Cells["ID"].Value);

                        DataController dc = new DataController();

                        if (dc.fshiProdukt(produktID))
                        {
                            MessageBox.Show("Produkti u fshi");
                            ProduktDataGrid.Rows.RemoveAt(e.RowIndex);
                        }
                        else 
                        {
                            MessageBox.Show("Produkti nuk u fshi!");
                        }

                    }
                }
            }
        }

    }
}
