using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog
{
    public class Entry
    {
        //class properties
        public Entry() {
            Date = DateTime.Now;
        }
        public DateTime Date { get; private set; }

        public string Account1 { get; set; }

        public string Account2 { get; set; }

        public string Category1 { get; set; }

        public string Category2 { get; set; }

        public int Debit { get; set; }

        public int Credit { get; set; }

        //TO DO: make Notes property
    }
}
