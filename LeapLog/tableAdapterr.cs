using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog
{
    class tableAdapterr
    {
     //Journal table
        public int ID{ get; set; }
        public string Date { get; set; }
        public string Account_1 { get; set; }
        public string Account_2 { get; set; }
        public string Type_1 { get; set; }
        public string Type_2 { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
    }
}
