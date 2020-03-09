using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog
{
    //The database class stores all the t-accounts created by the user
     public static class Database
     {

          //list of t-accounts made from journal entries
          private static List<Entry_tacc> tentries;
          internal static List<Entry_tacc> TEntries { get => tentries; set => tentries = value; }

          static Database()
          {
               tentries = new List<Entry_tacc>();
          }
     }
}
