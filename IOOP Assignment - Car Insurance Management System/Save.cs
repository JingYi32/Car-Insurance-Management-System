using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    class Save
    {
        private string staffid;
        private string customerid;
        private string insuranceid;

        //Constructor
        public Save()
        {
            staffid = "S001";
            customerid = "G00001";
            insuranceid = "INS000001";
        }

        //Property
        public string STAFFID
        {
            get { return staffid; }
            set { staffid = value; }
        }

        public string CUSTOMERID
        {
            get { return customerid; }
            set { customerid = value; }
        }

        public string INSURANCEID
        {
            get { return insuranceid; }
            set { insuranceid = value; }
        }
    }
}
