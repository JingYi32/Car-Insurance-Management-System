using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    public partial class Insurance_Details : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        private void Insurance_Details_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();
            cmd.CommandText = "SELECT Insurance.*, Vehicle.*, Owner.* FROM (Insurance INNER JOIN Vehicle ON Insurance.Vehicle_RegistrationNo = Vehicle.Vehicle_RegistrationNo) INNER JOIN Owner ON Insurance.Owner_IC = Owner.Owner_IC WHERE Insurance.ID = '" + Save.insuranceid + "'";
            cmd.Connection = con;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblInsuranceDetails.Text = dr[0].ToString() + " 's Details";
                Save.insuranceid = dr[0].ToString();
                lblShowVehicle_NO.Text = ":  " + dr[13].ToString();
                Save.Vehicle_NO = dr[13].ToString();
                lblShowVehicle_Brand.Text = ":  " + dr[14].ToString();
                Save.Vehicle_Brand = dr[14].ToString();
                lblShowVehicle_Model.Text = ":  " + dr[15].ToString();
                Save.Vehicle_Model = dr[15].ToString();
                lblShowVehicle_YOM.Text = ":  " + dr[16].ToString();
                Save.Vehicle_YOM = int.Parse(dr[16].ToString());
                lblShowVehicle_Price.Text = ":  " + dr[17].ToString();
                Save.Vehicle_Price = int.Parse(dr[17].ToString());
                lblShowOwner_ICNumber.Text = ":  " + dr[18].ToString();
                Save.Owner_IC = dr[18].ToString();
                lblShowOwner_Name.Text = ":  " + dr[19].ToString();
                Save.Owner_Name = dr[19].ToString();
                lblShowOwner_Gender.Text = ":  " + dr[20].ToString();
                Save.Owner_Gender = dr[20].ToString();
                lblShowOwner_Phone.Text = ":  " + dr[21].ToString();
                Save.Owner_Phone = dr[21].ToString();
                lblShowOwner_Address.Text = ":  " + dr[22].ToString();
                Save.Owner_Address = dr[22].ToString();
                lblShowIns_Status.Text = ":  " + dr[2].ToString();
                Save.InsStatus = dr[2].ToString();
                lblShowIns_PurcDate.Text = ":  " + dr[3].ToString();
                Save.purchasedate = Convert.ToDateTime(dr[3].ToString());
                lblShowIns_Last_Renewal.Text = ":  " + dr[4].ToString();
                Save.lastrenewaldate = Convert.ToDateTime(dr[4].ToString());
                lblShowIns_EndDate.Text = ":  " + dr[5].ToString();
                Save.enddate = Convert.ToDateTime(dr[5].ToString());
                lblShowIns_Type.Text = ":  " + dr[6].ToString();
                Save.InsType = dr[6].ToString();
                lblShowIns_GrossTotal.Text = ":  RM " + dr[7].ToString();
                Save.GrossTotal = int.Parse(dr[7].ToString());
                lblShowIns_SST.Text = ":  RM " + dr[8].ToString();
                Save.SST = int.Parse(dr[8].ToString());
                lblShowIns_StampDuty.Text = ":  RM " + dr[9].ToString();
                lblShowIns_Total.Text = ":  RM " + dr[10].ToString();
                Save.Total = int.Parse(dr[10].ToString());
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
            dr.Close();
            
        }

        public Insurance_Details()
        {
            InitializeComponent();
        }

        //
        //Button
        //

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
