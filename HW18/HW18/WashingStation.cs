using System;
using System.Collections.Generic;

namespace HW18
{
    public class WashingStation
    {
        public delegate void MyDelegate(Car car);
        public WashingStation(string nameOfStation, List<WashingService> listOfServices)
        {
            NameOfStation = nameOfStation;
            ListOfServices = listOfServices;
        }
        public string NameOfStation { get; set; }
        public List<WashingService> ListOfServices { get; set; }

        public event MyDelegate SuccessfulCarWash;
        public event MyDelegate InsufficientFundsOnTheCard;
        public event MyDelegate CarIsClean;
        public void WashingCar(List<Car> cars, WashingStation washing)
        {
            for (int i = 0; i < 9; i++)
            {
                if (cars[i].CarCleanliness == CarCleanliness.Dirty)
                {                    
                    Console.WriteLine(cars[i].ToString() + $"\nYour balance: {cars[i].WashingCard.Balance}\n");
                    if (cars[i].WashingCard.Balance >= washing.ListOfServices[Car.random.Next(0, 6)].PriceOfService)
                    {
                        var service = washing.ListOfServices[Car.random.Next(0, 6)];
                        Console.WriteLine($"MS {washing.NameOfStation}\n You have chosen a service: {service.ServiceName}\n that costs {service.PriceOfService}\n\n");
                        cars[i].CarCleanliness = CarCleanliness.Clean;
                        SuccessfulCarWash(cars[i]);
                        Console.WriteLine($"Your balance: {cars[i].WashingCard.Balance - service.PriceOfService}");
                    }
                    else if (cars[i].WashingCard.Balance < washing.ListOfServices[Car.random.Next(0, 6)].PriceOfService)
                    {
                        InsufficientFundsOnTheCard(cars[i]);
                        Console.WriteLine($"Your balance: {cars[i].WashingCard.Balance}");
                    }
                }
                else
                {
                    Console.WriteLine(cars[i].ToString());
                    CarIsClean(cars[i]);
                }
                Console.WriteLine("------------------------");
            }
        }
    }
}



