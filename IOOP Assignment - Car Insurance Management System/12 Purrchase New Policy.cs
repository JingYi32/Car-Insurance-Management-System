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
            var controls = new[] { txtVehicle_NO, txtVehicle_Brand, txtVehicle_Model, txtVehicle_YOM, txtVehicle_Price};
            foreach (var box in controls)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider1.SetError(box, "Please fill the required field");
                }
                else
                {
                    Select_Type_of_Insurance select_type_of_insurance = new Select_Type_of_Insurance();
                    this.Hide();
                    select_type_of_insurance.Show();
                }
            }
        }

        //
        //OwnerDetails
        //

        private void rbSame_CheckedChanged(object sender, EventArgs e)
        {
            txtOwner_ICNumber.Visible = false;
            txtOwner_Name.Visible = false;
            cbOwner_Gender.Visible = false;
            txtOwner_Phone.Visible = false;
            txtOwner_Address.Visible = false;
            lblShowOwner_ICNumber.Visible = true;
            lblShowOwner_Name.Visible = true;
            lblShowOwner_Gender.Visible = true;
            lblShowOwner_Phone.Visible = true;
            lblShowOwner_Address.Visible = true;
        }

        private void rbOthers_CheckedChanged(object sender, EventArgs e)
        {
            lblShowOwner_ICNumber.Visible = false;
            lblShowOwner_Name.Visible = false;
            lblShowOwner_Gender.Visible = false;
            lblShowOwner_Phone.Visible = false;
            lblShowOwner_Address.Visible = false;
            txtOwner_ICNumber.Visible = true;
            txtOwner_Name.Visible = true;
            cbOwner_Gender.Visible = true;
            txtOwner_Phone.Visible = true;
            txtOwner_Address.Visible = true;

        }          
    }
}
