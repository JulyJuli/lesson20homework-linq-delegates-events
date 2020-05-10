using System;

namespace CarWash.Classes
{
    public class Car
    {
        public Car(string brand, int yearOfRelease, WashingCard washCard, bool isClean)
        {
            Brand = brand;
            YearOfRelease = yearOfRelease;
            WashCard = washCard;
            IsClean = isClean;
        }

        public string Brand { get; set; }

        public int YearOfRelease { get; set; }

        public WashingCard WashCard { get; set; }

        public bool IsClean { get; set; }

        public void WashingServiceHandler(object sender, WashingService service)
        {
            if (IsClean == false)
            {
                if (WashCard.Balance >= service.Price)
                {
                    IsClean = true;
                    WashCard.Balance -= service.Price;

                    Console.WriteLine($"The {Brand} is clean now! {service.Price} was deducted from the car's washing card.");
                }
                else
                {
                    Console.WriteLine($"The amount on {Brand} washing card is insufficient to cover this service!");
                }
                
            }
            else
            {
                Console.WriteLine($"The {Brand} is already clean!");
            }
        }
    }
}
