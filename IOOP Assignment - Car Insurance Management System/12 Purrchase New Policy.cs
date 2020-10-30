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

            //Generate Insurance ID
            cmd.CommandText = "SELECT COUNT(*) AS [Insurance_ID] FROM Insurance";
            cmd.Connection = con;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id_numbering = int.Parse(dr[0].ToString()) + 1;
                string id_number = id_numbering.ToString("00000");
                Save.insuranceid = "INS" + id_number;
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
            dr.Close();

        }

        public Purrchase_New_Policy()
        {
            InitializeComponent();
        }

        //
        //Button
        //

        private void btnCUST_Profile_Click(object sender, EventArgs e)
        {
            Main_Page main_page = new Main_Page();
            this.Hide();
            main_page.Show();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (rbOthers.Checked == true)
            {
                if ((string.IsNullOrWhiteSpace(txtVehicle_NO.Text)) || (string.IsNullOrWhiteSpace(txtVehicle_Brand.Text)) || (string.IsNullOrWhiteSpace(txtVehicle_Model.Text)) || (string.IsNullOrWhiteSpace(txtVehicle_YOM.Text)) || (string.IsNullOrWhiteSpace(txtVehicle_Price.Text)) || (cbCustomerID.SelectedIndex == -1) || (string.IsNullOrWhiteSpace(txtOwner_ICNumber.Text)) || (string.IsNullOrWhiteSpace(txtOwner_Name.Text)) || (cbOwner_Gender.SelectedIndex == -1) || (string.IsNullOrWhiteSpace(txtOwner_Phone.Text)) || (string.IsNullOrWhiteSpace(txtOwner_Address.Text)))
                {
                    MessageBox.Show("Please fill in all field.");
                }
                else
                {
                    Select_Type_of_Insurance selectpage = new Select_Type_of_Insurance();
                    this.Hide();
                    selectpage.Show();
                }
            }
            else
            {
                if ((string.IsNullOrWhiteSpace(txtVehicle_NO.Text)) || (string.IsNullOrWhiteSpace(txtVehicle_Brand.Text)) || (string.IsNullOrWhiteSpace(txtVehicle_Model.Text)) || (string.IsNullOrWhiteSpace(txtVehicle_YOM.Text)) || (string.IsNullOrWhiteSpace(txtVehicle_Price.Text)) || (cbCustomerID.SelectedIndex == -1))
                {
                    MessageBox.Show("Please fill in all field.");
                }
                else
                {
                    Select_Type_of_Insurance selectpage = new Select_Type_of_Insurance();
                    this.Hide();
                    selectpage.Show();
                }
            }
        }

        //
        //Radio Button of OwnerDetails
        //

        private void rbSame_CheckedChanged(object sender, EventArgs e)
        {
            txtOwner_ICNumber.Visible = false;
            txtOwner_Name.Visible = false;
            cbOwner_Gender.Visible = false;
            label1.Visible = false;
            txtOwner_Phone.Visible = false;
            txtOwner_Address.Visible = false;
            lblShowOwner_ICNumber.Visible = true;
            lblShowOwner_Name.Visible = true;
            lblShowOwner_Gender.Visible = true;
            lblShowOwner_Phone.Visible = true;
            lblShowOwner_Address.Visible = true;

            //SAVE SAME OWNERS DETAILS
            cmd.CommandText = "SELECT Customer.* FROM Insurance INNER JOIN Customer ON Insurance.Cust_ID = Customer.ID WHERE Customer.ID = '" + Save.customerid + "'";
            cmd.Connection = con;
            OleDbDataReader dr2 = cmd.ExecuteReader();
            if (dr2.Read())
            {
                //Show Details
                lblShowOwner_ICNumber.Text = ":  " + dr2[2].ToString();
                lblShowOwner_Name.Text = ":  " + dr2[1].ToString();
                lblShowOwner_Gender.Text = ":  " + dr2[4].ToString();
                lblShowOwner_Phone.Text = ":  " + dr2[5].ToString();
                lblShowOwner_Address.Text = ":  " + dr2[3].ToString();

                //Save
                Save.Owner_IC = dr2[2].ToString();
                Save.Owner_Name = dr2[1].ToString();
                Save.Owner_Gender = dr2[4].ToString();
                Save.Owner_Phone = dr2[5].ToString();
                Save.Owner_Address = dr2[3].ToString();
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
            dr2.Close();
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
            label1.Visible = true;
            txtOwner_Phone.Visible = true;
            txtOwner_Address.Visible = true;

        }

        //
        //Validation & Save
        //

        //Vehicle Registration Number
        private void txtVehicle_NO_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicle_NO.Text))
            {
                e.Cancel = true;
                txtVehicle_NO.Focus();
                errorProvider1.SetError(txtVehicle_NO, "Please Enter Vehicle Registration Number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtVehicle_NO, "");
                Save.Vehicle_NO = txtVehicle_NO.Text;
            }
        }

        //Brand of Vehicle
        private void txtVehicle_Brand_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicle_Brand.Text))
            {
                e.Cancel = true;
                txtVehicle_Brand.Focus();
                errorProvider2.SetError(txtVehicle_Brand, "Please Enter Brand of Vehicle.");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtVehicle_Brand, "");
                Save.Vehicle_Brand = txtVehicle_Brand.Text;
            }
        }

        //Model of Vehicle
        private void txtVehicle_Model_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicle_Model.Text))
            {
                e.Cancel = true;
                txtVehicle_Model.Focus();
                errorProvider3.SetError(txtVehicle_Model, "Please Enter Model of Vehicle.");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtVehicle_Model, "");
                Save.Vehicle_Model = txtVehicle_Model.Text;
            }
        }

        //Manufacture Year of Vehicle
        private void txtVehicle_YOM_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicle_YOM.Text))
            {
                e.Cancel = true;
                txtVehicle_YOM.Focus();
                errorProvider4.SetError(txtVehicle_YOM, "Please Enter Manufacture Year of Vehicle.");
            }
            else
            {
                try
                {
                    if ((txtVehicle_YOM.Text.Length > 4) || (txtVehicle_YOM.Text.Length < 4))
                    {
                        e.Cancel = true;
                        txtVehicle_YOM.Focus();
                        errorProvider4.SetError(txtVehicle_YOM, "Please Enter A Valid Value.");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider4.SetError(txtVehicle_YOM, "");
                        Save.Vehicle_YOM = int.Parse(txtVehicle_YOM.Text);
                    }
                }
                catch
                {
                    e.Cancel = true;
                    txtVehicle_YOM.Focus();
                    errorProvider4.SetError(txtVehicle_YOM, "Please Enter A Valid Value.");
                }

            }
        }

        //Purchased Price of Vehicle
        private void txtVehicle_Price_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicle_Price.Text))
            {
                e.Cancel = true;
                txtVehicle_Price.Focus();
                errorProvider5.SetError(txtVehicle_Price, "Please Enter Purchased Price of Vehicle.");
            }
            else
            {
                try
                {
                    Save.Vehicle_Price = int.Parse(txtVehicle_Price.Text);
                    e.Cancel = false;
                    errorProvider5.SetError(txtVehicle_Price, "");
                }
                catch
                {
                    e.Cancel = true;
                    txtVehicle_Price.Focus();
                    errorProvider5.SetError(txtVehicle_Price, "Please Enter A Valid Value.");
                }
            }
        }

        //Customer ID
        private void cbCustomerID_Validating(object sender, CancelEventArgs e)
        {
            if (cbCustomerID.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbCustomerID.Focus();
                errorProvider6.SetError(cbCustomerID, "Please select a Customer ID.");
            }
            else
            {
                e.Cancel = false;
                errorProvider6.SetError(cbCustomerID, "");
                Save.customerid = cbCustomerID.SelectedItem.ToString();
            }
        }

        //Owner IC
        private void txtOwner_ICNumber_Validating(object sender, CancelEventArgs e)
        {
            if (rbOthers.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtOwner_ICNumber.Text))
                {
                    e.Cancel = true;
                    txtOwner_ICNumber.Focus();
                    errorProvider7.SetError(txtOwner_ICNumber, "Please Enter IC Number of the Vehicle Owner.");
                }
                else
                {
                    try
                    {
                        e.Cancel = false;
                        errorProvider7.SetError(txtOwner_ICNumber, "");
                        Save.Owner_IC = int.Parse(txtOwner_ICNumber.Text).ToString();
                    }
                    catch
                    {
                        e.Cancel = true;
                        txtOwner_ICNumber.Focus();
                        errorProvider7.SetError(txtOwner_ICNumber, "Please Enter A Valid Value.");
                    }
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider7.SetError(txtOwner_ICNumber, "");
                Save.Owner_IC = lblOwner_ICNumber.Text;
            }
        }

        //Owner Name
        private void txtOwner_Name_Validating(object sender, CancelEventArgs e)
        {
            if (rbOthers.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtOwner_Name.Text))
                {
                    e.Cancel = true;
                    txtOwner_Name.Focus();
                    errorProvider8.SetError(txtOwner_Name, "Please Enter Name of the Vehicle Owner.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider8.SetError(txtOwner_Name, "");
                    Save.Owner_Name = txtOwner_Name.Text;
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider8.SetError(txtOwner_Name, "");
                Save.Owner_Name = lblOwner_Name.Text;
            }
        }

        //Owner Gender
        private void cbOwner_Gender_Validating(object sender, CancelEventArgs e)
        {
            if (rbOthers.Checked)
            {
                if (cbOwner_Gender.SelectedIndex == -1)
                {
                    e.Cancel = true;
                    cbOwner_Gender.Focus();
                    errorProvider9.SetError(cbOwner_Gender, "Please Select Gender of the Vehicle Onwer.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider9.SetError(cbOwner_Gender, "");
                    Save.Owner_Gender = cbOwner_Gender.SelectedItem.ToString();
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider9.SetError(cbOwner_Gender, "");
                Save.Owner_Gender = cbOwner_Gender.Text;
            }
        }

        //Owner Phone
        private void txtOwner_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (rbOthers.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtOwner_Phone.Text))
                {
                    e.Cancel = true;
                    txtOwner_Phone.Focus();
                    errorProvider10.SetError(txtOwner_Phone, "Please Enter Phone Number of the Vehicle Owner.");
                }
                else
                {
                    try
                    {
                        int numericcheck = int.Parse(txtOwner_Phone.Text);
                        if ((txtOwner_Phone.Text.Length > 9) || (txtOwner_Phone.Text.Length < 9))
                        {
                            e.Cancel = true;
                            txtOwner_Phone.Focus();
                            errorProvider10.SetError(txtOwner_Phone, "Please Enter A Valid Value.");
                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider10.SetError(txtOwner_Phone, "");
                            Save.Owner_Phone = "060-" + txtOwner_Phone.Text;
                        }
                    }
                    catch
                    {
                        e.Cancel = true;
                        txtOwner_Phone.Focus();
                        errorProvider10.SetError(txtOwner_Phone, "Please Enter A Valid Value.");
                    }
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider10.SetError(txtOwner_Phone, "");
                Save.Owner_Phone = lblOwner_Phone.Text;
            }
        }

        //Owner Address
        private void txtOwner_Address_Validating(object sender, CancelEventArgs e)
        {
            if (rbOthers.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtOwner_Address.Text))
                {
                    e.Cancel = true;
                    txtOwner_Address.Focus();
                    errorProvider11.SetError(txtOwner_Address, "Please Enter Address of the Vehicle Owner.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider11.SetError(txtOwner_Address, "");
                    Save.Owner_Address = txtOwner_Address.Text;
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider11.SetError(txtOwner_Address, "");
                Save.Owner_Address = lblOwner_Address.Text;
            }
        }

        private void displaycustomerdetails()
        {
            cmd.CommandText = "SELECT * FROM Customer WHERE ID = '" + Save.customerid + "'";
            cmd.Connection = con;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblShowOwner_ICNumber.Text = dr[3].ToString();
                lblShowOwner_Name.Text = dr[1].ToString();
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
            dr.Close();
        }
    }
}
