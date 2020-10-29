using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void btnMenu(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.comfirm();
        }

        private void btnRegisterNewAccount(object sender, EventArgs e)
        {
            Registration_Form register = new Registration_Form();
            this.Hide();
            register.Show();
        }

        private void btnMyProfile(object sender, EventArgs e)
        {
            Profile_of_Staff s_profile = new Profile_of_Staff();
            this.Hide();
            s_profile.Show();
        }

        private void btnRegisterPolicy(object sender, EventArgs e)
        {
            Purrchase_New_Policy purchase_new_policy = new Purrchase_New_Policy();
            this.Hide();
            purchase_new_policy.Show();
        }

        private void btnLogOut(object sender, EventArgs e)
        {
            string message = "Do you want to log out from your account? Once you log out, you need to log in again.";
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Login_Page login = new Login_Page();
                this.Hide();
                login.Show();
            }
            else
            {
                // Do something  
            }
        }

        private void btnSearch(object sender, EventArgs e)
        {
            Searching_Page search = new Searching_Page();
            this.Hide();
            search.Show();
        }
    }
}
