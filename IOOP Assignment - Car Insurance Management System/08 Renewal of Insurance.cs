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
    public partial class Renewal_of_Insurance : Form
    {
        public Renewal_of_Insurance()
        {
            InitializeComponent();
        }

        private void btnIns_Details_Click(object sender, EventArgs e)
        {
            Insurance_Details insurance_details = new Insurance_Details();
            this.Hide();
            insurance_details.Show();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            Total_Payable_Amount_of_Insurance total_payable_amount_Of_insurance = new Total_Payable_Amount_of_Insurance();
            this.Hide();
            total_payable_amount_Of_insurance.Show();
        }

        private void lblRenewal_Ins_Click(object sender, EventArgs e)
        {
            lblRenewal_Ins.TextAlign = (System.Drawing.ContentAlignment)HorizontalAlign.Center;
        }
    }
}
