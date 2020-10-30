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
            //new insurance
            if (Save.CountTotalINS==0)
            {
                //owner and vehicle exist
                if (Save.CountOwn != 0 && Save.CountVehicle != 0)
                {
                    cmdTA.CommandText = "insert into insurance VALUES('"+Save.insuranceid+"', '"+Save.customerid+"', 'Processing', '"+Save.purchasedate+"', '"+Save.RenewalDate+"', '"+Save.RenewalEndDate+"', '"+Save.InsType+"', '"+Save.GrossTotal+"', '"+Save.SST+"', '10', '"+Save.Total+"', '"+Save.Owner_IC+"', '"+Save.Vehicle_NO+"')";
                    cmdTA.Connection = conTA;
                    cmdTA.ExecuteNonQuery();
                }

                //owner details has been saved before
                else if (Save.CountOwn!=0)
                {
                    cmdTA.CommandText = "insert into insurance VALUES('"+Save.insuranceid+"', '"+Save.customerid+"', 'Processing', '"+Save.purchasedate+"', '"+Save.RenewalDate+"', '"+Save.RenewalEndDate+"', '"+Save.InsType+"', '"+Save.GrossTotal+"', '"+Save.SST+"', '10', '"+Save.Total+"', '"+Save.Owner_IC+"', '"+Save.Vehicle_NO+"'); insert into vehicle VALUES ('"+Save.Vehicle_NO+"', '"+Save.Vehicle_Brand+"', '"+Save.Vehicle_Model+"', '"+Save.Vehicle_YOM+"', '"+Save.Vehicle_Price+"')";
                    cmdTA.Connection = conTA;
                    cmdTA.ExecuteNonQuery();
                }

                //including owner details
                else if (Save.CountOwn==0)
                {
                    cmdTA.CommandText = "insert into insurance VALUES('"+Save.insuranceid+"', '" + Save.customerid + "', 'Processing', '"+Save.purchasedate+"', '"+Save.RenewalDate+"', '"+Save.RenewalEndDate+"', '"+Save.InsType+"', '"+Save.GrossTotal+"', '"+Save.SST+"', '10', '"+Save.Total+"', '"+Save.Owner_IC+"', '"+Save.Vehicle_NO+"'); insert into owner VALUES ('"+Save.Owner_IC+"’, '"+Save.Owner_Name+"', '"+Save.Owner_Gender+"', '"+Save.Owner_Phone+"', '"+Save.Owner_Address+"'); insert into vehicle VALUES ('" + Save.Vehicle_NO + "', '" + Save.Vehicle_Brand + "', '" + Save.Vehicle_Model + "', '" + Save.Vehicle_YOM + "', '" + Save.Vehicle_Price + "')";
                    cmdTA.Connection = conTA;
                    cmdTA.ExecuteNonQuery();
                }
                    
                
            }

            //old insurance
            //does not need to include vehicle n owner
            else if (Save.CountTotalINS!=0)
            {
                Save.RenewalStartDate = Save.enddate;
                Save.RenewalEndDate =Save.RenewalStartDate.AddYears(1);
                MessageBox.Show(Save.RenewalEndDate.ToString());
                cmdTA.CommandText = "update into insurance SET Ins_LastRenewalDate = '"+Save.Today+"' ，Ins_EndDate = '"+Save.RenewalEndDate+"' WHERE id = '"+Save.insuranceid+"'";
                cmdTA.Connection = conTA;
                cmdTA.ExecuteNonQuery();
            }
            MessageBox.Show("Save Successfully.");
            Main_Page mp = new Main_Page();
            mp.Show();
            this.Close();
        }

        private void Calculate()
        {
            double premT_TP = Save.GrossTotal;
            double sst_TP = premT_TP * 0.06;

            double value = 0;
            countInDB();
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

        private void countInDB()
        {
            //New/Old Insurance
            cmdTA.CommandText = "select count(*) from insurance where id = '"+Save.insuranceid+"'";
            cmdTA.Connection = conTA;
            OleDbDataReader drNewOrOld = cmdTA.ExecuteReader();
            if (drNewOrOld.Read())
            {
                Save.CountTotalINS = int.Parse(drNewOrOld[0].ToString());
            }
            else
            {
                MessageBox.Show("Having problems in finding old and new insurance");
            }
            drNewOrOld.Close();

            //Claim before or not
            cmdTA.CommandText = "select count(*) from claim where InsuranceID = '"+Save.insuranceid+"'";
            cmdTA.Connection = conTA;
            OleDbDataReader drTA = cmdTA.ExecuteReader();
            if (drTA.Read())
            {
                Save.CountTotalClaim = int.Parse(drTA[0].ToString());
            }
            else
            {
                MessageBox.Show("Error Exist in drTA");
            }
            drTA.Close();

            //ensure that the owner is already exist
            cmdTA.CommandText = "select count(*) from owner where Owner_IC = '"+Save.Owner_IC+"'";
            cmdTA.Connection = conTA;
            OleDbDataReader drOwn = cmdTA.ExecuteReader();
            if(drOwn.Read())
            {
                MessageBox.Show(Save.CountOwn.ToString());
            }
            else
            {
                MessageBox.Show("Error Exist in drOwn");
            }
            drOwn.Close();

            //ensure that the vehicle is already exist
            cmdTA.CommandText = "select count(*) from vehicle where vehicle_RegistrationNo = '"+Save.Vehicle_NO+"'";
            cmdTA.Connection = conTA;
            OleDbDataReader drVehicle = cmdTA.ExecuteReader();
            if(drVehicle.Read())
            {
                Save.CountVehicle = int.Parse(drVehicle[0].ToString());
            }
            else
            {
                MessageBox.Show("Error Exist in drVehicle");
            }
            drVehicle.Close();
        }


        private void CalculateNCD(ref double NCDFinal)
        {
            
            //new insurance
            if (Save.CountTotalINS == 0)
                {
                    NCDFinal = 0;
                }
            //old insurance
            else if (Save.CountTotalINS != 0)
            {
                //not found claim insurance
                if (Save.CountTotalClaim == 0)
                {
                    NCD ncd = new NCD();
                    ncd.calculateNCD(ref NCDFinal);
                    
                }
                else if (Save.CountTotalClaim != 0)
                {
                    MessageBox.Show("This ID has been claimed the Insurance. Please Purchase New Policy.");
                    Main_Page mp = new Main_Page();
                    mp.Show();
                    this.Close();
                }
                    
            }
            
        }

    }
}
