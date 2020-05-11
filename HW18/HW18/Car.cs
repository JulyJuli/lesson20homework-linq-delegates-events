using System;

namespace HW18
{
    public class Car
    {
        private string _model = "Ford";
        private int _yearOfIssue=1950;
        public Car(string model, int yearOfIssue, WashingCard washingCard)
        {
            Model = model;
            YearOfIssue = yearOfIssue;
            WashingCard = washingCard;
            CarCleanliness = (CarCleanliness)random.Next(0, 2);
        }
        public string Model
        {
            get => _model;
            set
            {
                if (value != string.Empty)
                {
                    _model = value;
                }
            }
        }
        public int YearOfIssue
        {
            get => _yearOfIssue;
            set
            {
                if (value > 1950)
                {
                    _yearOfIssue = value;
                }
            }
        }
        public WashingCard WashingCard { get; set; }
        public static WashingService WashingService { get; set; }
        public static Random random = new Random();
        public CarCleanliness CarCleanliness { get; set; }
        public override string ToString()
        {
            return $"\nWelcome {Model} {YearOfIssue} year of release\n" +
                $"Car status:{CarCleanliness}";
        }
        public static void SuccessfulCarWash(Car car)
        {
            Console.WriteLine("Successful wash!");//WashingCard.Balance
        }
        public static void InsufficientFundsOnTheCard(Car car)
        {
            Console.WriteLine("Not enough funds on the card!");
        }
        public static void CarIsClean(Car car)
        {
            Console.WriteLine("Your car is clean!");
        }
    }
}
