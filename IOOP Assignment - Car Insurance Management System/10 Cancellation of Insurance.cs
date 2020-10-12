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
    public partial class Cancellation_of_Insurance : Form
    {
        public Cancellation_of_Insurance()
        {
            InitializeComponent();
        }

        private void btnIns_Details_Click(object sender, EventArgs e)
        {
            Insurance_Details insurance_details = new Insurance_Details();
            this.Hide();
            insurance_details.Show();
        }

        private void btnConfirmCancel_Click(object sender, EventArgs e)
        {
            string message = "Do you really want to cancel this insurance?";
            string title = "Confirm Cancel";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Insurance_Details insurance_details = new Insurance_Details();
                this.Hide();
                insurance_details.Show();
            }
            else
            {
                // Do something  
            }
        }

        private void lblCancel_Ins_Click(object sender, EventArgs e)
        {

        }
    }
}
