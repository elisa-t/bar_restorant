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
    public partial class Furnizim : Form
    {
        public Furnizim()
        {
            InitializeComponent();
        }

        private void ShtoFurnitorButton_Click(object sender, EventArgs e)
        {
            ShtoFurnizim form = new ShtoFurnizim();
            this.Close();
            form.Show();
        }
    }
}
