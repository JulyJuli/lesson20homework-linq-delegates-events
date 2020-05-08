using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDeleagatesEvents
{
    public class WashingCard
    {
        public static List<WashingCard> Cards { get; private set; } = new List<WashingCard>();
        public string Name { get; set; }
        public int Balance { get; set; }
        public DateTime ExpireDate { get; set; }


        public WashingCard(string name, int balance, string date)
        {
            Name = name;
            Balance = balance;
            ExpireDate = DateTime.Parse(date);
            Cards.Add(this);
        }

        public void Withdrawal(int sum)
        {
            Balance -= sum;
        }
    }
}
