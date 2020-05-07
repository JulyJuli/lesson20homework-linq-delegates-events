using System;

namespace HW_DelegatesEventsLinq.Classes
{
    public class Car
    {
        //Car: марка, год выпуска, WashingCard, состояние (чистая / грязная), метод для обработки уведомлений
        public string Make { get; set; }
        public int YearProd { get; set; }
        public EnumStatus Status { get; set; }       
        public WashingCard Card { get; set; }
        public static Random rnd = new Random();
        public Car(string make, int year, WashingCard card)
        {
            Make = make;
            YearProd = year;           
            Status =(EnumStatus) rnd.Next(1, 3);
            Card = card;
        }
       
        public static void Station1_UnsuccessWashEventHendler(Car car)
        {
            Console.WriteLine("Not enough funds. Can't pay!");
            Console.WriteLine($"Car still {car.Status}");
        }

       public static void Station1_SuccessWashEventHendler(Car car)
        {
            Console.WriteLine("Can pay!");
            Console.WriteLine($"Car has washed, Status: {car.Status}");           
        }

        public static void Station2_UnsuccessWashEventHendler(Car car)
        {
            Console.WriteLine("Error. Can't pay!");
            Console.WriteLine($"CarStatus: {car.Status}");
        }

        public static void Station2_SuccessWashEventHendler(Car car)
        {
            Console.WriteLine("Welcome!!! You can wash the car. ");
            Console.WriteLine($"CarStatus: {car.Status}");
        }

        public override string ToString()
        {
            return $"{Make} {Status} {Card}";
        }
    }
}
