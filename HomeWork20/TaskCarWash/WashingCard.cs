using System;

namespace TaskCarWash
{
   public class WashingCard
    {
        public WashingCard(decimal balance, DateTime validity)
        {
            Balance = balance;
            Validity = validity;
        }

        public DateTime Validity { get; set; }

        public decimal Balance { get; set; }

        public override string ToString()
        {
            return $"Balance: {Balance}\tValidity: {Validity}";
        }
    }
}
