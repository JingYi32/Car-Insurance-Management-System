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

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_Form Register = new Registration_Form();
            this.Hide();
            Register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile_of_Staff S_Profile = new Profile_of_Staff();
            this.Hide();
            S_Profile.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Insurance_Details In_Details = new Insurance_Details();
            this.Hide();
            In_Details.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_Page Login = new Login_Page();
            this.Hide();
            Login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Searching_Page Search = new Searching_Page();
            this.Hide();
            Search.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.comfirm();
        }

    }
}
