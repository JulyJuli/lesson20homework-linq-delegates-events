using CarWash.Classes;
using System;
using System.Collections.Generic;

namespace CarWash
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stationEconomServices = new List<WashingService>()
            {
                new WashingService("Polish", 70),
                new WashingService("Wash", 100)
            };

            var stationEconom = new WashingStation("Econom", stationEconomServices);

            var stationDeluxeServices = new List<WashingService>()
            {
                new WashingService("Polish Lux", 300),
                new WashingService("Wash Lux", 400)
            };

            var stationDeluxe = new WashingStation("Deluxe", stationDeluxeServices);

            var carsList = new List<Car>()
            {
                new Car("Toyota", 1993, new WashingCard(2020, 500), false),
                new Car("Lada", 1990, new WashingCard(2021, 200), false),
                new Car("Peugeot", 2003, new WashingCard(2022, 600), true),
                new Car("Nissan", 2001, new WashingCard(2020, 300), true),
                new Car("Opel", 1999, new WashingCard(2021, 100), false)
            };

            foreach(Car car in carsList)
            {
                stationEconom.ServiceAttempt += car.WashingServiceHandler;
                stationDeluxe.ServiceAttempt += car.WashingServiceHandler;
            }

            stationDeluxe.ServeCars(stationDeluxe.ServiceList[0]);

            Console.WriteLine("===================================");

            stationEconom.ServeCars(stationEconom.ServiceList[1]);
        }
    }
}
