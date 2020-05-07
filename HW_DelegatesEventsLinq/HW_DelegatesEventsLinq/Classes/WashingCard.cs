using System;

namespace HW_DelegatesEventsLinq.Classes
{
     public class WashingCard
    {
        //WashingCard: срок действия, баланс

        public DateTime Deadline { get; set; }

        public  decimal Balance { get; set; }

        public WashingCard(DateTime deadLine, decimal balance)
        {
            Deadline = deadLine;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"<{Balance} before {Deadline.ToShortDateString()}>";
        }
    }
}
