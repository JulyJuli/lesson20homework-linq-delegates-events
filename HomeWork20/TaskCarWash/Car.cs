using System;

namespace TaskCarWash
{
    public class Car
    {
        private string _nameCar;

        private int _year;
        public Car(string nameCar, int year, WashingCard card, StateOfCar state)
        {
            NameCar = nameCar;
            Year = year;
            Card = card;
            State = state;
        }
        public string NameCar 
        {
            get => _nameCar;
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _nameCar = value;
                }
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value>0&&value<2021)
                {
                    _year = value;
                }
            }
        }

        public WashingCard Card { get; private set; }

        public StateOfCar State { get; set; }

        public override string ToString()
        {
            return $"Name: {NameCar}\nYear of car manufacture: {Year}\nState of card: {Card}\nState of car: {State}";
        }
        
        public static void MessageCarIsClean(Car car)
        {
            Console.WriteLine($"\nYour car washed successfully!\nBalance of card after washing: {car.Card.Balance}\nCar state - {car.State}");
        }

        public static void MessageCarIsNotClean(Car car)
        {
            Console.WriteLine($"\nYour car can't be washed! Your car is clean!");
        }        

        public static void MessageTopUpCard(Car car)
        {
            Console.WriteLine($"\nYour car can't be washed! Not enough money!\nYour card is replenished. Balance: {car.Card.Balance+=1000.0M}");
        }
    }
}
