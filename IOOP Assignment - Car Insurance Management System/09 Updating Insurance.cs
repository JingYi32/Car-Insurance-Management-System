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
            showCUSID.Text = Save.customerid;
            showINSID.Text = Save.insuranceid;
            
        }

        private void btnSubmit_UI_Click(object sender, EventArgs e)
        {
            if (dtApply.Text!="" && dtApprove.Text!="" && CBAccount.Text!="" && textReasons_UI.Text!="" && textTotalAmount_UI.Text!="")
            {
                Save.update_Apply = Convert.ToDateTime(dtApply.Text);
                Save.update_Approve = Convert.ToDateTime(dtApprove.Text);
                cmd.CommandText = "insert into claim VALUES('"+Save.customerid+"', '"+Save.insuranceid+"', '"+Save.update_Apply+"', '"+Save.update_Approve+"', '"+CBAccount.Text+"', '"+textReasons_UI.Text+"', '"+textTotalAmount_UI.Text+"')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert Successfully");

                Main_Page mp = new Main_Page();
                mp.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Please fill in the textbox.");
            }

            cmd.CommandText = "UPDATE insurance SET Ins_status ='Claimed' WHERE id='"+Save.insuranceid+"'";
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

        private void CBAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CBAccount.Items.Add("CIMB Bank");
            CBAccount.Items.Add("Public Bank");
            CBAccount.Items.Add("MayBank");
            CBAccount.Items.Add("Hong Leong Bank");
            CBAccount.Items.Add("HSBC Bank");
            CBAccount.Items.Add("OCBC Bank");
        }
    }
}
