namespace TaskCarWash
{
   public class WashingServise
    {
        private decimal _priceServise;
       
        public WashingServise(CarWashServise servise, decimal priceService)
        {
            Servise = servise;
            PriceServise = priceService;
        }

        public CarWashServise Servise { get; set; }

        public decimal PriceServise
        {
            get => _priceServise;
            set
            {
                if (value > 0)
                {
                    _priceServise = value;
                }
            }
        }
    }
}
