using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }


        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        public void days (int numday)
        {
            dailys.Text = numday + "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
