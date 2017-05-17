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
    public partial class ViewKategoriForm : Form
    {
        public ViewKategoriForm(DataModel model)
        {
            InitializeComponent();

            kategoriModel = model;
        }

        DataModel kategoriModel = new DataModel();

        private void ViewKategoriForm_Load(object sender, EventArgs e)
        {
            this.EmriBox.Text = kategoriModel.Emri;
            this.PershkrimiBox.Text = kategoriModel.Pershkrimi;

            //konvertimi nga byte qe eshte ne databaze ne image per picture box
            MemoryStream mStream = new MemoryStream();
            byte[] pData = kategoriModel.Foto;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            this.FotoBox.Image = bm;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
