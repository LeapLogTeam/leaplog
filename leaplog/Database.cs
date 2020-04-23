using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LeapLog
{
    //The database class stores all the t-accounts created by the user
     public static class Database
     {

          //list of t-accounts made from journal entries
          private static List<Entry_tacc> tentries;
          internal static List<Entry_tacc> TEntries { get => tentries; set => tentries = value; }

          // select date for balance sheet calendar
          public static DateTime select_date;
          // select date range for income-statement
          public static DateRange is_date;
          // select date range for statement of owner's equity
          public static DateRange sooe_date;
          // net-income
          public static int net_income = 0;

          static Database()
          {
               tentries = new List<Entry_tacc>();
          }
     }
}
