﻿using System;
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

        //Amount
        public static double GrossTotal = 0;
        public static double SST = 0;
        public static double Total = 0;

        //Vehicle
        public static string Vehicle_NO;
        public static string Vehicle_Brand;
        public static string Vehicle_Model;
        public static int Vehicle_YOM;
        public static double Vehicle_Price;

        //Owner
        public static string Owner_IC;
        public static string Owner_Name;
        public static string Owner_Gender;
        public static string Owner_Phone;
        public static string Owner_Address;
    }
}
