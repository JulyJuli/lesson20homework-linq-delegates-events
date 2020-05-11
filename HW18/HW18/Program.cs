using System;
using System.Collections.Generic;

namespace HW18
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car("BMW",2005,new WashingCard(new DateTime(2021,09,1),500)),
                new Car("Opel",1995,new WashingCard(new DateTime(2025,09,1),30)),
                new Car("VW",2020,new WashingCard(new DateTime(2023,09,1),20)),
                new Car("Audi",2018,new WashingCard(new DateTime(2020,12,1),1000)),
                new Car("Citroen",1953,new WashingCard(new DateTime(2022,09,1),100)),
                new Car("Peugeot",2000,new WashingCard(new DateTime(2023,09,1),2000)),
                new Car("Ford",2019,new WashingCard(new DateTime(2027,09,1),550)),
                new Car("Mercedes",2020,new WashingCard(new DateTime(2026,09,1),3100)),
                new Car("Toyota",2003,new WashingCard(new DateTime(2025,09,1),8175)),
                new Car("Kia",2010,new WashingCard(new DateTime(2024,09,1),900))
            };

            WashingStation washingStation1 = new WashingStation("Alex",
                new List<WashingService> {
                new WashingService(ServiceName.CleaningGlassFromTheInsideWithChemicals,550),
                new WashingService(ServiceName.ContactlessCarWashDoorSills,300),
                new WashingService(ServiceName.LeatherAirConditioning,1000),
                new WashingService(ServiceName.ManualBodyWashWithNanoShampoo,1500),
                new WashingService(ServiceName.SuperWaxBodyCoating,3500),
                new WashingService(ServiceName.TrunkCleaning,200),
                new WashingService(ServiceName.VacuumingAndWetCleaningPlasticParts,500)});
            washingStation1.InsufficientFundsOnTheCard += Car.InsufficientFundsOnTheCard;
            washingStation1.SuccessfulCarWash += Car.SuccessfulCarWash;
            washingStation1.CarIsClean += Car.CarIsClean;

            WashingStation washingStation2 = new WashingStation("Bingo",
                new List<WashingService> {
                    new WashingService(ServiceName.CleaningGlassFromTheInsideWithChemicals, 300),
                    new WashingService(ServiceName.ContactlessCarWashDoorSills, 550),
                    new WashingService(ServiceName.LeatherAirConditioning, 1500),
                    new WashingService(ServiceName.ManualBodyWashWithNanoShampoo, 1100),
                    new WashingService(ServiceName.SuperWaxBodyCoating, 200),
                    new WashingService(ServiceName.TrunkCleaning, 1000),
                    new WashingService(ServiceName.VacuumingAndWetCleaningPlasticParts, 350)});
            washingStation2.InsufficientFundsOnTheCard += Car.InsufficientFundsOnTheCard;
            washingStation2.SuccessfulCarWash += Car.SuccessfulCarWash;
            washingStation2.CarIsClean += Car.CarIsClean;

            List<WashingStation> stations = new List<WashingStation> { washingStation1, washingStation2 };   

           washingStation1.WashingCar(cars,washingStation1);      







            Console.ReadKey();
        }
    }
}

