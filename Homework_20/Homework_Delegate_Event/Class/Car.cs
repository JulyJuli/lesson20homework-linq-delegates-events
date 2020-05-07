using Homework_Delegate_Event.Enum;
using System;

namespace Homework_Delegate_Event
{
    public class Car
    {
        public static Car car;
        public int _year;
        public Car(string brand, int year, WashingCard washingCard)
        {
            Brand = brand;
            YearOfManufacture = year;
            WashingCard = washingCard;
            State = (EnumState)random.Next(1, 2);

        }
        public string Brand { get; set; }
        public WashingCard WashingCard { get; set; }
        public EnumState State { get; set; }
        public static Random random = new Random();

        public int YearOfManufacture
        {
            get => _year;
            set
            {
                if (1950 <= value && value <= 2021)
                {
                    _year = value;
                }
            }
        }

        public static void WashingStation1_SuccessfulWashing()
        {
            Console.WriteLine($"Welcome. Washing car: {car.State}");

        }
        public static void WashingStation1_InsufficientFunds()
        {
            Console.WriteLine($"Not enough money. Car state: {car.State}, car {car.WashingCard}");
        }
        public static void WashingStation2_SuccessfulWashing()
        {
            Console.WriteLine($"Can pay. Car state: {car.State}");
        }
        public static void WashingStation2_InsufficientFunds()
        {
            Console.WriteLine($"Error. Car state: {car.State}, car {car.WashingCard}");
        }
        public override string ToString()
        {
            return $"{Brand}, {YearOfManufacture}, {WashingCard}, {State}";
        }
    }
}