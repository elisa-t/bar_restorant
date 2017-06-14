using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BarProject
{
    public partial class ProduktEditForm : Form
    {
        public ProduktEditForm(DataModel model, string kateg)
        {
            InitializeComponent();

            produktModel = model;

            kategoria = kateg;

            this.EmerProduktBox.Text = produktModel.Emri;
            this.CmimiProduktBox.Text = Convert.ToString(produktModel.Cmimi);
            
            this.ProductDescriptionRBox.Text = produktModel.Pershkrimi;
        }

        DataModel produktModel = new DataModel();
        string kategoria = string.Empty;

        private void ProduktEditForm_Load(object sender, EventArgs e)
        {
            DataController dc = new DataController();
            foreach (DataModel produkt in dc.ngarkoKategorite())
            {
                KategoriaComboBox.Items.Add(produkt.Emri);
            }

            this.KategoriaComboBox.SelectedText = kategoria;
        }

        private void EditProduktButton_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();

            string emri = this.EmerProduktBox.Text;
            string pershkrimi = this.ProductDescriptionRBox.Text;
            decimal cmimi = Convert.ToDecimal(this.CmimiProduktBox.Text);
            int kategoria = dataController.getKategori(KategoriaComboBox.SelectedItem.ToString());

            if (dataController.editProdukt(produktModel.ID, emri, cmimi, kategoria, pershkrimi))
            {
                if (MessageBox.Show("Produkti u modifikua me sukses") == DialogResult.OK)
                {
                    ProduktForm form = new ProduktForm();
                    this.Close();
                    form.Show();
                }
            }
            else
            {
                if (MessageBox.Show("Produkti nuk u modifikua!") == DialogResult.OK)
                {
                    ProduktForm form = new ProduktForm();
                    this.Close();
                    form.Show();
                }
            }
        }


    }
}
