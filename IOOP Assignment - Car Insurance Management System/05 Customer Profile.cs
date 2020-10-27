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
            cmd.CommandText = "SELECT * FROM Customer WHERE ID = " + Save.customerid + "";
            cmd.Connection = con;
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

        }
    }
}
