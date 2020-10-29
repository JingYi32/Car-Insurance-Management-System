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
    public partial class Edit_Customer_Profile : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand(); 
        private void Edit_Customer_Profile_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();
            cmd.CommandText = "SELECT * FROM Customer WHERE ID = '" + Save.customerid + "'";
            cmd.Connection = con;
            lblShowCUST_ID.Text = Save.customerid;
            lblShowCUST_Name.Text = Save.CustName;
            lblShowCUST_IC.Text = Save.CustIC;
        }

        public Edit_Customer_Profile()
        {
            InitializeComponent();
        }

        //
        //Button
        //

        private void btnExitEdit_Click(object sender, EventArgs e)
        {
            Customer_Profile customer_Profile = new Customer_Profile();
            this.Hide();
            customer_Profile.Show();
        }

        private void btnDoneEdit_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtAddress.Text)) || (string.IsNullOrWhiteSpace(txtEmail.Text)) || (string.IsNullOrWhiteSpace(txtphone.Text)) || (cbGender.SelectedIndex == -1) )
            {
                MessageBox.Show("Please fill in all field.");
            }
            else
            {
                string message = "Confirm Edited Customer Details is Correct?";
                string title = "Confirmation of Edition of Customer Details";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    cmd.CommandText = "UPDATE Customer SET Gender = '" + Save.CustGender + "', Address = '" + Save.CustAddress + "', Phone = '" + Save.CustPhone + "', Email = '" + Save.CustEmail + "' WHERE ID = '" + Save.customerid + "';";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    Main_Page customer_Profile = new Main_Page();
                    this.Hide();
                    customer_Profile.Show();
                }
                else
                {
                    // Do something  
                }
            }
        }

        //
        //Validation
        //

        //Gender
        private void cbGender_Validating(object sender, CancelEventArgs e)
        {
            if (cbGender.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbGender.Focus();
                errorProviderGender.SetError(cbGender, "Please Select Gender of the Client.");
            }
            else
            {
                e.Cancel = false;
                errorProviderGender.SetError(cbGender, "");
                Save.CustGender = cbGender.SelectedItem.ToString();
            }
        }

        //Address
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProviderAddress.SetError(txtAddress, "Please Enter Address of the Client.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddress.SetError(txtAddress, "");
                Save.CustAddress = txtAddress.Text;
            }
        }

        //Contact Number
        private void txtphone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtphone.Text))
            {
                e.Cancel = true;
                txtphone.Focus();
                errorProviderPhone.SetError(txtphone, "Please Enter Phone Number of the Client.");
            }
            else
            {
                try
                {
                    int numericcheck = int.Parse(txtphone.Text);
                    if ((txtphone.Text.Length > 9) || (txtphone.Text.Length < 9))
                    {
                        e.Cancel = true;
                        txtphone.Focus();
                        errorProviderPhone.SetError(txtphone, "Please Enter A Valid Value.");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProviderPhone.SetError(txtphone, "");
                        Save.CustPhone = "060-" + txtphone.Text;
                    }
                }
                catch
                {
                    e.Cancel = true;
                    txtphone.Focus();
                    errorProviderPhone.SetError(txtphone, "Please Enter A Valid Value.");
                }
            }
        }

        //Email Address
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProviderEmail.SetError(txtEmail, "Please Enter Email Address of the Client.");
            }
            else
            {
                e.Cancel = false;
                errorProviderEmail.SetError(txtEmail, "");
                Save.CustEmail = txtEmail.Text;
            }
        }
    }
}
