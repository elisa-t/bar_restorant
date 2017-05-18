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
    public partial class TavolinaForm : Form
    {
        public TavolinaForm()
        {
            InitializeComponent();
            DataController dataController = new DataController();
        }

        private void ShtoTavolinaButton_Click(object sender, EventArgs e)
        {
            ShtoTavolinaForm shtoTavolinaForm = new ShtoTavolinaForm();
            shtoTavolinaForm.Show();
            this.Close();
        }

        private void TavolinaForm_Load(object sender, EventArgs e)
        {
           
            DataController datacontroller = new DataController();

            foreach (DataModel tavolina in datacontroller.ngarkoTavolina())
            {
                TavolineGridView.Rows.Add(tavolina.ID, tavolina.Emri);
            }
           }

        private void TavolineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0) 
            {
                if (TavolineGridView.Columns[e.ColumnIndex].Name == "deleteTavoline") 
                {
                    if(MessageBox.Show("Konfirmoni fshirjen?", "Kujdes", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        int ID = Convert.ToInt32(TavolineGridView.Rows[e.RowIndex].Cells["idTavoline"].Value);
                        DataController dataController = new DataController();
                        if (dataController.fshiTavolina(ID)) 
                        {
                            TavolineGridView.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Tavolina u fshi");
                        }
                        else if (!dataController.fshiTavolina(ID))
                        {
                            MessageBox.Show("Tavolina nuk u fshi");
                        }
                    }
                }

                else if (TavolineGridView.Columns[e.ColumnIndex].Name == "editTavoline")
                {
                    DataModel tavolineModel = new DataModel();
                    int Id = Convert.ToInt32(TavolineGridView.Rows[e.RowIndex].Cells["idTavoline"].Value);
                    DataController dataController = new DataController();

                    tavolineModel = dataController.getTavoline(Id);
                    EditTavoline editTavoline = new EditTavoline(tavolineModel);
                    editTavoline.Show();
                }
            }
            
        }


    }
}
