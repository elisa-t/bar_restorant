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

            this.EmriBox.Text = editModel.Emri;
            this.PershkrimBox.Text = editModel.Pershkrimi;


        }

        DataModel editModel = new DataModel();
        private void EditKategoriButton_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();

            editModel.Emri = this.EmriBox.Text;
            editModel.Pershkrimi = this.PershkrimBox.Text;

            if(dataController.editKategori(editModel))
            {
               if ( MessageBox.Show("Kategoria u modifikua me sukses") == DialogResult.OK)
               {
                   KategoriForm form = new KategoriForm();
                   this.Close();
                   form.Show();
               }
            }
            else
            {
                if (MessageBox.Show("Kategoria nuk u modifikua!") == DialogResult.OK)
                {
                    KategoriForm form = new KategoriForm();
                    this.Close();
                    form.Show();
                }
            }

        }


    }
}
