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
            //cmd.CommandText = "select * from student where studenttp = '" + txtTP.Text + "'";
            //cmd.Connection = con;
            //OleDbDataReader dr = cmd.ExecuteReader();
            Main_Page mainMenu = new Main_Page();
            this.Hide();
            mainMenu.Show();
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
