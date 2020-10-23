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
    public partial class Renewal_of_Insurance : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        private void Renewal_of_Insurance_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();

            cmd.CommandText = "SELECT Insurance.*, Vehicle.*, Owner.*, Customer.* FROM ((Insurance INNER JOIN Vehicle ON Insurance.Vehicle_RegistrationNo = Vehicle.Vehicle_RegistrationNo) INNER JOIN Owner ON Insurance.Owner_IC = Owner.Owner_IC) INNER JOIN Customer ON Customer.ID = Insurance.CustomerID WHERE Insurance.ID = " + Save.insuranceid + "";
            cmd.Connection = con;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblShowIns_ID.Text = ":  " + dr[0].ToString();
                lblShowVehicle_NO.Text = ":  " + dr[13].ToString();
                lblShowCust_ID.Text = ":  " + dr[1].ToString();
                lblShowCust_Name.Text = ":  " + dr[25].ToString() + dr[26].ToString();
                lblShowOwner_Name.Text = ":  " + dr[19].ToString() + dr[20].ToString();
                lblShowIns_PurcDate.Text = ":  " + dr[3].ToString();
                lblShowIns_Last_Renewal.Text = ":  " + dr[4].ToString();
                lblShowIns_EndDate.Text = ":  " + dr[5].ToString();
                lblShowIns_Type.Text = ":  " + dr[6].ToString();
                DateTime localDate = DateTime.Now;
                lblShowIns_StartDate.Text = ":  " + localDate.ToString();
                lblShowIns_NewEndDate.Text = ":  " + localDate.AddYears(1).ToString();
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
            dr.Close();
        }
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
