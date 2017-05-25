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
    public partial class ProduktViewForm : Form
    {
        public ProduktViewForm(DataModel model, string kateg)
        {
            InitializeComponent();
            produktModel = model;
            kategoria = kateg;

            this.EmriBox.Text = produktModel.Emri;
            this.CmimiBox.Text = Convert.ToString(produktModel.Cmimi);
            this.KategoriaBox.Text = kategoria;
            this.PershkrimiBox.Text = produktModel.Pershkrimi;

            //konvertimi nga byte qe eshte ne databaze ne image per picture box
            MemoryStream mStream = new MemoryStream();
            byte[] pData = produktModel.Foto;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            this.FotoBox.Image = bm;


        }

        DataModel produktModel = new DataModel();
        string kategoria = string.Empty;

        private void MbyllProduktButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
