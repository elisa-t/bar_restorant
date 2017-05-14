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
    }
}
