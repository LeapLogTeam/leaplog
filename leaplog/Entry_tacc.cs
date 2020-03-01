using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog
{
	 public class Entry_tacc
	 {
          //class properties
          public Entry_tacc()
          {
               Date = DateTime.Now;
          }
          public DateTime Date { get; set; }

          public string Account { get; set; }

          public string Type { get; set; }

          public int Debit { get; set; }

          public int Credit { get; set; }

          public int Balance { get; set; }
     }
}
