using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    class NCD
    {
        private double NCDFinal;
        private double year;
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection con = new OleDbConnection();

        public NCD()
        {
            NCDFinal = 0;
            year = 0;
        }

        

        public double NCDFINAL
        {
            get { return NCDFinal; }
            set { NCDFinal = value; }
        }

        public double YEAR
        {
            get { return year; }
            set { year = value; }
        }

        public void YearlyNCD(ref double NCDFinal)
        {
            if (year == 1)
                NCDFinal = 0.25;
            else if (year == 2)
                NCDFinal = 0.30;
            else if (year == 3)
                NCDFinal = 0.3833;
            else if (year == 4)
                NCDFinal = 0.45;
            else if (year >= 5)
                NCDFinal = 0.55;
               
        }

        public void NCDAfterClaim(ref double NCDFinal)
        {
            long D1 = Save.enddate.Ticks;
            long D2 = Save.Today.Ticks;
            DateTime date1 = new DateTime(D1);
            DateTime date2 = new DateTime(D2);
            int compMonth = (date2.Month + date2.Year * 12) - (date1.Month + date1.Year * 12);//calculate difference of year
            double daysInEndMonth = (date2 - date2.AddMonths(1)).Days;//calculate date
            double months = compMonth + (date1.Day - date2.Day) / daysInEndMonth;
            int year = Convert.ToInt32(months / 12);

            if (year == 0)
                NCDFinal = 0;
            else if (year == 1)
                NCDFINAL = 1;
            else if (year == 2)
                NCDFinal = 0.30;
            else if (year == 3)
                NCDFinal = 0.3833;
            else if (year == 4)
                NCDFinal = 0.45;
            else if (year >= 5)
                NCDFinal = 0.55;
        }
    }
}
