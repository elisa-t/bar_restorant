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

            //konvertimi nga byte qe eshte ne databaze ne image per picture box
            MemoryStream mStream = new MemoryStream();
            byte[] pData = produktModel.Foto;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            this.ZgjidhFotoBox.Image = bm;


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

        private void ZgjidhFotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Zgjidh Foto...";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                ZgjidhFotoBox.Load(ofd.FileName);
            }
        }

        private void EditProduktButton_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();

            string emri = this.EmerProduktBox.Text;
            string pershkrimi = this.ProductDescriptionRBox.Text;
            decimal cmimi = Convert.ToDecimal(this.CmimiProduktBox.Text);
            int kategoria = dataController.getKategori(KategoriaComboBox.SelectedItem.ToString());

            /*initializing memory stream class for creating a stream of binary numbers*/
            MemoryStream ms = new MemoryStream();

            /*saving the image in raw format from picture box*/
            ZgjidhFotoBox.Image.Save(ms, ZgjidhFotoBox.Image.RawFormat);

            /*Array of Binary numbers that have been converted*/
            byte[] foto = ms.GetBuffer();

            /*closing the memory stream*/
            ms.Close();

            produktModel.Foto = foto;

            if (dataController.editProdukt(produktModel.ID, emri, cmimi, kategoria, pershkrimi, foto))
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
