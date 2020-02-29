using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog
{
    //The database class stores all the journal entries created by the user
     public static class Database
     {
          private static List<Entry> entries;

          internal static List<Entry> Entries { get => entries; set => entries = value; }

          static Database()
          {
               entries = new List<Entry>();
          }
     }
}
