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

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    public partial class Profile_of_Staff : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public Profile_of_Staff()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_MP_Click(object sender, EventArgs e)
        {
            Main_Page mp = new Main_Page();
            mp.Show();
            this.Close();
        }

        private void Profile_of_Staff_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();

            string staffID = Save.staffid;
            cmd.CommandText = "select * from staff where staff_id = "+staffID+""; // staffid in db
            cmd.Connection = con;
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                showStaID.Text = dr[0].ToString();
                showStaName.Text = dr[3].ToString();
                
                showStaGender.Text = dr[4].ToString();
                showStaPosition.Text = dr[5].ToString();
                showStaGender.Text = dr[6].ToString();
                showStaAddress.Text = dr[7].ToString();

            }
            else
            {
                MessageBox.Show("Error Exists");
            }
            dr.Close();

            DT();
        }

        private void DT()
        {
            cmd.CommandText = "select id as [insurance id], customerid as [customer id], Ins_PurchasedDate as [Purchase Date], Ins_LastRenewalDate as [Last Renewal Date], Ins_EndDate as [End Date] from insurance where Ins_Status = 'processing'";
            cmd.Connection = con;
            
            DataTable dt_MP = new DataTable();
            dt_MP.Load(cmd.ExecuteReader());
            dgvMP.DataSource = dt_MP;
            dgvMP.AutoResizeColumns();
            dgvMP.AutoResizeRows();


            //dt_MP.Columns.Add("Current Incharge Customer ID");
            //dt_MP.Columns.Add("Insurance ID");
            //dt_MP.Columns.Add("Type");
            //dt_MP.Columns.Add("Start Date");
            //dt_MP.Columns.Add("End Date");

            //dgvMP.DataSource = dt_MP;
        }

        private void lblGender_MP_Click(object sender, EventArgs e)
        {

        }
    }
}
