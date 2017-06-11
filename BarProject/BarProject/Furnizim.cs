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
    public partial class Furnizim : Form
    {
        public Furnizim()
        {
            InitializeComponent();
        }

        private void Furnizim_Load(object sender, EventArgs e)
        {
            DataController dc = new DataController();

            FurnitorComboBox.Items.Add("Te gjithe furnitoret");

            foreach(DataModel furnitor in dc.ngarkoTFurnitor())
            {
                FurnitorComboBox.Items.Add(furnitor.Emri);
            }



        }


        private void ShtoFurnitorButton_Click(object sender, EventArgs e)
        {
            ShtoFurnizim form = new ShtoFurnizim();
            this.Close();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataController dc = new DataController();

                if (furnizimDataGrid.Columns[e.ColumnIndex].Name == "View")
                {

                    int Id = Convert.ToInt32(furnizimDataGrid.Rows[e.RowIndex].Cells["ID"].Value);
                    DataModel furnizimi = new DataModel();
                    ArrayList produktetFurnizim = new ArrayList();

                    furnizimi = dc.returnFurnizim(Id);
                    produktetFurnizim = dc.returnProdukteFurnizim(Id);
                    string furnitor = dc.getFurnitorName(furnizimi.furnitorID);


                    ViewFurnizim furnizimView = new ViewFurnizim(furnizimi, produktetFurnizim, furnitor);
                    this.Close();
                    furnizimView.Show();

                }
                else if (furnizimDataGrid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int Id = Convert.ToInt32(furnizimDataGrid.Rows[e.RowIndex].Cells["ID"].Value);
                    DataModel furnizimi = new DataModel();
                    ArrayList produktetFurnizim = new ArrayList();

                    furnizimi = dc.returnFurnizim(Id);
                    produktetFurnizim = dc.returnProdukteFurnizim(Id);
                    string furnitor = dc.getFurnitorName(furnizimi.furnitorID);

                    EditFurnizim furnizimForm = new EditFurnizim(furnizimi, produktetFurnizim, furnitor);
                    this.Close();
                    furnizimForm.Show();


                }
                else if (furnizimDataGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Konfirmoni fshirjen?", "Kujdes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataModel model = new DataModel();

                        int Id = Convert.ToInt32(furnizimDataGrid.Rows[e.RowIndex].Cells["ID"].Value);


                        if (dc.fshiFurnizim(Id))
                        {

                            MessageBox.Show("Furnizimi u fshi!");
                            furnizimDataGrid.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("Furnizimi nuk u fshi!");
                        }
                    }
                }

            }
        }

        private void FurnitorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            furnizimDataGrid.Rows.Clear();

            DataController dc = new DataController();

            if (FurnitorComboBox.SelectedIndex == 0)
            {
                foreach (DataModel furnizim in dc.ngarkoTeGjitheFurnizimet())
                {
                    furnizimDataGrid.Rows.Add(furnizim.ID, furnizim.fatura, dc.getFurnitorName(furnizim.furnitorID), furnizim.dataFature.ToString("dd-MM-yyyy"), furnizim.Total);
                }
            }
            else if (FurnitorComboBox.SelectedIndex > 0)
            {
                string furnitorEmer = FurnitorComboBox.SelectedItem.ToString();

                int furnitorID = dc.getFurnitorID(furnitorEmer);

                foreach (DataModel furnizim in dc.ngarkoFurnizimetNgaFurnitor(furnitorID))
                {
                    furnizimDataGrid.Rows.Add(furnizim.ID, furnizim.fatura, dc.getFurnitorName(furnizim.furnitorID), furnizim.dataFature.ToString("dd-MM-yyyy"), furnizim.Total);
                }
            }




        }

        
    }
}
