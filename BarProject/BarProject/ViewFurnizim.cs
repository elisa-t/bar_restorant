using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BarProject
{
    public partial class ViewFurnizim : Form
    {
        public ViewFurnizim(DataModel model, ArrayList arrayList, string furnitor)
        {
            InitializeComponent();

            furnizim = model;
            produktetFurnizim = arrayList;
            furnitorName = furnitor;
        }

        DataModel furnizim = new DataModel();
        ArrayList produktetFurnizim = new ArrayList();
        string furnitorName = string.Empty;

        private void ViewFurnizim_Load(object sender, EventArgs e)
        {
            fatureLabel.Text = furnizim.fatura;
            furnitorLabel.Text = furnitorName;
            dataLabel.Text = Convert.ToString(furnizim.dataFature.ToString("dd-MM-yyyy"));
            totalLabel.Text = Convert.ToString(furnizim.Total);

            foreach(DataModel produkt in produktetFurnizim)
            {
                furnizimDataGrid.Rows.Add(produkt.ID, produkt.Emri, produkt.Sasia, produkt.Cmimi, produkt.Total);
            }


        }

        private void mbyllButton_Click(object sender, EventArgs e)
        {
            Furnizim furnizimForm = new Furnizim();
            this.Close();
            furnizimForm.Show();
        }




    }
}
