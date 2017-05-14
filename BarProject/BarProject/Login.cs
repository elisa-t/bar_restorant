using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BarProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string UserEmail = UsernameBox.Text;

            if (ConfirmEmailAddress(UserEmail))
            {
                string UserPassword = PasswordBox.Text;

                if (ConfirmPassword(UserPassword))
                {
                    DataController dc = new DataController();

                    if (dc.konfirmoPerdorues(UserEmail, UserPassword))
                    {
                        //int UserID = Convert.ToInt32(dc.returnUserID(UserEmail));

                        UserModel model = dc.returnUserID(UserEmail);

                        if (model.Roli.Equals("manaxher"))
                        {
                            ManagerDashboard managerDashboard = new ManagerDashboard(model);
                            this.Hide();
                            managerDashboard.Show();

                        }
                        else if (model.Roli.Equals("kamarier"))
                        {
                            KamarierDashboard kamarierDashboard = new KamarierDashboard(model);
                            this.Hide();
                            kamarierDashboard.Show();
                        }

                    }
                    else MessageBox.Show("Password jo i sakte. Provoni perseri.");

                }
                else MessageBox.Show("Vendosni Password.");
            }
            else MessageBox.Show("Vendosni Username te sakte.");
        }

        public bool ConfirmEmailAddress(string UserEmail)
        {
            var EmailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return EmailRegex.IsMatch(UserEmail);
        }

        public bool ConfirmPassword(string UserPassword)
        {
            UserPassword = UserPassword.Trim();

            if (UserPassword == string.Empty)
            {
                return false;
            }
            else return true;
        }

        private void RegjistrohuButton_Click(object sender, EventArgs e)
        {
            Regjistrim regjistrim = new Regjistrim();
            this.Hide();
            regjistrim.Show();
        }




    }
}
