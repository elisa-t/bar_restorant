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
    public partial class Regjistrim : Form
    {
        public Regjistrim()
        {
            InitializeComponent();
        }

        private void RegjistrohuButton_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();
            userModel.Emri = EmriBox.Text;
            userModel.Email = EmailBox.Text;
            userModel.Password = PasswordBox.Text;
            userModel.Roli = RoliBox.Text;

            DataController dataController = new DataController();

            if (dataController.regjistroPerdorues(userModel))
            {
                UserModel user = dataController.returnUserID(userModel.Email);

                if (user.Roli.Equals("manaxher"))
                {
                    ManagerDashboard managerDashboard = new ManagerDashboard(user);
                    this.Hide();
                    managerDashboard.Show();
                }
                else if (user.Roli.Equals("kamarier"))
                {
                    KamarierDashboard kamarierDashboard = new KamarierDashboard(user);
                    this.Hide();
                    kamarierDashboard.Show();
                }
            }
            else MessageBox.Show("Regjistrim pa sukses!");

        }

        private void Regjistrim_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();

        }

    }
}
