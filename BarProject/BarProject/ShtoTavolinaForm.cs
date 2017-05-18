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
    public partial class ShtoTavolinaForm : Form
    {
        public ShtoTavolinaForm()
        {
            InitializeComponent();

        }


        private void shtotavolinaButton_Click(object sender, EventArgs e)
        {
            DataController dataController = new DataController();
            string emri = EmritextBox.Text;
            if (dataController.ShtoTavolina(emri))
            {
              if(  MessageBox.Show("Tavolina u shtua") == DialogResult.OK )
              {
                  this.Close();
                  TavolinaForm tav = new TavolinaForm();
                  tav.Show();
              }
            }
            else
                MessageBox.Show("Tavolina nuk u shtua");
        }
    }
}
