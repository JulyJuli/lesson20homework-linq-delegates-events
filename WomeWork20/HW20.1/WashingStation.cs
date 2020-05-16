using System;
using System.Collections.Generic;
using System.Text;

namespace HW20._1
{
    public class WashingStation
    {
        Random rnd = new Random();
        public List<WashingService> washingServices;
        public WashingStation (string nameStation)
        {
            NameStation = nameStation;
            washingServices = new List<WashingService>();
        }
        public string NameStation { get; set; }
        
        public delegate void WashCheck(Car car);

        public event WashCheck SuccessfulWash;
        public event WashCheck InsufficientFunds;
        public event WashCheck NoWashRequired;

        public void CarWashProcess (List <Car> cars, WashingStation station)
        {
            int car = rnd.Next(0, cars.Count);
            int servise = rnd.Next(0, station.washingServices.Count);
            //false = Dirt
            if (cars[car].StateCar.Equals(StateCar.Dirt))
            {
                if (cars[car].WashingCard.Balance >= station.washingServices[servise].PriceService)
                {
                    cars[car].WashingCard.Balance -= station.washingServices[servise].PriceService;
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
