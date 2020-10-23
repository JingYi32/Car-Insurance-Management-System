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
    public partial class Updating_Insurance : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public Updating_Insurance()
        {
            InitializeComponent();
        }

        private void Updating_Insurance_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();
        }

        private void btnSubmit_UI_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into update VALUES('customer id', 'insurance id', 'date to apply', 'date to approve', 'bank account', 'reasons', 'amount gained')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

        private void lblUpdateInsurance_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_UI_Click(object sender, EventArgs e)
        {
            Insurance_Details ins_details = new Insurance_Details();
            ins_details.Show();
            this.Close();
        }
    }
}
