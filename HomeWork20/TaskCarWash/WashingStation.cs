using System;
using System.Collections.Generic;

namespace TaskCarWash
{
    public class WashingStation
    {
        Random rand = new Random();

        private string _nameStation;

        public List<WashingServise> washingServices;
        public WashingStation(string nameStation)
        {
            NameStation = nameStation;
            washingServices = new List<WashingServise>();
        }

        public string NameStation
        {
            get => _nameStation;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nameStation = value;
                }
            }
        }


        public delegate void Massage(Car car);

        public event Massage SuccsessfullClean;

        public event Massage UnSuccsessfullClean;

        public event Massage UnSuccsessfulNotEnoughMoney;
      
        public void CheckCar(List<Car> car, WashingStation station)
        {
            int indexServece = rand.Next(0, 2);
            int indexCar = rand.Next(0, 9);

            Console.WriteLine(car[indexCar].ToString());

            if (car[indexCar].State == StateOfCar.Dirty)
                {
                if (car[indexCar].Card.Balance >= station.washingServices[indexServece].PriceServise)
                {
                    Console.WriteLine($"\nStation: {station.NameStation}\nYour service is {station.washingServices[indexServece].Servise}, price: {station.washingServices[indexServece].PriceServise}");
                    car[indexCar].Card.Balance -= station.washingServices[indexServece].PriceServise;
                    car[indexCar].State = StateOfCar.Clean;
                    SuccsessfullClean(car[indexCar]);
                }
                else
                {
                    Console.WriteLine($"\nStation: {station.NameStation}\nYour service is {station.washingServices[indexServece].Servise}, price: {station.washingServices[indexServece].PriceServise}");
                    UnSuccsessfulNotEnoughMoney(car[indexCar]);
                    Console.WriteLine($"\nStation: {station.NameStation}\nYour service is {station.washingServices[indexServece].Servise}, price: {station.washingServices[indexServece].PriceServise}");
                    car[indexCar].Card.Balance -= station.washingServices[indexServece].PriceServise;
                    car[indexCar].State = StateOfCar.Clean;
                    SuccsessfullClean(car[indexCar]);
                }
            }
            else
            {
                UnSuccsessfullClean(car[indexCar]); 
            }
        }
    }
}
