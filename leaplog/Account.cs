using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog
{

    //This class is needed in order to successfully get an account's debit history
    //to show up on a grid
    class Account
    {
        public int Debit { get; set; }
        public int Credit { get; set; }
    }
}
