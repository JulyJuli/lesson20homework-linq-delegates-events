namespace Delegates
{
    public class WashingService
    {
        private int price = 0;

        public string Name { get; set; }
        public int Price
        {
            get => price;
            set { price = value; }
        }
    }
}
