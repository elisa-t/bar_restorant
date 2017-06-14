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
    public partial class ShitjeForm : Form
    {
        public ShitjeForm()
        {
            InitializeComponent();
        }

        DataController dc = new DataController();

        ArrayList produktetList = new ArrayList();
        ArrayList kamarierList = new ArrayList();
        ArrayList tavolinatList = new ArrayList();
        ArrayList shitjetList = new ArrayList();

        string produktEmer = string.Empty;
        int kamarierID = -1;
        int tavolineID = -1;


        DateTime dataFillim;
        DateTime dataMbarim;

        bool data1Selected = false;
        bool data2Selected = false;

        private void ShitjeForm_Load(object sender, EventArgs e)
        {
            produktetList = dc.ngarkoTeGjitheProduktetShitje();
            tavolinatList = dc.ngarkoTavolina();
            kamarierList = dc.ngarkoKamarierList();
            shitjetList = dc.ngarkoTeGjitheShitjet();


            produktDropBox.Items.Add("Zgjidh produkt");

            foreach (DataModel furnitor in produktetList)
            {
                produktDropBox.Items.Add(furnitor.Emri);
            }


            tavolineDropBox.Items.Add("Zgjidh tavoline");

            foreach (DataModel furnitor in tavolinatList)
            {
                tavolineDropBox.Items.Add(furnitor.Emri);
            }


            kamarierDropBox.Items.Add("Zgjidh tavoline");

            foreach (DataModel furnitor in kamarierList)
            {
                kamarierDropBox.Items.Add(furnitor.Emri);
            }

            foreach(DataModel shitje in shitjetList)
            {
                shitjeDataGrid.Rows.Add(shitje.ID, shitje.emerProdukt, shitje.ShitjeData.ToString("dd-MM-yyyy"), shitje.emerKamarier, shitje.Total, shitje.emerTavoline);
            }


        }

        private void produktDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //shitjeDataGrid.Rows.Clear();

            if (produktDropBox.SelectedIndex > 0)
            {
                //string produktEmer = produktDropBox.SelectedItem.ToString();

                produktEmer = produktDropBox.SelectedItem.ToString();

                //foreach (DataModel shitje in dc.ngarkoShitjeNgaProdukt(produktEmer))
                //{
                //    shitjeDataGrid.Rows.Add(shitje.ID, shitje.emerProdukt, shitje.ShitjeData.ToString("dd-MM-yyyy"), shitje.emerKamarier, shitje.Total, shitje.emerTavoline);
                //}
            }


        }

        private void kamarierDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //shitjeDataGrid.Rows.Clear();

            if (kamarierDropBox.SelectedIndex > 0)
            {
                string kamarierEmer = kamarierDropBox.SelectedItem.ToString();

                kamarierID = dc.getKamarierID(kamarierEmer);


                //foreach (DataModel shitje in dc.ngarkoShitjeNgaKamarier(kamarierID))
                //{
                //    shitjeDataGrid.Rows.Add(shitje.ID, shitje.emerProdukt, shitje.ShitjeData.ToString("dd-MM-yyyy"), shitje.emerKamarier, shitje.Total, shitje.emerTavoline);
                //}
            }


        }

        private void tavolineDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //shitjeDataGrid.Rows.Clear();

            if (tavolineDropBox.SelectedIndex > 0)
            {
                string tavolineEmer = tavolineDropBox.SelectedItem.ToString();

                tavolineID = dc.getTavolineID(tavolineEmer);


                //foreach (DataModel shitje in dc.ngarkoShitjeNgaTavoline(tavolineID))
                //{
                //    shitjeDataGrid.Rows.Add(shitje.ID, shitje.emerProdukt, shitje.ShitjeData.ToString("dd-MM-yyyy"), shitje.emerKamarier, shitje.Total, shitje.emerTavoline);
                //}
            }


        }

        private void pastroButton_Click(object sender, EventArgs e)
        {
            shitjeDataGrid.Rows.Clear();

            produktDropBox.SelectedIndex = -1;
            kamarierDropBox.SelectedIndex = -1;
            tavolineDropBox.SelectedIndex = -1;

            foreach (DataModel shitje in shitjetList)
            {
                shitjeDataGrid.Rows.Add(shitje.ID, shitje.emerProdukt, shitje.ShitjeData.ToString("dd-MM-yyyy"), shitje.emerKamarier, shitje.Total, shitje.emerTavoline);
            }



        }

        private void dataFillimPicker_ValueChanged(object sender, EventArgs e)
        {
            dataFillim = dataFillimPicker.Value;
            data1Selected = true;
        }

        private void dataMbarimPicker_ValueChanged(object sender, EventArgs e)
        {
            dataMbarim = dataMbarimPicker.Value;
            data2Selected = true;
        }

        private void kerkoButton_Click(object sender, EventArgs e)
        {

            if((data1Selected && !data2Selected) || (!data1Selected && data2Selected))
            {
                MessageBox.Show("Zgjidhni dy data!");
                return;
            }

            shitjetList = dc.ngarkoTeGjitheShitjet(produktEmer, kamarierID, tavolineID, dataFillim, dataMbarim, data1Selected, data2Selected);

            shitjeDataGrid.Rows.Clear();

            if (shitjetList != null)
            {
                foreach (DataModel shitje in shitjetList)
                {
                    shitjeDataGrid.Rows.Add(shitje.ID, shitje.emerProdukt, shitje.ShitjeData.ToString("dd-MM-yyyy"), shitje.emerKamarier, shitje.Total, shitje.emerTavoline);
                }
            }
            

        }

























    }
}
