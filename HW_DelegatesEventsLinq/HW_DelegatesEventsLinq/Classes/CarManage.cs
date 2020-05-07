using System;
using System.Collections.Generic;


namespace HW_DelegatesEventsLinq.Classes
{
    public delegate void MYDelegate(Car car);
    public static class CarManage
    {
        //Пусть каждая из грязных машин попробует заехать на автомойку и получить услугу.
        
        public static void GetWashing(List<Car> cars, List<WashingStation> stations)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Status == EnumStatus.Dirty)
                {
                    int a = Car.rnd.Next(0, 2);
                    Console.WriteLine($"\nCar: {cars[i]} choose station {stations[a]}");
                    WashingService s=ChooseService(stations[a],cars[i]);
                    ToPay(cars[i], s, stations[a]);
                }
            }
        }
           
        private static WashingService ChooseService(WashingStation station,Car car)
        {
            int index = Car.rnd.Next(0, 2);
            Console.WriteLine($"{station.Services[index]} has choosed");
            WashingService a = station.Services[index];           
            return a;
        }


        //Если средств недостаточно – обрабатываете событие «недостаточно средств» -например, пытаетесь поехать на вторую мойку
        //или отказываетесь от идеи помыть машину.
        //Не забывайте менять состояние баланса на WashingCard после мойки.
        private static void ToPay(Car car, WashingService service, WashingStation station)
        {
            if (car.Card.Deadline > DateTime.Now && car.Card.Balance > service.Price)
            {
                car.Card.Balance -= service.Price;
                //Console.WriteLine($"new balance is {car.Card.Balance}");
                car.Status = EnumStatus.Clean;
                station.InvokeEvent(car);
            }
            else
            {
                station.InvokeEvent(car);
            }
        }
    }
}
