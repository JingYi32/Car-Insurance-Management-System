using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    public partial class Searching_Page : Form
    {
        public Searching_Page()
        {
            InitializeComponent();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Main_Page mainMenu = new Main_Page();
            this.Hide();
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Profile customer_Profile = new Customer_Profile();
            this.Hide();
            customer_Profile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insurance_Details insurance_Details = new Insurance_Details();
            this.Hide();
            insurance_Details.Show();
        }

        private void lblLoginWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
