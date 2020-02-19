using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog
{
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
