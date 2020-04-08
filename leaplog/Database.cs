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
          // select date from range for income-statement
          public static DateTime from_date;
          // select date to range for income-statement
          public static DateTime to_date;

        static Database()
          {
               tentries = new List<Entry_tacc>();
          }
     }
}
