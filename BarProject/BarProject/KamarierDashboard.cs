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
using System.IO;

namespace BarProject
{
    public partial class KamarierDashboard : Form
    {
        public UserModel user = new UserModel();
        public KamarierDashboard(UserModel userModel)
        {
            InitializeComponent();

            user = userModel;
        }

        DataController dc = new DataController();

        DataModel selectedTavoline = new DataModel();
        DataModel selectedShitje = new DataModel();

        private void KamarierDashboard_Load_1(object sender, EventArgs e)
        {

            this.CredentialLabel.Text = user.Emri + "(kamarier)";
            int id = dc.getKamarierID(user.Emri);

            ArrayList tavolinat = dc.ngarkoTavolinaSipasID(id);

            //sigurohemi qe nuk eshte e selektuar asnje tavoline gjate ekzekutimit 
            //ne menyre qe te mos kemi konflikte
            selectedTavoline = new DataModel();

            selectedShitje = new DataModel();

            foreach(DataModel tavoline in tavolinat)
            {
                Button btn = new Button();
                btn.Text = tavoline.Emri;
                btn.Size = new System.Drawing.Size(80, 80);

                if (tavoline.tavolineZene)
                    btn.BackColor = Color.Red;
                else
                    btn.BackColor = Color.Green;


                btn.Tag = tavoline.ID;

                tavolinatPanel.Controls.Add(btn);

                btn.Click += TavolineButtonClick;
            }



            ArrayList kategorite = dc.ngarkoKategorite();

            foreach(DataModel kategori in kategorite)
            {
                Button btn = new Button();
                btn.Text = kategori.Emri;
                btn.Size = new System.Drawing.Size(80, 80);
                btn.BackColor = Color.Beige;
                btn.Tag = kategori.ID;

                kategoritePanel.Controls.Add(btn);

                btn.Click += KategoriButtonClick;
            }

        }


       

        void KategoriButtonClick(object sender, EventArgs e)
        {
            produktetPanel.Controls.Clear();

            Button btn = (Button)sender;

            int kategoriID = Convert.ToInt32(btn.Tag);

            ArrayList produktet = dc.ngarkoProduktetNgaKategoria(kategoriID);

            foreach(DataModel produkt in produktet)
            {
                Button produktButton = new Button();
                produktButton.Text = produkt.Emri;
                produktButton.Size = new System.Drawing.Size(80, 80);
                produktButton.BackColor = Color.Beige;
                produktButton.Tag = produkt.ID;

                produktetPanel.Controls.Add(produktButton);

                produktButton.Click += ProduktButton_Click;

            }


        }


        void TavolineButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int tavolineID = Convert.ToInt32(btn.Tag);

            DataModel currentTavoline = dc.getTavoline(tavolineID);

            if (currentTavoline.tavolineZene)
            {
                //merret shitja by tavolineID & fatureHapur dhe te gjithe produktet per ate shitje  

                DataModel currentShitje = dc.getShitjeNgaTavolina(currentTavoline.ID);
                ArrayList produkteShitje = dc.ngarkoProdukteNgaShitje(currentShitje.ID);

                selectedShitje = currentShitje;

                produkteDataGrid.Rows.Clear();

                foreach(DataModel produkt in produkteShitje)
                {
                    produkteDataGrid.Rows.Add(produkt.ID, produkt.Emri, produkt.Cmimi, produkt.Sasia, produkt.Total);
                }

                selectedTavoline = currentTavoline;

            }
            else if (!currentTavoline.tavolineZene)
            {
                if(MessageBox.Show("Rezervo Tavoline?", "Rezervim tavoline.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    

                    if (dc.rezervoTavolin(currentTavoline.ID))
                    {
                        //te krijohet nje shitje me shitje nr, kamarier ID fature e hapur true, tavoline id = currentTavolineID

                        DataModel shitjeRe = new DataModel();
                        shitjeRe.ShitjeNr = "Shitje" + Convert.ToString(DateTime.Now);
                        shitjeRe.KamarierID = user.ID;
                        shitjeRe.fatureHapur = true;
                        shitjeRe.tavolineID = currentTavoline.ID;
                        shitjeRe.ShitjeData = DateTime.Now;
                        shitjeRe.Total = Convert.ToDecimal(0.00);

                        dc.shtoShitje(shitjeRe);

                        shitjeRe.ID = dc.getLatestIDShitje();



                        MessageBox.Show("Tavolina u rezervua");
                        btn.BackColor = Color.Red;

                        selectedTavoline = currentTavoline;
                        selectedShitje = shitjeRe;

                        produkteDataGrid.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tavolina nuk u rezervua");
                    }

                    
                }

            }

        }


