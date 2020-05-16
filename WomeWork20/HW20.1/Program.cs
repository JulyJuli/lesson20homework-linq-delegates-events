using System;
using System.Collections.Generic;

namespace HW20._1
{
    public class Program
    {

       
        
        static void Main(string[] args)
        {
            List<WashingStation> washingStations = new List<WashingStation>();

            Random rndWashingPrice = new Random();
            Random rndWashingOptions = new Random();

            int countStation = 2;
            int countServise = 3;

            for (int i = 0; i < countStation; i++)
            {
                var washStation = new WashingStation(Convert.ToString((NameStations)i + 1));
                Console.WriteLine(washStation.NameStation);
                for (int j = 0; j < countServise; j++)
                {
                    var washStations = new WashingService(Convert.ToString((WashingOptions)rndWashingOptions.Next(1, 6)), rndWashingPrice.Next(50, 200));
                    washStation.washingServices.Add(washStations);
                    Console.WriteLine(washStation.washingServices[j].NameService);
                }
                washingStations.Add(washStation);
            }

            Random carModel = new Random();
            Random cardMoney = new Random();
            Random yearOfCar = new Random();
            Random dataTimeYear = new Random();            
            Random dataTimeMonth = new Random();
            Random dataTimeDay = new Random();

            List<Car> carsList = new List<Car>();

            for (int i = 0; i < 10; i++)
            {
                var cars = new Car(Convert.ToString((CarModels)carModel.Next(1, 10)), yearOfCar.Next(1990, 2020), new WashingCard(cardMoney.Next(0, 500), new DateTime(dataTimeYear.Next(2019, 2020), dataTimeMonth.Next(1,12), dataTimeDay.Next(1,30))), false);                
                carsList.Add(cars);
            }

            for (int i = 0; i < washingStations.Count; i++)
            {
                washingStations[i].SuccessfulWash += Car.SuccessfulWash;
                washingStations[i].InsufficientFunds += Car.InsufficientFunds;
                washingStations[i].NoWashRequired += Car.NoWashRequired;
            }


            
            int repetitions = 10;
            
                for (int i = 0; i < repetitions; i++)
                {
                    washingStations[i].CarWashProcess(carsList, washingStations[i]);
                    Console.WriteLine("\n////////////////////////////////////////////////////////////////\n");
                }              
                      
        }
    }
}

