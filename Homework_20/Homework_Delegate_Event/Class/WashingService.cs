using Homework_Delegate_Event.Enum;

namespace Homework_Delegate_Event
{
    public class WashingService
    {
        private decimal _cost;
        public WashingService(ServiceName serviceName, decimal cost)
        {
            ServiceName = serviceName;
            Cost = cost;
        }
        public ServiceName ServiceName { get; set; }
        public decimal Cost
        {
            get => _cost;
            set
            {
                if (value > 0)
                {
                    _cost = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{ServiceName}, {Cost}";
        }
    }
}