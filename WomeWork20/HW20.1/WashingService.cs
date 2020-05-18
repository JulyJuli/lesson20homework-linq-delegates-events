using System;
using System.Collections.Generic;
using System.Text;

namespace HW20._1
{
    public class WashingService
    {
        public WashingService (string nameService, double priceService)
        {
            NameService = nameService;
            PriceService = priceService;
        }
        
        public string NameService { get; set; }
        public double PriceService { get; set; }
    }
}
