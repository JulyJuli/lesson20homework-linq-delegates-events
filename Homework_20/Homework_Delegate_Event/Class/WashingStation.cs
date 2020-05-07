using Homework_Delegate_Event.Enum;
using System;
using System.Collections.Generic;

namespace Homework_Delegate_Event
{
    public delegate void MyDelegate();
    public class WashingStation
    {
        public WashingStation(string stationName, List<WashingService> listServices)
        {
            StationName = stationName;
            ListServices = listServices;
        }
        public event MyDelegate SuccessfulWashing;
        public event MyDelegate InsufficientFunds;

        public string StationName { get; set; }
        public List<WashingService> ListServices { get; set; }
        public void Events(Car car)
        {
            if (car.State == EnumState.Dirty)
            {
                InsufficientFunds.Invoke();
            }

            else
            {
                SuccessfulWashing.Invoke();
            }
        }
        public override string ToString()
        {
            return $"{StationName}";
        }


        public void PayEvent(Car car, WashingService washingService, WashingStation washingStation)
        {
            if (car.WashingCard.Balance > washingService.Cost)
            {
                car.WashingCard.Balance -= washingService.Cost;
                car.State = EnumState.Clean;
                washingStation.Events(car);
            }
            else
            {
                washingStation.Events(car);
            }
        }

        public void WashingEvent(List<WashingStation> listStation, List<Car> car)
        {
            for (int i = 0; i < car.Count; i++)
            {
                if (car[i].State == EnumState.Dirty)
                {
                    int variable = Car.random.Next(0, 2);
                    Console.Write($"{car[i].State} station: {listStation[variable]}");
                }
            }
        }

        public WashingService ChoiceService(Car car, WashingStation washingStation)
        {
            int variable = Car.random.Next(0, 2);
            WashingService washing = washingStation.ListServices[variable];
            return washing;
        }
    }
}