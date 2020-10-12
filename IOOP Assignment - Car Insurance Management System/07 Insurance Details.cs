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
    public partial class Insurance_Details : Form
    {
        public Insurance_Details()
        {
            InitializeComponent();
        }

        private void btnBack_Cust_Profile_Click(object sender, EventArgs e)
        {
            Customer_Profile customer_Profile = new Customer_Profile();
            this.Hide();
            customer_Profile.Show();
        }

        private void btnRenew_Ins_Click(object sender, EventArgs e)
        {
            Renewal_of_Insurance renewal_Of_Insurance = new Renewal_of_Insurance();
            this.Hide();
            renewal_Of_Insurance.Show();
        }

        private void btnCancel_Ins_Click(object sender, EventArgs e)
        {
            Cancellation_of_Insurance cancellation_Of_Insurance = new Cancellation_of_Insurance();
            this.Hide();
            cancellation_Of_Insurance.Show();
        }

        private void btnUpdate_Ins_Click(object sender, EventArgs e)
        {
            Updating_Insurance updating_Insurance = new Updating_Insurance();
            this.Hide();
            updating_Insurance.Show();
        }
    }
}
