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
    public partial class Customer_Profile : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        private void Customer_Profile_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();
            cmd.CommandText = "SELECT * FROM Customer WHERE ID = '" + Save.customerid + "'";
            cmd.Connection = con;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblShowCUST_ID.Text = ":  " + dr[0].ToString();
                lblShowCUST_Name.Text = ":  " + dr[1].ToString();
                lblShowCUST_IC.Text = ":  " + dr[2].ToString();
                lblShowCUST_Address.Text = ":  " + dr[3].ToString();
                lblShowCUST_Gender.Text = ":  " + dr[4].ToString();
                lblShowCUST_Phone.Text = ":  " + dr[5].ToString();
                lblShowCUST_Email.Text = ":  " + dr[6].ToString();
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
            dr.Close();

            cmd.CommandText = "SELECT ID AS [Insurance ID], Ins_Status AS [Status], Ins_PurchasedDate AS [Purchased Date] FROM Insurance WHERE Cust_ID = '" + Save.customerid + "'";
            cmd.Connection = con;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgvHistory.DataSource = dt;
            dgvHistory.AutoResizeColumns();
            dgvHistory.AutoResizeRows();
        }

        public Customer_Profile()
        {
            InitializeComponent();
        }

        private void tlpHistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main_Page = new Main_Page();
            this.Hide();
            main_Page.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Customer_Profile edit_Customer_Profile = new Edit_Customer_Profile();
            this.Hide();
            edit_Customer_Profile.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Purrchase_New_Policy purrchase_New_Policy = new Purrchase_New_Policy();
            this.Hide();
            purrchase_New_Policy.Show();
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHistory.Rows[e.RowIndex];
                Save.insuranceid = row.Cells["Insurance ID"].Value.ToString();
                //Go To Insurance Page
                Insurance_Details insurance_Details = new Insurance_Details();
                this.Hide();
                insurance_Details.Show();
            }
        }
    }
}
