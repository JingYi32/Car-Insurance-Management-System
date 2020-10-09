﻿using System;
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

        private void button6_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.comfirm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_Form register = new Registration_Form();
            this.Hide();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile_of_Staff s_profile = new Profile_of_Staff();
            this.Hide();
            s_profile.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Insurance_Details ins_policy = new Insurance_Details();
            this.Hide();
            ins_policy.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_Page login = new Login_Page();
            this.Hide();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Searching_Page search = new Searching_Page();
            this.Hide();
            search.Show();
        }
    }
}
