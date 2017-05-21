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
    public partial class ShtoFurnitorForm : Form
    {
        public ShtoFurnitorForm()
        {
            InitializeComponent();
        }

        private void shtoFurnitorButton_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();
            string emri = EmriFurnitortextBox.Text;
            if (dataController.ShtoFurnitor(emri))
            {
                if (MessageBox.Show("Furnitori u shtua") == DialogResult.OK)
                {
                    this.Close();
                    FurnitorForm furnitor = new FurnitorForm();
                    furnitor.Show();
                }
            }
            else
                MessageBox.Show("Furnitori nuk u shtua");
        }

        private void ShtoFurnitorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FurnitorForm form = new FurnitorForm();
            form.Show();
        }
    }
}
