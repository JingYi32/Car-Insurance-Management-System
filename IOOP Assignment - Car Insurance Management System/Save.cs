using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment___Car_Insurance_Management_System
{
    class Save
    {
        //ID
        public static string staffid;
        public static string customerid;
        public static string insuranceid = "";

        //INS
        public static string InsStatus;
        public static string InsType;
        public static DateTime purchasedate;
        public static DateTime lastrenewaldate;
        public static DateTime enddate;
        public static DateTime RenewalDate;
        public static DateTime RenewalStartDate;
        public static DateTime RenewalEndDate;

        //Customer
        public static string CustName;
        public static string CustIC;
        public static string CustGender;
        public static string CustAddress;
        public static string CustPhone;
        public static string CustEmail;

        //Amount
        public static double GrossTotal = 0;
        public static double SST = 0;
        public static double Total = 0;
        public static DateTime Today = DateTime.Now;

        //Vehicle
        public static string Vehicle_NO;
        public static string Vehicle_Brand;
        public static string Vehicle_Model;
        public static int Vehicle_YOM;
        public static double Vehicle_Price;

        //Owner
        public static string Owner_IC;
        public static string Owner_Name = "";
        public static string Owner_Gender;
        public static string Owner_Phone;
        public static string Owner_Address;

        //Update
        public static DateTime update_Apply;
        public static DateTime update_Approve;
       
        //Count from Database
        public static int CountTotalINS = 0;
        public static int CountTotalClaim = 0;
        public static int CountOwn = 0;
        public static int CountVehicle = 0;
    }
}
