using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    public partial class Select_Type_of_Insurance : Form
    {
        public Select_Type_of_Insurance()
        {
            InitializeComponent();
        }

        private void Select_Type_of_Insurance_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_IT_Click(object sender, EventArgs e)
        {
            Purrchase_New_Policy purchase = new Purrchase_New_Policy();
            purchase.Show();
            this.Close();
        }

        
        private void btnContinue_IT_Click(object sender, EventArgs e)
        {
            Total_Payable_Amount_of_Insurance totalAmount = new Total_Payable_Amount_of_Insurance();
            totalAmount.Show();
            this.Hide();

            double insuranceType = 0;
            double marketPrice = Save.Vehicle_Price;

            InsType(ref insuranceType);
            double premiumTotal = insuranceType * marketPrice; 
            Save.GrossTotal = premiumTotal;

            MessageBox.Show("RM" + premiumTotal);
        }

        private void InsType(ref double value)
        {
            try
            {
                if (rbThirdParty.Checked)
                {   
                    value = 0.0266;
                    Save.InsType = "Third Party";
                }

                else if (rbFireTheft.Checked)
                {
                    value = 0.0275;
                    Save.InsType = "Third Party, fire and theft";
                }
                    
                else if (rbComprehensive.Checked)
                {
                    value = 0.0284;
                    Save.InsType = "Comprehensive Cover";
                }
                    
            }
            catch
            {
                MessageBox.Show("Please select the insurance type.");
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            tableLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
    }
}
