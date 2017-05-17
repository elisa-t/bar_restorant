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
    public partial class KategoriForm : Form
    {
        UserModel user = new UserModel();

        public KategoriForm(UserModel userModel)
        {
            InitializeComponent();

            user = userModel;

            DataController dataController = new DataController();
        }

        private void ShtoKategoriButton_Click(object sender, EventArgs e)
        {
            ShtoKategoriForm shtoKategoriForm = new ShtoKategoriForm();

            shtoKategoriForm.Show();
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            DataController dc = new DataController();

            foreach (DataModel kategori in dc.ngarkoKategorite())
            {
                KategoriListDataGridView.Rows.Add(kategori.ID, kategori.Emri, kategori.Foto);
            }
        }

        private void KategoriListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (KategoriListDataGridView.Columns[e.ColumnIndex].Name == "DeleteKategori")
                {
                    if (MessageBox.Show("Konfirmoni fshirjen?", "Kujdes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int kategoriID = Convert.ToInt32(KategoriListDataGridView.Rows[e.RowIndex].Cells["KategoriID"].Value);

                        DataController dc = new DataController();

                        if (dc.fshiKategori(kategoriID))
                        {
                            MessageBox.Show("Kategoria u fshi");
                            KategoriListDataGridView.Rows.RemoveAt(e.RowIndex);
                        }
                        else if(!dc.fshiKategori(kategoriID))
                        {
                            MessageBox.Show("Kategoria nuk u fshi!");
                        }

                    }
                }
                else if (KategoriListDataGridView.Columns[e.ColumnIndex].Name == "ViewKategori")
                {

                    DataModel kategori = new DataModel();
                    int kategoriID  = Convert.ToInt32(KategoriListDataGridView.Rows[e.RowIndex].Cells["KategoriID"].Value);

                    DataController dc = new DataController();

                    kategori = dc.getKategori(kategoriID);

                    ViewKategoriForm viewKategori = new ViewKategoriForm(kategori);

                    viewKategori.Show();
                }
                else if (KategoriListDataGridView.Columns[e.ColumnIndex].Name == "EditKategori")
                {
                    DataModel kategoria = new DataModel();
                    int Id = Convert.ToInt32(KategoriListDataGridView.Rows[e.RowIndex].Cells["KategoriID"].Value);

                    DataController dc = new DataController();

                    kategoria = dc.getKategori(Id);

                    EditKategoriForm editKategoriForm = new EditKategoriForm(kategoria);

                    editKategoriForm.Show();


                }
            }
        }
    }
}
