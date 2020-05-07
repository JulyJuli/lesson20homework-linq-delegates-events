
namespace HW_DelegatesEventsLinq.Classes
{
    public class WashingService
    {
        // WashingService: имя услуги, стоимость
        public EnumService ServiceName { get; set; }
        public decimal Price { get; set; }
        public WashingService(EnumService serviceName, decimal price)
        {
            ServiceName = serviceName;
            Price = price;
        }
        public override string ToString()
        {
            return $"{ServiceName}-{Price}";
        }
    }
}
