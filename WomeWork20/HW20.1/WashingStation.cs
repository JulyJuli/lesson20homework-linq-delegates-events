using System;
using System.Collections.Generic;


namespace HW20._1
{
    public class WashingStation
    {
        Random rnd = new Random();
        public List<WashingService> washingServices;
        public WashingStation(string nameStation)
        {
            NameStation = nameStation;
            washingServices = new List<WashingService>();
        }
        public string NameStation { get; set; }

        public delegate void WashCheck(Car car);

        public event WashCheck SuccessfulWash;
        public event WashCheck InsufficientFunds;
        public event WashCheck NoWashRequired;

        public void CarWashProcess(List<Car> cars)
        {

            //false = Dirt
            for (int i = 0; i < cars.Count; i++)
            {
                int car = rnd.Next(0, cars.Count);
                int servise = rnd.Next(0, washingServices.Count);
                if (cars[car].StateCar.Equals(StateCar.Dirt))
                {
                    if (cars[car].WashingCard.Balance >= washingServices[servise].PriceService)
                    {
                        cars[car].WashingCard.Balance -= washingServices[servise].PriceService;
                        cars[car].StateCar = StateCar.Clear;
                        SuccessfulWash(cars[car]);
                    }
                    else
                    {
                        InsufficientFunds(cars[car]);
                    }
                }
                else
                {
                    NoWashRequired(cars[car]);
                }
            }

        }
    }
}
