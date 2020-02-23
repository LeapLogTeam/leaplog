using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog
{
     public enum account_type { Debit, Credit }
	 public class Entry_tacc
	 {
          //class properties
          public Entry_tacc()
          {
               Date = DateTime.Now;
          }
          public DateTime Date { get; set; }
          public string Description { get; set; }
          public int Debit { get; set; }
          public int Credit { get; set; }
          public int Balance { get; set; }
          public account_type Account_Type { get; set; }
     }
}
