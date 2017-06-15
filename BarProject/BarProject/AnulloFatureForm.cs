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
    public partial class AnulloFatureForm : Form
    {
        public AnulloFatureForm()
        {
            InitializeComponent();
        }

        ArrayList shitjetList = new ArrayList();

        DataController dc = new DataController();

        private void AnulloFatureForm_Load(object sender, EventArgs e)
        {
            shitjetList = dc.ngarkoShitjePerAnullim();

            foreach (DataModel shitje in shitjetList)
            {
                AnulloDataGrid.Rows.Add(shitje.ID, shitje.emerProdukt, shitje.ShitjeData.ToString("dd-MM-yyyy"), shitje.emerKamarier, shitje.Total, shitje.emerTavoline);
            }

        }

        private void AnulloDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (AnulloDataGrid.Columns[e.ColumnIndex].Name == "AnulloColumn")
                {
                    if (MessageBox.Show("Annullo shitje?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int ID = Convert.ToInt32(AnulloDataGrid.Rows[e.RowIndex].Cells["ID"].Value);
                        if (dc.fshiProduktShitjeSipasShitjes(ID))
                        {
                            if ( dc.fshiShitje(ID))
                            {
                               
                                AnulloDataGrid.Rows.RemoveAt(e.RowIndex);
                                MessageBox.Show("Shitja u anullua");

                            }
                            else
                            {
                                MessageBox.Show("Shitja nuk u anullua!");
                            }
                                
                        }
                    }
                }
            }
        }














    }
}
