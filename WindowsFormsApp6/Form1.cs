using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        LOgEntities db = new LOgEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var username = tbx_login.Text;
            var password = tbx_password.Text;
            if (db.Users.Any(item => item.Username == username && item.Userpassword == password))
            {
                MessageBox.Show("Login O" +
                    "ldunuz Tebrikler");
            }
            else
            {
                MessageBox.Show("Birdaha yeniden yoxlayin");
            }
        }
    }
}


