using System;
using System.Collections.Generic;

namespace Homework_Delegate_Event
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var car = new List<Car>() {
            new Car("Acura", 2015, new WashingCard(1000, new DateTime(2024,03,14))),
            new Car("BMW", 2010, new WashingCard(6000, new DateTime(2025, 05, 24))),
            new Car("Audi", 2020, new WashingCard(800, new DateTime(2022, 10, 14))),
            new Car("Ferrari", 2014, new WashingCard(1300, new DateTime(2021, 03, 04))),
            new Car("Honda", 2018, new WashingCard(400, new DateTime(2020, 10, 14))),
            new Car("Lexus", 2013, new WashingCard(200, new DateTime(2022, 08, 20))),
            new Car("Mazda", 2018, new WashingCard(560, new DateTime(2023, 06, 28))),
            new Car("Nissan", 2017, new WashingCard(300, new DateTime(2020, 12, 21))),
            new Car("Skoda", 2014, new WashingCard(888, new DateTime(2021, 01, 26))),
            new Car("Tesla", 2011, new WashingCard(440, new DateTime(2025, 02, 27)))
        };

            WashingStation washingStation1 = new WashingStation("FIRST",
                new List<WashingService>
                {
                   new WashingService(Enum.ServiceName.ComplexWashing, 300),
                   new WashingService(Enum.ServiceName.ContactlessCarWashDoorSills, 333),
                   new WashingService(Enum.ServiceName.ManualBodyWashNanoShampoo, 444),
                   new WashingService(Enum.ServiceName.TrunkCleaning, 500),
                   new WashingService(Enum.ServiceName.VacuumingAndWetCleaningPlasticParts, 654)
                });

            WashingStation washingStation2 = new WashingStation("SECOND",
               new List<WashingService>
               {
                   new WashingService(Enum.ServiceName.ComplexWashing, 555),
                   new WashingService(Enum.ServiceName.ContactlessCarWashDoorSills, 250),
                   new WashingService(Enum.ServiceName.ManualBodyWashNanoShampoo, 580),
                   new WashingService(Enum.ServiceName.TrunkCleaning, 444),
                   new WashingService(Enum.ServiceName.VacuumingAndWetCleaningPlasticParts, 600)
               });

            washingStation1.SuccessfulWashing += Car.WashingStation1_SuccessfulWashing;
            washingStation1.InsufficientFunds += Car.WashingStation1_InsufficientFunds;

            washingStation2.SuccessfulWashing += Car.WashingStation2_SuccessfulWashing;
            washingStation2.InsufficientFunds += Car.WashingStation2_InsufficientFunds;


            List<WashingStation> stations = new List<WashingStation> { washingStation1, washingStation2 };

        }

    }
}