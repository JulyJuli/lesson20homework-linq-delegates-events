using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDeleagatesEvents
{
    public class Program
    {
        public static void Main(string[] args)
        {

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



            new CarWash("Bob's wash", 400);
            new CarWash("Meri's wash", 200);

            //cars[6].GetCleaning();


            foreach (Car car in cars)
            {
                car.GetCleaning();
            }



            Console.ReadKey();
        }
    }
}
