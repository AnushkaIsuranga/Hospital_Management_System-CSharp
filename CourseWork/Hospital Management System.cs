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
    public partial class ManagmentPg : Form
    {
        public ManagmentPg()
        {
            InitializeComponent();
        }

        private void showThisForm(object form)
        {
            Form frm = form as Form;
            frm.TopLevel = false;
            pContainer.Controls.Clear();
            pContainer.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            pContainer.Tag = frm;
            frm.Show();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            showThisForm(new Patients());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            showThisForm(new Doctors());
        }

        private void btnWards_Click(object sender, EventArgs e)
        {
            showThisForm(new Wards());
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            showThisForm(new Medicine());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            LoginPg signIn = new LoginPg();
            if(MessageBox.Show("Do you want to sign out?") == DialogResult.OK)
            {
                signIn.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Hospital_Management_System_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnNurses_Click(object sender, EventArgs e)
        {
            showThisForm(new Nurses());
        }

        private void btnAttendants_Click(object sender, EventArgs e)
        {
            showThisForm(new Attendants());
        }

        private void btnLabors_Click(object sender, EventArgs e)
        {
            showThisForm(new Labors());
        }
    }
}
