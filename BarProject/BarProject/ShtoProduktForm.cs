﻿using System;
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
    public partial class ShtoProduktForm : Form
    {
        public ShtoProduktForm()
        {
            InitializeComponent();
        }
        private void ShtoProduktForm_Load(object sender, EventArgs e)
        {
            DataController dc = new DataController();
            foreach( DataModel produkt in dc.ngarkoKategorite())
            {
                KategoriaComboBox.Items.Add(produkt.Emri);
            }
            KategoriaComboBox.SelectedIndex = 0;
        }

        private void ShtoProduktButton_Click(object sender, EventArgs e)
        {
            DataController dc = new DataController();
            string emri = EmerProduktBox.Text;
            decimal cmimi = Convert.ToDecimal(CmimiProduktBox.Text);
            int kategoria = dc.getKategori(KategoriaComboBox.SelectedItem.ToString());
            string pershkrimi = ProductDescriptionRBox.Text;
        
            if(dc.ShtoProdukt(emri, cmimi, kategoria, pershkrimi))
            {
                if (MessageBox.Show("Produkti u shtua") == DialogResult.OK)
                {
                    this.Close();
                    ProduktForm produkt = new ProduktForm();
                    produkt.Show();
                }
            }
            else
                if (MessageBox.Show("Produkti nuk u shtua") == DialogResult.OK) 
                {
                    this.Close();
                    ProduktForm produkt = new ProduktForm();
                    produkt.Show();
                
                }
        }



    }
}
