using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDeleagatesEvents
{
    public class CarWash
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public static List<CarWash> CarWashList { get; private set; } = new List<CarWash>();

        public delegate void Notification(CarWash carWash);
        private delegate void Balance(int sum);

        public event Notification ShowCarStatus;
        private event Balance BalanceOperations;


        public CarWash(string name, int price)
        {
            Name = name;
            Price = price;
            CarWashList.Add(this);
        }


        public void CarProcessing(Car car)
        {
            // Getting car cleaning if its balance is enaugh.
            if (car.Card.Balance >= this.Price)
            {
                ShowCarStatus += car.SuccesWashHandler;

                //car.Card.Balance -= Price;
                BalanceOperations += car.Card.Withdrawal;
            }

            // Not eanaugh money - display the failure notification.
            // Try to get another car wash. 
            else
            {
                ShowCarStatus += car.LowFoundsHandler;
            }

            // Invoking events.
            // Preparing events for the next car (null'ing them).
            BalanceOperations?.Invoke(this.Price);
            ShowCarStatus?.Invoke(this);

            BalanceOperations = null;
            ShowCarStatus = null;
        }
    }
}
