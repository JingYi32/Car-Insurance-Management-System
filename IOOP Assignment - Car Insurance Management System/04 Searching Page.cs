﻿using System;
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
    public partial class Searching_Page : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        private void Searching_Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();
        }

        public Searching_Page()
        {
            InitializeComponent();
        }

        //
        //BUTTON
        //

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            Main_Page mainMenu = new Main_Page();
            this.Hide();
            mainMenu.Show();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Please select one type of data to search.");
            }
            else
            {
                if (cbSelect.SelectedItem.ToString() == "Customer ID")
                {
                    try
                    {
                        cmd.CommandText = "SELECT Insurance.ID AS [Insurance ID], Insurance.Ins_Status AS [Status], Customer.ID AS [Customer ID], Customer.CustName AS [Name], Insurance.Ins_PurchasedDate AS [Purchased Date] FROM Customer INNER JOIN Insurance ON Customer.ID = Insurance.Cust_ID WHERE Customer.ID = '" + txtSearch.Text + "'";
                        cmd.Connection = con;
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgvSearchResult.DataSource = dt;
                        dgvSearchResult.AutoResizeColumns();
                        dgvSearchResult.AutoResizeRows();
                    }
                    catch (OleDbException)
                    {
                        MessageBox.Show("Databases table is opening.");
                    }

                }
                else if (cbSelect.SelectedItem.ToString() == "Insurance ID")
                {
                    try
                    {
                        cmd.CommandText = "SELECT Insurance.ID AS [Insurance ID], Insurance.Ins_Status AS [Status], Customer.ID AS [Customer ID], Customer.CustName AS [Name], Insurance.Ins_PurchasedDate AS [Purchased Date] FROM Customer INNER JOIN Insurance ON Customer.ID = Insurance.Cust_ID WHERE Insurance.ID = '" + txtSearch.Text + "'";
                        cmd.Connection = con;
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        dgvSearchResult.DataSource = dt;
                        dgvSearchResult.AutoResizeColumns();
                        dgvSearchResult.AutoResizeRows();
                    }
                    catch (OleDbException)
                    {
                        MessageBox.Show("Databases table is opening.");
                    }
                }
            }
        }

        //
        //Search Result & Go To Other Form
        //

        private void dgvSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSearchResult.Rows[e.RowIndex];
                Save.customerid = row.Cells["Customer ID"].Value.ToString();
                Save.insuranceid = row.Cells["Insurance ID"].Value.ToString();
                //Go To Insurance Page
                Insurance_Details insurance_Details = new Insurance_Details();
                this.Hide();
                insurance_Details.Show();
            }
        }

    }
}


