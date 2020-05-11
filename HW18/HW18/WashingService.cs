

namespace HW18
{
    public class WashingService
    {
        private int _priceOfService;
        public WashingService(ServiceName serviceName, int priceOfService)
        {
            ServiceName = serviceName;
            PriceOfService = priceOfService;
        }
        public ServiceName ServiceName { get; set; }
        public int PriceOfService
        {
            get => _priceOfService;
            set
            {
                if (value > 0)
                {
                    _priceOfService = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{ServiceName} cost {PriceOfService}.";
        }
    }
}
