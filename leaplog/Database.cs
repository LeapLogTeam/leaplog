using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog
{
    //The database class stores all the journal entries created by the user
     public static class Database
     {
          //list of journal entries created by user
          private static List<Entry> entries;
          internal static List<Entry> Entries { get => entries; set => entries = value; }

          //list of t-accounts made from journal entries
          private static List<Entry_tacc> tentries;
          internal static List<Entry_tacc> TEntries { get => tentries; set => tentries = value; }

          static Database()
          {
               entries = new List<Entry>();
               tentries = new List<Entry_tacc>();
          }
     }
}
