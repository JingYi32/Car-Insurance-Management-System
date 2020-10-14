using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    public partial class Profile_of_Staff : Form
    {
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
            DataTable dt_MP = new DataTable();

            dt_MP.Columns.Add("Current Incharge Customer ID");
            dt_MP.Columns.Add("Insurance ID");
            dt_MP.Columns.Add("Type");
            dt_MP.Columns.Add("Start Date");
            dt_MP.Columns.Add("End Date");

            dgvMP.DataSource = dt_MP;
        }
    }
}
