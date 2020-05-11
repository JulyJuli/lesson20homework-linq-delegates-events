using System;


namespace HW18
{
    public class WashingCard
    {
        private int _minBalance;
        public WashingCard(DateTime expirationDate, int balance)
        {
            ExpirationDate = expirationDate;
            this.Balance = balance;
        }
        public DateTime ExpirationDate { get; set; }
        public int Balance
        {
            get => _minBalance;
            set
            {
                if (value > 0)
                {
                    _minBalance = value;
                }                
            }
        }        
    }
}
