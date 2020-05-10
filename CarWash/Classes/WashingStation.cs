using System;
using System.Collections.Generic;

namespace CarWash.Classes
{
    public class WashingStation
    {
        public WashingStation(string name, IList<WashingService> serviceList)
        {
            Name = name;
            ServiceList = serviceList;
        }

        public string Name { get; set; }

        public IList<WashingService> ServiceList { get; set; }

        public event EventHandler<WashingService> ServiceAttempt;

        public void ServeCars(WashingService service)
        {
                ServiceAttempt.Invoke(this, service);
        }
    }
}
