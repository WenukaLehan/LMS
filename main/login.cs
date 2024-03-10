using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.source_codes
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(username.Text == "admin" && password.Text == "admin")
            {
                MessageBox.Show("Login Successful");
            }else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
