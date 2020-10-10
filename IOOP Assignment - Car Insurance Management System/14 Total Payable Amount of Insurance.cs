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
    public partial class Total_Payable_Amount_of_Insurance : Form
    {
        public Total_Payable_Amount_of_Insurance()
        {
            InitializeComponent();
        }

        private void btnBack_TA_Click(object sender, EventArgs e)
        {
            Select_Type_of_Insurance select = new Select_Type_of_Insurance();
            select.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int insuranceTotal = int.Parse(textBox1.Text);
            int sst;
            lblSSTCount.Text = "";
        }

        private void Total_Payable_Amount_of_Insurance_Load(object sender, EventArgs e)
        {

        }
    }
}
