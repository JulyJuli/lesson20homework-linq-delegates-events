using System;
using System.Collections.Generic;
using System.Text;

namespace HW20._1
{
    public class WashingCard
    {
        public WashingCard (double balance, DateTime validity)
        {
            Balance = balance;
            Validity = validity;
        }
        public DateTime Validity { get; set; }
        public double Balance { get; set; }
    }
}
