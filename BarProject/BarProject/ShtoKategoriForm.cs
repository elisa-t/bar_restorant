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
    public partial class ShtoKategoriForm : Form
    {
        public ShtoKategoriForm()
        {
            InitializeComponent();
        }

        private void ShtoKategoriButton_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();

            string emer = EmriBox.Text;
            string pershkrimi = PershkrimBox.Text;
            
            if (dataController.shtoKategori(emer, pershkrimi))
            {
                if (MessageBox.Show("Kategoria u shtua") == DialogResult.OK)
                {
                    KategoriForm form = new KategoriForm();
                    this.Close();
                    form.Show();
                }
            }
            else
            {
               if ( MessageBox.Show("Kategoria nuk u shtua!") == DialogResult.OK)
               {
                   KategoriForm form = new KategoriForm();
                   this.Close();
                   form.Show();
               }
            }
        }


    }
}
