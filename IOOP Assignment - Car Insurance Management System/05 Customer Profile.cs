﻿using System;
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
    public partial class Customer_Profile : Form
    {
        public Customer_Profile()
        {
            InitializeComponent();
        }

        private void tlpHistory_Paint(object sender, PaintEventArgs e)
        {
            lblBil.TextAlign = (System.Drawing.ContentAlignment)HorizontalAlign.Center;
            lblInsuranceID.TextAlign = (System.Drawing.ContentAlignment)HorizontalAlign.Center;
            lblStartdate.TextAlign = (System.Drawing.ContentAlignment)HorizontalAlign.Center;
            lblStatus.TextAlign = (System.Drawing.ContentAlignment)HorizontalAlign.Center;
            lblEnddate.TextAlign = (System.Drawing.ContentAlignment)HorizontalAlign.Center;
        }
    }
}
