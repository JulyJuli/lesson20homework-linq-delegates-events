using System;
using System.ComponentModel;

namespace HW20._1
{
    public class Car
    {
        public Car(string carModel, int yearOfCar, WashingCard washingCard)//, bool stateCar)
        {

            CarModel = carModel;
            YearOfCar = yearOfCar;
            WashingCard = washingCard;
            //StateCar = stateCar;            
        }
        public string CarModel { get; set; }
        public int YearOfCar { get; set; }
        public WashingCard WashingCard { get; set; }

        [DefaultValue(false)]
        public bool StateCar { get; set; } /*= false;*/

        //public override string ToString()
        //{
        //    return $"{CarModel}, {YearOfCar}, {WashingCard}, {StateCar}";
        //}
        //public event WashCheck SuccessfulWash;
        //public event WashCheck InsufficientFunds;
        //public event WashCheck NoWashRequired;

        public static void SuccessfulWash(Car car)
        {
            Console.WriteLine($"Your car {car.CarModel} has been washed successfully. Balance on the map {car.WashingCard.Balance}. Machine Status Changed {car.StateCar}");
        }
        public static void InsufficientFunds(Car car)
        {

            Console.WriteLine($"Sorry there are insufficient funds on your card. The car is not washed {car.CarModel}");
        }
        public static void NoWashRequired(Car car)
        {
            Console.WriteLine($"Your car {car.CarModel} doesn’t need a sink");
        }
    }
}
