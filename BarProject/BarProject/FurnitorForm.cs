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
    public partial class FurnitorForm : Form
    {
        UserModel user = new UserModel();

        public FurnitorForm(UserModel userModel)
        {
            InitializeComponent();
            user = userModel;
            DataController dataController = new DataController();
        }

        private void ShtoFurnitorButton_Click(object sender, EventArgs e)
        {
            ShtoFurnitorForm shtoFurnitor = new ShtoFurnitorForm();
            shtoFurnitor.Show();
        }

        private void FurnitorForm_Load(object sender, EventArgs e)
        {
            DataController dataController = new DataController();
            foreach (DataModel furnitor in dataController.ngarkoTFurnitor()) 
            {
                FurnitorGridView.Rows.Add(furnitor.ID, furnitor.Emri);
            }
        }

        private void FurnitorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (FurnitorGridView.Columns[e.ColumnIndex].Name == "deleteFurnitor")
                {
                    if (MessageBox.Show("Konfirmoni fshirjen?", "Kujdes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int ID = Convert.ToInt32(FurnitorGridView.Rows[e.RowIndex].Cells["idFurnitor"].Value);
                        DataController dataController = new DataController();
                        if (dataController.fshiFurnitor(ID))
                        {
                            FurnitorGridView.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Furnitori u fshi");
                        }
                        else if (!dataController.fshiFurnitor(ID))
                        {
                            MessageBox.Show("Furnitori nuk u fshi");
                        }
                    }
                }

                else if (FurnitorGridView.Columns[e.ColumnIndex].Name == "editFurnitor")
                {
                  
                }
            }
        }

    }
}
