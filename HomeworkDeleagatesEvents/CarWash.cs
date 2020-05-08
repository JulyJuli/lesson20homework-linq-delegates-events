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
        public static List<CarWash> CarWashList { get;private set; } = new List<CarWash>();

        public delegate void Notification(CarWash carWash);
        public event Notification CarStatusNotification;


        public CarWash(string name, int price)
        {
            Name = name;
            Price = price;
            CarWashList.Add(this);
        }


        public void CarProcessing(Car car)
        {
            // Getting car cleaning if its balance is enaugh.
            if (car.Balance >= this.Price)
            {
                CarStatusNotification += car.SuccesWashHandler;
                car.Balance -= Price;
            }

            // Not eanaugh money - display the failure notification.
            // Try to get another car wash. 
            else
            {
                CarStatusNotification += car.LowFoundsHandler;
            }
            CarStatusNotification?.Invoke(this);
            CarStatusNotification = null;

        }
    }
}
