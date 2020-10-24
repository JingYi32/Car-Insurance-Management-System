using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    public partial class Total_Payable_Amount_of_Insurance : Form
    {
        OleDbConnection conTA = new OleDbConnection();
        OleDbCommand cmdTA = new OleDbCommand();

        public Total_Payable_Amount_of_Insurance()
        {
            InitializeComponent();
        }

        private void btnBack_TA_Click(object sender, EventArgs e)
        {
            Main_Page main_page = new Main_Page();
            main_page.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Total_Payable_Amount_of_Insurance_Load(object sender, EventArgs e)
        {
            conTA.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            conTA.Open();

            Calculate();//call statement

        }

        private void btnSave_TA_Click(object sender, EventArgs e)
        {
            cmdTA.CommandText = "insert into insurance VALUES('ID', 'Customer ID', 'Status', 'Purchase Date', 'Last renewal date', 'End Date', 'ins type', 'gross total', 'sst', '10', 'total', 'own_ic', 'vehicleregitrationno')";
            cmdTA.Connection = conTA;
            cmdTA.ExecuteNonQuery();
        }

        private void Calculate()
        {
            double premT_TP = Select_Type_of_Insurance.premiumTotal;
            lblRMInsuranceTotal.Text = "RM" + premT_TP;

            double sst_TP = premT_TP * 0.06;
            lblSSTCount.Text = "RM" + sst_TP;

            double value = 0;
            CalculateNCD(ref value);
            double NCD_TP = premT_TP * value;
            lblRM_NCD.Text = "RM" + NCD_TP;

            double Total_TP = premT_TP + sst_TP + 10 + NCD_TP;
            lblRMtotal.Text = "RM" + Total_TP;

            //Havent save into database
        }

        private void CalculateNCD(ref double NCD)
        {
            cmdTA.CommandText = "select count (*) as 'year' from insurance where id = '"+Save.insuranceid+"'";
            cmdTA.Connection = conTA;
            
            double year = (double)cmdTA.ExecuteScalar();

            
            if (year == 1)
                NCD = 0.25;
            else if (year == 2)
                NCD = 0.30;
            else if (year == 3)
                NCD = 0.3833;
            else if (year == 4)
                NCD = 0.45;
            else if (year >= 5)
                NCD = 0.55;
            else
                NCD = 0;

        }

    }
}
