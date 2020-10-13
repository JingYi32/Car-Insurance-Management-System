using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Updating_Insurance()
        {
            InitializeComponent();
        }

        private void Updating_Insurance_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_UI_Click(object sender, EventArgs e)
        {

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
