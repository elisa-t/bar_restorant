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

            this.EmriBox.Text = kategoriModel.Emri;
            this.PershkrimiBox.Text = kategoriModel.Pershkrimi;

        }

        DataModel kategoriModel = new DataModel();

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
