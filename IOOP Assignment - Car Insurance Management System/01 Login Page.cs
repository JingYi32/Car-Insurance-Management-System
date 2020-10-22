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
    public partial class Login_Page : Form
    {
        OleDbConnection con = new OleDbConnection(); 
        OleDbCommand cmd = new OleDbCommand();

        public Login_Page()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from staff where username = '" + txtUsername.Text + "'";
            cmd.Connection = con;

            OleDbDataReader drusername = cmd.ExecuteReader();
            if (drusername.Read())
            {
                cmd.CommandText = "select * from staff where password = '" + txtPassword.Text + "'";
                cmd.Connection = con;
                OleDbDataReader drpassword = cmd.ExecuteReader();
                if (drpassword.Read())
                {
                    Main_Page mainMenu = new Main_Page();
                    this.Hide();
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password.");
                }
                drpassword.Close();
            }
            else
            {
                MessageBox.Show("Record not found.");
            }
            drusername.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.comfirm();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();
        }
    }
}
