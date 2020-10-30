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
    public partial class Cancellation_of_Insurance : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public Cancellation_of_Insurance()
        {
            InitializeComponent();
        }

        private void Cancellation_of_Insurance_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();
            cmd.CommandText = "SELECT Insurance.*, Vehicle.*, Owner.*, Customer.* FROM ((Insurance INNER JOIN Vehicle ON Insurance.Vehicle_RegistrationNo = Vehicle.Vehicle_RegistrationNo) INNER JOIN Owner ON Insurance.Owner_IC = Owner.Owner_IC) INNER JOIN Customer ON Customer.ID = Insurance.Cust_ID WHERE Insurance.ID = '" + Save.insuranceid + "'";
            cmd.Connection = con;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //Show
                lblShowIns_ID.Text = ":  " + dr[0].ToString();
                lblShowVehicle_NO.Text = ":  " + dr[15].ToString();
                lblShowCust_ID.Text = ":  " + dr[1].ToString();
                lblShowCust_Name.Text = ":  " + dr[26].ToString();
                lblShowOwner_Name.Text = ":  " + dr[21].ToString();
                lblShowIns_PurcDate.Text = ":  " + dr[3].ToString();
                lblShowIns_Last_Renewal.Text = ":  " + dr[4].ToString();
                lblShowIns_EndDate.Text = ":  " + dr[5].ToString();
                lblShowIns_CancDate.Text = ":  " + DateTime.Now.ToString();
                lblShowRefund_Percent.Text = ":  " + calcutaleRefund() * 100 + "%";
                lblShowIns_Duration.Text = ":  " + calcutaleDuration().ToString();
                string refundamount = (Save.Total - calcutaleRefund()).ToString();
                lblShowRefund_Premium.Text = ":  RM " + refundamount;
                //Save
                Save.CancelDate = DateTime.Now;
                Save.RefundAmount = refundamount;

            }
            else
            {
                MessageBox.Show("Record not found.");
            }
            dr.Close();
        }

        private double calcutaleRefund()
        {
            TimeSpan span = DateTime.Now.Date - Save.lastrenewaldate.Date;
            int dayss = span.Days;

            if (dayss < 30)
            {
                return 0.75;
            }
            else if (dayss < 60)
            {
                return 0.625;
            }
            else if (dayss < 90)
            {
                return 0.5;
            }
            else if (dayss < 120)
            {
                return 0.375;
            }
            else if (dayss < 150)
            {
                return 0.25;
            }
            else if (dayss < 180)
            {
                return 0.125;
            }
            else
            {
                return 0;
            }
        }

        private double calcutaleDuration()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = DateTime.Now.Date - Save.purchasedate.Date;
            double year = (zeroTime + span).Year;
            return year;
        }

        private void btnIns_Details_Click(object sender, EventArgs e)
        {
            Insurance_Details insurance_details = new Insurance_Details();
            this.Hide();
            insurance_details.Show();
        }

        private void btnConfirmCancel_Click(object sender, EventArgs e)
        {
            string message = "Do you really want to cancel this insurance?";
            string title = "Confirm Cancel";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                cmd.CommandText = "UPDATE Insurance SET Refund_Amount = '" + Save.RefundAmount + "', Ins_CancelDate = '" + Save.CancelDate + "', Ins_Status = 'Cancelled' WHERE ID = '" + Save.insuranceid + "';";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                Insurance_Details insurance_details = new Insurance_Details();
                this.Hide();
                insurance_details.Show();
            }
            else
            {
                // Do something  
            }
        }
    }
}
