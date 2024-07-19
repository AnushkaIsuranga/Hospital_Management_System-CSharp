using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class LoginPg : Form
    {
        public LoginPg()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = Convert.ToString(txtUser.Text);
            string password = Convert.ToString(txtPass.Text);

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Success!");
                ManagmentPg management_System = new ManagmentPg();
                management_System.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }
        }

        private void LoginPg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void LoginPg_MaximumSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
