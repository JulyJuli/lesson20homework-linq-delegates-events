using System;
using System.Runtime.CompilerServices;

namespace Delegates
{
    public class Car
    {
        public override string ToString()
        {
            return $"Brand - {Brand}, isDirty - {IsDirty}, balance - ${WashingCard.Balance}";
        }

        private bool isDirty = false;

        public string Brand { get; set; }
        public DateTime Made { get; set; }
        public WashingCard WashingCard { get; set; }

        public bool IsDirty
        {
            get => isDirty;
            set { isDirty = value; }
        }

        public void NoMoney(object sender, WashingService service)
        {
            Console.WriteLine($"Not enough money to use the service - {service.Name} at a price - {service.Price}");
        }

        public void Successful(object sender, WashingService service)
        {
            Console.WriteLine($"You have successfully washed the car, your balance is {WashingCard.Balance} - {service.Price} = {WashingCard.Balance - service.Price}");

            IsDirty = false;
            WashingCard.Balance -= service.Price;
        }

        public void NoNeedWash(object sender, WashingService service)
        {
            Console.WriteLine($"Your car is already clean and do not require cleaning");
        }
    }
}
