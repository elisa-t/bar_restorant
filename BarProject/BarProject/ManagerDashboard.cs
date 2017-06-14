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
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard(UserModel userModel)
        {
            InitializeComponent();

            user = userModel;

            DataController dataController = new DataController();
            
        }

       public  UserModel user = new UserModel();

       private void KategoriButton_Click(object sender, EventArgs e)
       {
           KategoriForm kategori = new KategoriForm();

           kategori.Show();

       }

       private void TavolineButton_Click(object sender, EventArgs e)
       {
           TavolinaForm tavolina = new TavolinaForm();
           tavolina.Show();
       }

       private void FurnitorButton_Click(object sender, EventArgs e)
       {
           FurnitorForm furnitor = new FurnitorForm();
           furnitor.Show();
       }

       private void LogoutButton_Click(object sender, EventArgs e)
       {
           Login login = new Login();
           this.Close();
           login.Show();
       }

       private void ManagerDashboard_Load(object sender, EventArgs e)
       {
           this.CredentialLabel.Text = user.Emri + "(menaxher)";
       }

       private void ProduktButton_Click(object sender, EventArgs e)
       {
           ProduktForm produktForm = new ProduktForm();
           produktForm.Show();
       }

       private void FurnizimButton_Click(object sender, EventArgs e)
       {
           Furnizim form = new Furnizim();
           form.Show();

       }

       private void ShitjeButton_Click(object sender, EventArgs e)
       {
           ShitjeForm shitjeForm = new ShitjeForm();
           shitjeForm.Show();
       }
    }
}
