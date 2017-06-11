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

        private void KamarierDashboard_Load_1(object sender, EventArgs e)
        {

            this.CredentialLabel.Text = user.Emri;

            ArrayList tavolinat = dc.ngarkoTavolina();

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
                btn.ForeColor = Color.White;

                MemoryStream ms = new MemoryStream(kategori.Foto);
                btn.Image = Image.FromStream(ms);
                btn.Image = new Bitmap(btn.Image, btn.Size);

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
                produktButton.ForeColor = Color.White;

                MemoryStream ms = new MemoryStream(produkt.Foto);
                produktButton.Image = Image.FromStream(ms);
                produktButton.Image = new Bitmap(produktButton.Image, produktButton.Size);

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

            }
            else if (!currentTavoline.tavolineZene)
            {
                if(MessageBox.Show("Rezervo Tavoline?", "Rezervim tavoline.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    

                    if (dc.rezervoTavolin(currentTavoline.ID))
                    {
                        //te krijohet nje shitje me shitje nr, kamarier ID fature e hapur true, tavoline id = currentTavolineID

                        MessageBox.Show("Tavolina u rezervua");
                        btn.BackColor = Color.Red;
                    }
                    else
                    {
                        MessageBox.Show("Tavolina nuk u rezervua");
                    }

                    selectedTavoline = currentTavoline;
                }

            }




        }


        void ProduktButton_Click(object sender, EventArgs e)
        {
            //te shtohet shitjeProdukt
        }


    }
}
