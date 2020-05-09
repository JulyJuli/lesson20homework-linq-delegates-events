using System;
using System.Collections.Generic;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lowPriceWashingService = new WashingService{ Name = "LowPriceWashingService", Price = 100 };
            var highPriceWashingService = new WashingService{ Name = "HighPriceWashingService", Price = 200 };

            var washings = new List<WashingStation>()
            {
                new WashingStation{ Name = "First", WashingServices = highPriceWashingService},
                new WashingStation{ Name = "Second", WashingServices = lowPriceWashingService}
            };
            var cars = new List<Car>()
            {
                new Car{ Brand = "Porsche", IsDirty = true, WashingCard = new WashingCard{ Balance = 50, Validity = 100}},
                new Car{ Brand = "Mazda", IsDirty = false, WashingCard = new WashingCard{ Balance = 500, Validity = 50}},
                new Car{ Brand = "BMW", IsDirty = true, WashingCard = new WashingCard{ Balance = 300, Validity = -100}},
                new Car{ Brand = "Mercedes", IsDirty = false, WashingCard = new WashingCard{ Balance = 150, Validity = 20}},
                new Car{ Brand = "Audi", IsDirty = true, WashingCard = new WashingCard{ Balance = 250, Validity = -2}},
                new Car{ Brand = "Citroen", IsDirty = true, WashingCard = new WashingCard{ Balance = 150, Validity = 12}},
                new Car{ Brand = "Nissan", IsDirty = true, WashingCard = new WashingCard{ Balance = 100, Validity = 1}},
                new Car{ Brand = "Jeep", IsDirty = true, WashingCard = new WashingCard{ Balance = 50, Validity = -10}},
                new Car{ Brand = "Toyota", IsDirty = true, WashingCard = new WashingCard{ Balance = 150, Validity = 1012}},
                new Car{ Brand = "KIA", IsDirty = false, WashingCard = new WashingCard{ Balance = 150, Validity = 10}},
            };

            foreach (var washing in washings)
            {
                Console.WriteLine($"Washing station name - {washing.Name}, balance - ${washing.Balance}, washing service price - ${washing.WashingServices.Price}");
                Console.WriteLine(new string('-', 25));
                foreach (var car in cars)
                {
                    washing.СarArrived(car);
                }
                Console.WriteLine(new string('-', 25));
                Console.WriteLine($"Total washing station balance - ${washing.Balance} \n\n");
            }

            cars.ForEach(Console.WriteLine);
        }
    }
}
