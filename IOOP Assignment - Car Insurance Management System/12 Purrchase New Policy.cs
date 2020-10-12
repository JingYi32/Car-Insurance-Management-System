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
    public partial class Purrchase_New_Policy : Form
    {
        public Purrchase_New_Policy()
        {
            InitializeComponent();
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnCUST_Profile_Click(object sender, EventArgs e)
        {
            Main_Page main_page = new Main_Page();
            this.Hide();
            main_page.Show();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Total_Payable_Amount_of_Insurance total_payable_amount_of_Insurance = new Total_Payable_Amount_of_Insurance();
            this.Hide();
            total_payable_amount_of_Insurance.Show();
        }
    }
}