        void ProduktButton_Click(object sender, EventArgs e)
        {
            //te shtohet shitjeProdukt

            //ne fillimi shikohet nqs ekziston  produkt ne databaze per ate shitje
            //nqs eksziston updatohet sasia dhe totali ne databaze dhe ne datagrid
            //nqs nuk ekziston krijohet nje produktShitje i ri ne databaze dhe shtohet ky ne datagrid
            //




            Button ProduktButton = sender as Button;

            int produktID = Convert.ToInt32(ProduktButton.Tag);

            DataModel produkt = dc.getProdukt(produktID);

            if (selectedShitje.ID <= 0 && selectedTavoline.ID <= 0)
            {
                MessageBox.Show("Zgjidhni nje tavoline fillimisht!");
                return;
            }


            if (dc.produktShitjeEkziston(selectedShitje.ID, produkt.Emri))
            {

                DataModel currentProduktShitje = dc.getProduktShitjeByName(produkt.Emri);

                int rowIndex = 0;

                foreach (DataGridViewRow rowD in produkteDataGrid.Rows)
                {
                    if (Convert.ToInt32(rowD.Cells["ID"].Value) == produktID)
                    {
                        rowIndex = rowD.Index;
                    }
                }
                currentProduktShitje.Sasia++;
                currentProduktShitje.Total = currentProduktShitje.Sasia * currentProduktShitje.Cmimi;


                if (dc.editSasiProduktShitje(currentProduktShitje))
                {
                    int sasia = Convert.ToInt32(produkteDataGrid.Rows[rowIndex].Cells["SasiProdukt"].Value);
                    decimal cmimi = Convert.ToInt32(produkteDataGrid.Rows[rowIndex].Cells["CmimProdukt"].Value);

                    sasia++;

                    decimal total = Convert.ToDecimal(sasia * cmimi);


                    produkteDataGrid.Rows[rowIndex].Cells["SasiProdukt"].Value = sasia;
                    produkteDataGrid.Rows[rowIndex].Cells["TotalProdukt"].Value = total;

                    totalBox.Text = Convert.ToString(llogaritTotalFature());

                }


            }
            else
            {
                DataModel newProduktShitje = new DataModel();


                newProduktShitje.Emri = produkt.Emri;
                newProduktShitje.Cmimi = produkt.Cmimi;
                newProduktShitje.Sasia = 1;
                newProduktShitje.Total = 1 * produkt.Cmimi;
                newProduktShitje.ShitjeID = selectedShitje.ID;

                if (dc.shtoProduktShitje(newProduktShitje))
                {
                    newProduktShitje.ID = dc.getLatestProduktShitjeID();
                    produkteDataGrid.Rows.Add(newProduktShitje.ID, newProduktShitje.Emri, newProduktShitje.Cmimi, newProduktShitje.Sasia, newProduktShitje.Total);
                }


                totalBox.Text = Convert.ToString(llogaritTotalFature());
            }


        }

        public decimal llogaritTotalFature()
        {
            decimal totalFature = 0;

            foreach (DataGridViewRow row in produkteDataGrid.Rows)
            {
                decimal produktTotal = Convert.ToDecimal(row.Cells["TotalProdukt"].Value);

                totalFature = totalFature + produktTotal;
            }

            return totalFature;
        }




        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Konfirmoni mbylljen?", "Kujdes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                selectedShitje.Total = llogaritTotalFature();
                selectedShitje.fatureHapur = false;
                selectedShitje.ShitjeData = DateTime.Now;
                selectedShitje.KamarierID = user.ID;

                selectedTavoline.tavolineZene = false;


                if (dc.mbyllShitje(selectedShitje) && dc.mbyllTavoline(selectedTavoline))
                {
                    MessageBox.Show("Shitja u mbyll!");
                    selectedShitje = new DataModel();
                    selectedTavoline = new DataModel();

                    tavolinatPanel.Controls.Clear();

                    foreach (DataModel tavoline in dc.ngarkoTavolinaSipasID(user.ID))
                    {
                        Button btn = new Button();
                        btn.Text = tavoline.Emri;
                        btn.Size = new System.Drawing.Size(80, 80);

                        if (tavoline.tavolineZene)
                            btn.BackColor = Color.Red;
                        else
                            btn.BackColor = Color.Green;


                        btn.Tag = tavoline.ID;

                        tavolinatPanel.Controls.Add(btn);

                        btn.Click += TavolineButtonClick;
                    }

                    produkteDataGrid.Rows.Clear();



                }


            }



        }

        private void produkteDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (produkteDataGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Vazhdoni me fshirjen?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int produktShitjeID = Convert.ToInt32(produkteDataGrid.Rows[e.RowIndex].Cells["ID"].Value);

                        if(dc.fshiProduktShitje(produktShitjeID))
                        {
                            MessageBox.Show("Fshirja u krye");
                            produkteDataGrid.Rows.RemoveAt(e.RowIndex);

                            totalBox.Text = Convert.ToString(llogaritTotalFature());
                        }

                    }
                }
            }
        }










    }
}
