namespace CarWash.Classes
{
    public class WashingService
    {
        public WashingService(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}
