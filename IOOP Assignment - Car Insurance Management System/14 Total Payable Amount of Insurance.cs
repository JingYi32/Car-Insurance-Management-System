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

        private void Total_Payable_Amount_of_Insurance_Load(object sender, EventArgs e)
        {
            conTA.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            conTA.Open();

            lblCustomerID_TA.Text = "Customer ID: " + Save.customerid;
            lblCustomerName_TA.Text = "Insurance ID: " + Save.insuranceid;

            Calculate();
        }


        //
        //buttons
        //

        private void btnBack_TA_Click(object sender, EventArgs e)
        {
            Main_Page main_page = new Main_Page();
            main_page.Show();
            this.Hide();
        }

        private void btnSave_TA_Click(object sender, EventArgs e)
        {
            //Purchase new insurance
            if (Save.CountTotalINS==0)
            {
                //owner and vehicle exist
                if (Save.CountOwn != 0 && Save.CountVehicle != 0)
                {
                    cmdTA.CommandText = "insert into insurance (ID, Cust_ID, Ins_status, Ins_PurchasedDate, Ins_LastRenewalDate, Ins_EndDate, Ins_Type, Ins_GrossTotal, Ins_SST, Ins_StampDuty, Ins_Total, Owner_IC, Vehicle_RegistrationNo) VALUES('"+Save.insuranceid+"', '"+Save.customerid+"', 'Processing', '"+Save.Today+"', '"+Save.Today+"', '"+Save.RenewalEndDate+"', '"+Save.InsType+"', '"+Save.GrossTotal+"', '"+Save.SST+"', '10', '"+Save.Total+"', '"+Save.Owner_IC+"', '"+Save.Vehicle_NO+"')";
                    cmdTA.Connection = conTA;
                    cmdTA.ExecuteNonQuery();
                }

                //owner details has been saved before
                else if (Save.CountOwn!=0)
                {
                    cmdTA.CommandText = "insert into insurance (ID, Cust_ID, Ins_status, Ins_PurchasedDate, Ins_LastRenewalDate, Ins_EndDate, Ins_Type, Ins_GrossTotal, Ins_SST, Ins_StampDuty, Ins_Total, Owner_IC, Vehicle_RegistrationNo) VALUES('" + Save.insuranceid+"', '"+Save.customerid+"', 'Processing', '"+Save.Today+"', '"+Save.Today+"', '"+Save.RenewalEndDate+"', '"+Save.InsType+"', '"+Save.GrossTotal+"', '"+Save.SST+"', '10', '"+Save.Total+"', '"+Save.Owner_IC+"', '"+Save.Vehicle_NO+"')"; 
                    cmdTA.Connection = conTA;
                    cmdTA.ExecuteNonQuery();
                    cmdTA.CommandText = "insert into vehicle VALUES ('" + Save.Vehicle_NO + "', '" + Save.Vehicle_Brand + "', '" + Save.Vehicle_Model + "', '" + Save.Vehicle_YOM + "', '" + Save.Vehicle_Price + "')";
                    cmdTA.Connection = conTA;
                    cmdTA.ExecuteNonQuery();
                }

                //including owner details
                else if (Save.CountOwn==0)
                {
                    //Insurance Table
                    cmdTA.CommandText = "insert into Insurance (ID, Cust_ID, Ins_status, Ins_PurchasedDate, Ins_LastRenewalDate, Ins_EndDate, Ins_Type, Ins_GrossTotal, Ins_SST, Ins_StampDuty, Ins_Total, Owner_IC, Vehicle_RegistrationNo) VALUES('" + Save.insuranceid + "', '" + Save.customerid + "', 'Processing', '" + Save.purchasedate + "', '" + Save.lastrenewaldate + "', '" + Save.enddate + "', '" + Save.InsType + "', '" + Save.GrossTotal + "', '" + Save.SST + "', '10', '" + Save.Total + "', '" + Save.Owner_IC + "', '" + Save.Vehicle_NO + "')"; 
                    cmdTA.Connection = conTA;
                    cmdTA.ExecuteNonQuery();
                    //Owner Table
                    cmdTA.CommandText = "INSERT INTO Owner VALUES ('" + Save.Owner_IC + "', '" + Save.Owner_Name + "', '" + Save.Owner_Gender + "', '" + Save.Owner_Phone + "', '" + Save.Owner_Address + "')";
                    cmdTA.Connection = conTA;
                    cmdTA.ExecuteNonQuery();
                    //Vehicle Table
                    cmdTA.CommandText= "insert into vehicle VALUES ('" + Save.Vehicle_NO + "', '" + Save.Vehicle_Brand + "', '" + Save.Vehicle_Model + "', '" + Save.Vehicle_YOM + "', '" + Save.Vehicle_Price + "')";
                    cmdTA.Connection = conTA;
                    cmdTA.ExecuteNonQuery();
                }
                    
                
            }

            //Renew insurance
            //does not need to include vehicle n owner
            else if (Save.CountTotalINS!=0)
            {             
                cmdTA.CommandText = "update insurance SET Ins_LastRenewalDate = '"+Save.RenewalDate+"' ，Ins_EndDate = '"+Save.RenewalEndDate+"', Ins_Total ='"+Save.Total+"' WHERE id = '"+Save.insuranceid+"'";
                cmdTA.Connection = conTA;
                cmdTA.ExecuteNonQuery();
            }
            MessageBox.Show("Save Successfully.");
            Main_Page mp = new Main_Page();
            mp.Show();
            this.Close();
        }

        //
        //Methods
        //

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
                Save.CountOwn = int.Parse(drOwn[0].ToString());
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
