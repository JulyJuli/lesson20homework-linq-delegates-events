using System;

namespace Homework_Delegate_Event
{
    public class WashingCard
    {
        private decimal _balance;
        public WashingCard(decimal balance, DateTime expirationDate)
        {
            Balance = balance;
            ExpirationDate = expirationDate;
        }
        public DateTime ExpirationDate { get; set; }
        public decimal Balance { 
            get=>_balance;
            set
            {
                if (value > 0)
                {
                    _balance = value;
                } 
            } 
        }
        
        public override string ToString()
        {
            return $"{Balance}, {ExpirationDate}";
        }
    }
}