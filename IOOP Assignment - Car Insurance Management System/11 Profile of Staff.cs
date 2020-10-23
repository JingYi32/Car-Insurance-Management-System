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

            cmd.CommandText = "select * from staff where username = 'admin'";
            cmd.Connection = con;
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                showStaID.Text = dr[0].ToString();
                showStaName.Text = dr[3].ToString();
                showStaLastN.Text = dr[4].ToString();
                showStaGender.Text = dr[5].ToString();
                showStaPosition.Text = dr[6].ToString();
                showStaGender.Text = dr[7].ToString();
                showStaAddress.Text = dr[8].ToString();

            }
            else
            {
                MessageBox.Show("Error Exists");
            }
            dr.Close();

            
        }

        private void DT()
        {
            cmd.CommandText = "";
            cmd.Connection = con;
            OleDbDataReader drDataTable = cmd.ExecuteReader();

            DataTable dt_MP = new DataTable();

            //dt_MP.Columns.Add("Current Incharge Customer ID");
            //dt_MP.Columns.Add("Insurance ID");
            //dt_MP.Columns.Add("Type");
            //dt_MP.Columns.Add("Start Date");
            //dt_MP.Columns.Add("End Date");

            //dgvMP.DataSource = dt_MP;
        }
    }
}
