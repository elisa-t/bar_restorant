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
    public partial class EditTavoline : Form
    {
        DataModel Model = new DataModel();
        public EditTavoline(DataModel model)
        {
            InitializeComponent();

            Model = model;
        }
            
        private void EditTavolinaButton_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();
            Model.Emri = this.EditEmriBox.Text;
            if (dataController.editTavolina(Model))
            {
                MessageBox.Show("Tavolina u modifikua");
            }
            else
                MessageBox.Show("Tavolina nuk u modifikua");
        }

        private void EditTavoline_Load(object sender, EventArgs e)
        {
            this.EditEmriBox.Text = Model.Emri;
        }

       
    }
}
