using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    class Status
    {
        private string status;
        private string id;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public Status()
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=IOOPAssignment.mdb;";
            con.Open();
            try
            {
                cmd.CommandText = "SELECT * FROM Insurance";
                cmd.Connection = con;
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    status = dr[2].ToString();
                    id = dr[0].ToString();
                    if (checkStatus(status))
                    {
                        MessageBox.Show("Before:" + status);
                        DateTime zeroTime = new DateTime(1, 1, 1);
                        TimeSpan span = DateTime.Now - Save.lastrenewaldate;
                        int month = (zeroTime + span).Month;
                        if (month != 1)
                        {
                            updatestatus();
                            MessageBox.Show("After:" + status);
                        }
                    }
                    else
                    {
                        MessageBox.Show("NOT Thing");
                    }
                }
                dr.Close();

            }
            catch(OleDbException)
            {
                MessageBox.Show("Database table is opened.");
            }

        }
        private bool checkStatus(string status)
        {
            bool StatusProcessing;
            if (status == "Processing")
            {
                StatusProcessing = true;
            }
            else
            {
                StatusProcessing = false;
            }
            return StatusProcessing;
        }

        private void updatestatus()
        {
            cmd.CommandText = "UPDATE Insurance SET Ins_Status = 'Expired' WHERE ID = '" + id + "';";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
    }
}
