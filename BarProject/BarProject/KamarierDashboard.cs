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
    public partial class KamarierDashboard : Form
    {
        public UserModel user = new UserModel();
        public KamarierDashboard(UserModel userModel)
        {
            InitializeComponent();

            user = userModel;

            DataController dataController = new DataController();

        }

       

    }
}
