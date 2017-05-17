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
    public partial class EditKategoriForm : Form
    {
        public EditKategoriForm(DataModel model)
        {
            InitializeComponent();

            editModel = model;
        }

        DataModel editModel = new DataModel();

        private void EditKategoriForm_Load(object sender, EventArgs e)
        {
            this.EmriBox.Text = editModel.Emri;
            this.PershkrimBox.Text = editModel.Pershkrimi;

            //konvertimi nga byte qe eshte ne databaze ne image per picture box
            MemoryStream mStream = new MemoryStream();
            byte[] pData = editModel.Foto;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            this.FotoBox.Image = bm;

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
                FotoBox.Load(ofd.FileName);
            }
        }

        private void ShtoKategoriButton_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();

            editModel.Emri = this.EmriBox.Text;
            editModel.Pershkrimi = this.PershkrimBox.Text;

            /*initializing memory stream class for creating a stream of binary numbers*/
            MemoryStream ms = new MemoryStream();

            /*saving the image in raw format from picture box*/
            FotoBox.Image.Save(ms, FotoBox.Image.RawFormat);

            /*Array of Binary numbers that have been converted*/
            byte[] foto = ms.GetBuffer();

            /*closing the memory stream*/
            ms.Close();

            editModel.Foto = foto;

            if(dataController.editKategori(editModel))
            {
                MessageBox.Show("Kategoria u modifikua me sukses");
            }
            else
            {
                MessageBox.Show("Kategoria nuk u modifikua!");
            }

        }




    }
}
