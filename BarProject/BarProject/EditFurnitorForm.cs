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
    public partial class EditFurnitorForm : Form
    {
        DataModel furnitor = new DataModel();
        public EditFurnitorForm(DataModel model)
        {
            InitializeComponent();
            furnitor = model;
        }

        private void EditFurnitorButton_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();
            furnitor.Emri = this.FurnitorEmriBox.Text;
            if (dataController.editFurnitor(furnitor))
            {
                if (MessageBox.Show("Furnitori u modifikua") == DialogResult.OK)
                {
                    this.Close();
                    FurnitorForm furnitorForm = new FurnitorForm();
                    furnitorForm.Show();
                }
            }
            else
            {
                if (MessageBox.Show("Furnitori nuk u modifikua") == DialogResult.OK)
                {
                    this.Close();
                    FurnitorForm furnitorForm = new FurnitorForm();
                    furnitorForm.Show();
                }
            }
        }

        private void EditFurnitorForm_Load(object sender, EventArgs e)
        {
            this.FurnitorEmriBox.Text = furnitor.Emri;
        }

    }
}
