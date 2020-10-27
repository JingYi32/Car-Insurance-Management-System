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
            cmd.CommandText = "SELECT Customer.*, Insurance.* FROM Customer INNER JOIN Insurance ON Customer.ID = Insurance.Cust_ID WHERE Customer.ID = '" + Save.customerid + "'";
            cmd.Connection = con;

            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblCUST_ID.Text = dr[0].ToString();
                lblCUST_Name.Text = dr[1].ToString();
                lblCUST_IC.Text = dr[2].ToString();
                lblCUST_Address.Text = dr[3].ToString();
                lblCUST_Gender.Text = dr[4].ToString();
                lblCUST_Phone.Text = dr[5].ToString();
                lblCUST_Email.Text = dr[6].ToString();
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
            dr.Close();
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
                Save.customerid = row.Cells["Customer ID"].Value.ToString();
                Save.insuranceid = row.Cells["Insurance ID"].Value.ToString();
                //Go To Insurance Page
                Insurance_Details insurance_Details = new Insurance_Details();
                this.Hide();
                insurance_Details.Show();
            }
        }
    }
}
