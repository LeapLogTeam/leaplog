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
            Debit = new List<int>();
            Credit = new List<int>();
        }
        public DateTime Date { get; set; }

        public string Account { get; set; }

        public string Type { get; set; }

        public List<int> Debit { get; private set; }

        public List<int> Credit { get; private set; }

        public int Balance { get; set; }

        public Entry_tacc Clone()
        {
            return new Entry_tacc()
            {
                Account = this.Account,
                Balance = this.Balance,
                Credit = this.Credit,
                Date = this.Date,
                Debit = this.Debit,
                Type = this.Type
            };
        }
     }
}
