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
    public partial class ShtoKamarierForn : Form
    {
        DataModel model = new DataModel();
        DataController dc = new DataController();
        public ShtoKamarierForn(DataModel  tavoline)
        {
            InitializeComponent();
            model = tavoline;
        }

        private void ShtoKamarierForn_Load(object sender, EventArgs e)
        {            
            TavolinaLabel.Text = model.Emri;
            KamarieriComboBox.Items.Add("Zgjidh kamarierin");
            foreach(string emri in dc.ngarkoKamarier())
            {
                KamarieriComboBox.Items.Add(emri);
            }
             KamarieriComboBox.SelectedIndex = 0;
        
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TavolinaForm tavolina = new TavolinaForm();
            tavolina.Show();
        }

        private void ShtoKamarierButton_Click(object sender, EventArgs e)
        {
            string SelectedKamarierName = KamarieriComboBox.SelectedItem.ToString();
            model.KamarierID = dc.getKamarierID(SelectedKamarierName);
            if (dc.UpdateTavoline(model))
            {
                if (MessageBox.Show("Kamarieri u shtua") == DialogResult.OK)
                {
                    this.Close();
                    TavolinaForm tavolina = new TavolinaForm();
                    tavolina.Show();
                }
            }
            else
            {
                if (MessageBox.Show("Kamarieri nuk u shtua") == DialogResult.OK)
                {
                    this.Close();
                    TavolinaForm tavolina = new TavolinaForm();
                    tavolina.Show();
                }
            }
 
        }
    }
}
