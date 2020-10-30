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
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public Status()
        {
            con.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;";
            con.Open();
            try
            {
                cmd.CommandText = "SELECT * FROM Insurance";
                cmd.Connection = con;
                OleDbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string status = dr[2].ToString();
                string id = dr[0].ToString();
                dr.Close();
                if (status == "Processing")
                {
                    DateTime zeroTime = new DateTime(1, 1, 1);
                    TimeSpan span = DateTime.Now - Save.lastrenewaldate;
                    int month = (zeroTime + span).Month;
                    if (month != 1)
                    {
                        cmd.CommandText = "UPDATE Insurance SET Ins_Status = 'Expired' WHERE ID = '" + id + "';";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch(OleDbException)
            {
                MessageBox.Show("Database table is opened.");
            }

        }
    }
}
