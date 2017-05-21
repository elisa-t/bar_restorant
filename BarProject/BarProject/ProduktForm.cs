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

    }
}
