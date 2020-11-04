using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    public partial class Registration_Form : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public Registration_Form()
        {
            InitializeComponent();
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();

            //Generate Customer ID
            cmd.CommandText = "SELECT COUNT(*) AS [Customer_ID] FROM Customer";
            cmd.Connection = con;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id_numbering = int.Parse(dr[0].ToString()) + 1;
                string id_number = id_numbering.ToString("00000");
                Save.customerid = "G" + id_number;
                lblRE_CustomerID2.Text = Save.customerid;
            }
            dr.Close();


            cbbRE_Gender.Items.Add("Male");
            cbbRE_Gender.Items.Add("Female");
        }

        //
        //buttons
        //

        private void btnRE_Menu(object sender, EventArgs e)
        {
            Main_Page mainMenu = new Main_Page();
            this.Hide();
            mainMenu.Show();
        }

        private void btnRE_Submit(object sender, EventArgs e)
        {

            if ((string.IsNullOrWhiteSpace(txtRE_Name.Text)) || (string.IsNullOrWhiteSpace(txtRE_IDNo.Text)) || (string.IsNullOrWhiteSpace(txtRE_Address.Text)) || (cbbRE_Gender.SelectedIndex == -1)  || (string.IsNullOrWhiteSpace(txtRE_Contact.Text)) || (string.IsNullOrWhiteSpace(txtRE_Email.Text)))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                cmd.CommandText = "INSERT into Customer values ('" + Save.customerid + "', '" + Save.CustName + "', '" + Save.CustIC + "', '" + Save.CustAddress + "', '" + Save.CustGender + "', '" + Save.CustPhone + "', '" + Save.CustEmail + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Registered.");

                Purrchase_New_Policy purchase = new Purrchase_New_Policy();
                this.Hide();
                purchase.Show();
            }
        }

        //
        //Validating
        //

        private void txtRE_Name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRE_Name.Text))
            {
                e.Cancel = true;
                txtRE_Name.Focus();
                errorProvider1.SetError(txtRE_Name, "Please Enter Name of Customer.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRE_Name, "");
                Save.CustName = txtRE_Name.Text;
            }
        }

        private void txtRE_IDNo_Validating(object sender, CancelEventArgs e)
        {
            //Ensure there is a input value
            if (string.IsNullOrWhiteSpace(txtRE_IDNo.Text))
            {
                e.Cancel = true;
                txtRE_IDNo.Focus();
                errorProvider2.SetError(txtRE_IDNo, "Please Enter IC Number of Customer.");
            }
            else
            {
                //Ensure the input value is numeric
                if (Regex.IsMatch(txtRE_IDNo.Text, "^[0-9]*$"))
                {
                    //Ensure the input value is in a correct format
                    if ((txtRE_IDNo.Text.Length > 12) || (txtRE_IDNo.Text.Length < 12))
                    {
                        e.Cancel = true;
                        txtRE_IDNo.Focus();
                        errorProvider2.SetError(txtRE_IDNo, "Please Enter A Valid Value.");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider2.SetError(txtRE_IDNo, "");
                        Save.CustIC = txtRE_IDNo.Text;
                    }
                }
                else
                {
                    e.Cancel = true;
                    txtRE_IDNo.Focus();
                    errorProvider2.SetError(txtRE_IDNo, "Please Enter A Numeric Value.");
                }
            }
        }

        private void txtRE_Address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRE_Address.Text))
            {
                e.Cancel = true;
                txtRE_Address.Focus();
                errorProvider4.SetError(txtRE_Address, "Please Enter Address of Customer.");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txtRE_Address, "");
                Save.CustAddress = txtRE_Address.Text;
            }
        } 
        
        private void cbbRE_Gender_Validating(object sender, CancelEventArgs e)
        {
            if (cbbRE_Gender.SelectedIndex == -1)
            {
                e.Cancel = true;
                cbbRE_Gender.Focus();
                errorProvider3.SetError(cbbRE_Gender, "Please Select Gender of Customer.");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(cbbRE_Gender, "");
                Save.CustGender = cbbRE_Gender.SelectedItem.ToString();
            }
        }

        

        private void txtRE_Contact_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRE_Contact.Text))
            {
                e.Cancel = true;
                txtRE_Contact.Focus();
                errorProvider5.SetError(txtRE_Contact, "Please Enter Contact Number of Customer.");
            }
            else
            {
                if (Regex.IsMatch(txtRE_Contact.Text, "^[0-9]*$"))
                {
                    if ((txtRE_Contact.Text.Length > 10) || (txtRE_Contact.Text.Length < 9))
                    {
                        e.Cancel = true;
                        txtRE_Contact.Focus();
                        errorProvider5.SetError(txtRE_Contact, "Please Enter A Valid Contact Number of Customer.");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider5.SetError(txtRE_Contact, "");
                        Save.CustPhone = "060-" + txtRE_Contact.Text;
                    }
                }
                else
                {
                    e.Cancel = true;
                    txtRE_Contact.Focus();
                    errorProvider5.SetError(txtRE_Contact, "Please Enter Numeric Number.");
                }

            }

        }

        private void txtRE_Email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRE_Email.Text))
            {
                e.Cancel = true;
                txtRE_Email.Focus();
                errorProvider6.SetError(txtRE_Email, "Please Enter Email of Customer.");
            }
            else
            {
                e.Cancel = false;
                errorProvider6.SetError(txtRE_Email, "");
                Save.CustEmail = txtRE_Email.Text;
            }
        }
    }
}
