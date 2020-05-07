using System;
using System.Collections.Generic;

namespace TaskCarWash
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car("Volvo", 2010, new WashingCard(100.50M, new DateTime(2021, 04,15)), StateOfCar.Dirty),
                new Car("Zaporozhez", 1989, new WashingCard(120.50M, new DateTime(2022, 04,15)),StateOfCar.Dirty),
                new Car("Tesla", 2019, new WashingCard(350.50M, new DateTime(2023, 02,11)),StateOfCar.Dirty),
                new Car("Audi", 2012, new WashingCard(300.00M, new DateTime(2022, 11,07)),StateOfCar.Clean),
                new Car("Acura", 2020, new WashingCard(100.50M, new DateTime(2021, 04,15)),StateOfCar.Dirty),
                new Car("Bentley", 2015, new WashingCard(500.50M, new DateTime(2024, 02,14)),StateOfCar.Clean),
                new Car("BMW", 2013, new WashingCard(1000.00M, new DateTime(2030, 07,18)),StateOfCar.Dirty),
                new Car("Buik", 2010, new WashingCard(330.00M, new DateTime(2031, 09,11)),StateOfCar.Clean),
                new Car("Bugatti", 2020, new WashingCard(4000.50M, new DateTime(2021, 01,15)),StateOfCar.Dirty),
                new Car("Volvo", 2019, new WashingCard(140.50M, new DateTime(2025, 04,15)),StateOfCar.Dirty)
            };

            var washStation1 = new WashingStation("Wash station #1");

            washStation1.washingServices.Add(new WashingServise(CarWashServise.Washing, 500M));
            washStation1.washingServices.Add(new WashingServise(CarWashServise.DryCleaning, 200M));
            washStation1.washingServices.Add(new WashingServise(CarWashServise.GlassCleaning, 50.0M));

            var washStation2 = new WashingStation("Wash station #2");

            washStation2.washingServices.Add(new WashingServise(CarWashServise.CaldWax, 130M));
            washStation2.washingServices.Add(new WashingServise(CarWashServise.VacuumCleaning, 400.50M));
            washStation2.washingServices.Add(new WashingServise(CarWashServise.Washing, 300.0M));

            List<WashingStation> stations = new List<WashingStation>();
            stations.Add(washStation1);
            stations.Add(washStation2);


            Random rand = new Random();

            int indexStation = rand.Next(0, 2);

            stations[indexStation].SuccsessfullClean += Car.MessageCarIsClean;
            stations[indexStation].UnSuccsessfullClean += Car.MessageCarIsNotClean;
            stations[indexStation].UnSuccsessfulNotEnoughMoney += Car.MessageTopUpCard;

            int countClients = 0;
            int maxCountClients = 5;

            while (countClients < maxCountClients)
            {
                stations[indexStation].CheckCar(cars, stations[indexStation]);

                Console.WriteLine("==========================================================================================");

                countClients++;
            }

            Console.ReadKey();
        }
    }
}
