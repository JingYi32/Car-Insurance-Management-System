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
    public partial class Purrchase_New_Policy : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        private void Purrchase_New_Policy_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();
        }

        public Purrchase_New_Policy()
        {
            InitializeComponent();
        }

        private void btnCUST_Profile_Click(object sender, EventArgs e)
        {
            Main_Page main_page = new Main_Page();
            this.Hide();
            main_page.Show();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Select_Type_of_Insurance select_type_of_insurance = new Select_Type_of_Insurance();
            this.Hide();
            select_type_of_insurance.Show();
        }
    }
}
