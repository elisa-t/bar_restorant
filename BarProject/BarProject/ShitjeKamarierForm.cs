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
    public partial class ShitjeKamarierForm : Form
    {
        public ShitjeKamarierForm(UserModel model)
        {
            InitializeComponent();

            kamarier = model;
        }

        UserModel kamarier = new UserModel();

        ArrayList shitjetList = new ArrayList();

        DataController dc = new DataController();


        private void ShitjeKamarierForm_Load(object sender, EventArgs e)
        {
            shitjetList = dc.ngarkoShitjeNgaKamarier(kamarier.ID);

            foreach(DataModel shitje in shitjetList)
            {
                ShitjeDataGrid.Rows.Add(shitje.ID, shitje.emerProdukt, shitje.ShitjeData.ToString("dd-MM-yyyy"), shitje.emerKamarier, shitje.Total, shitje.emerTavoline);
            }

        }

        private void shitjeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ShitjeDataGrid.Columns[e.ColumnIndex].Name == "AnulloColumn")
                {
                    if (MessageBox.Show("Kerkese per anullim?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int ID = Convert.ToInt32(ShitjeDataGrid.Rows[e.RowIndex].Cells["ID"].Value);
                        if (dc.kerkoAnullimShitje(ID))
                        {
                            ShitjeDataGrid.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Kerkesa u krijua");

                        }
                        else
                        {
                            MessageBox.Show("Kerkesa nuk u krijua!");
                        }
                    }
                }
            }
        }

        


    }
}
