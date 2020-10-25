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

            lblCustomerID_TA.Text = "Customer ID: " + Save.customerid;
            lblCustomerName_TA.Text = "Insurance ID: " + Save.insuranceid;

            Calculate();
        }

        private void btnSave_TA_Click(object sender, EventArgs e)
        {
            string insID = Save.insuranceid;
            if (insID == "")
            {
                cmdTA.CommandText = "insert into insurance VALUES('" + Save.insuranceid + "', '" + Save.customerid + "', 'Processing', '" + Save.purchasedate + "', '" + Save.RenewalDate + "', '" + Save.RenewalEndDate + "', '" + Save.InsType + "', '" + Save.GrossTotal + "', '" + Save.SST + "', '10', '" + Save.Total + "', '" + Save.Owner_IC + "', '" + Save.Vehicle_NO + "')";
                cmdTA.Connection = conTA;
                cmdTA.ExecuteNonQuery();
            }
            else 
            {
                cmdTA.CommandText = "insert into insurance VALUES('" + Save.insuranceid + "', '" + Save.customerid + "', 'Processing', '" + Save.purchasedate + "', '" + Save.RenewalDate + "', '" + Save.RenewalEndDate + "', '" + Save.InsType + "', '" + Save.GrossTotal + "', '" + Save.SST + "', '10', '" + Save.Total + "', '" + Save.Owner_IC + "', '" + Save.Vehicle_NO + "')";
                cmdTA.Connection = conTA;
                cmdTA.ExecuteNonQuery();
            }
            
        }

        private void Calculate()
        {

            double premT_TP = Save.GrossTotal;
            double sst_TP = premT_TP * 0.06;

            double value = 0;
            CalculateNCD(ref value);
            double NCD_TP = premT_TP * value;
            double Total_TP = premT_TP + sst_TP + 10 - NCD_TP;

            Save.SST = sst_TP;
            Save.Total = Total_TP;

            lblRMInsuranceTotal.Text = "RM" + premT_TP;
            lblSSTCount.Text = "RM" + sst_TP;
            lblRM_NCD.Text = "RM" + NCD_TP;
            lblRMtotal.Text = "RM" + Total_TP;


        }

        private void CalculateNCD(ref double NCD)
        {
            string insID = Save.insuranceid;
            if (insID == "")
                NCD = 0;
            else
            {
                cmdTA.CommandText = "select count (*) from insurance where 'id = " + insID + "' ";
                cmdTA.Connection = conTA;
                OleDbDataReader dr = cmdTA.ExecuteReader();

                if (dr.Read())
                {
                    double year = double.Parse(dr[0].ToString());

                    if (year == 0)
                        NCD = 0;
                    else if (year == 1)
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
                else
                {
                    MessageBox.Show("Errors Exist");
                }
                dr.Close();
            }
            
            

            
            

        }

    }
}
