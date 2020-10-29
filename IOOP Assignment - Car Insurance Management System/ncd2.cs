using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    class ncd2
    {
        private double ncd;
        private int year;

        //Constructor
        public ncd2()
        {
            ncd = 0;
            year = 0;
        }

        //Property
        public double NCD
        {
            get { return ncd; }
            set { ncd = value; }
        }

        public int YEAR
        {
            get { return year; }
            set { year = value; }
        }

        public double calculateNCD(ref double ncd)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = Save.enddate.Date - Save.purchasedate.Date;
            year = (zeroTime + span).Year - 1;
            
            if (year == 1)
                return ncd = 0.25;
            else if (year == 2)
                return ncd = 0.30;
            else if (year == 3)
                return ncd = 0.3833;
            else if (year == 4)
                return ncd = 0.45;
            else if (year >= 5)
                return ncd = 0.55;
            else
                return ncd = 0;
        }
    }
}
