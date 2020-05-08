using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDeleagatesEvents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new CarWash("Bob's wash", 400);
            new CarWash("Meri's wash", 200);

            new WashingCard("Usual card", 1000, "31.12.20");
            new WashingCard("Premium card", 2000, "31.12.25");
            new WashingCard("Expired card", 500, "31.12.15");

            List<Car> cars = new List<Car> {
            new Car(1, "Audi", 500, true),
            new Car(2, "Toyota", 400, true),
            new Car(3, "Lada", 300, true),
            new Car(4, "Mercedes", 350, false),
            new Car(5, "Pegeout", 600, true),
            new Car(6, "Citroen", 200, true),
            new Car(7, "Mazda", 150, true),
            new Car(8, "Chevrolet", 500, true),
            new Car(9, "Lotus", 480, true),
            new Car(10, "Wolksvagen", 700, false)
            };


            foreach (Car car in cars)
            {
                car.GetCleaning();
            }

            foreach (var item in WashingCard.Cards)
            {
                Console.WriteLine($"Name: {item.Name}, balance: {item.Balance}");
            }

            Console.ReadKey();
        }
    }
}
