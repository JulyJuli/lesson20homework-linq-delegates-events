using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW_DelegatesEventsLinq.Classes.CarManage;

namespace HW_DelegatesEventsLinq.Classes
{
     public class WashingStation
    {
        //WashingStation: имя станции, список предоставляемых WashingService, события: успешная мойка/ недостаточно средств.
        public string StationName { get; set; }
        public List<WashingService> Services { get; set; }

        public WashingStation(string name, List<WashingService> services)
        {
            StationName = name;
            Services = services;
        }
        public event MYDelegate SuccessWashEvent;

        public event MYDelegate UnsuccessWashEvent;
        public void InvokeEvent(Car car)
        {
            if (car.Status == EnumStatus.Clean)
                SuccessWashEvent?.Invoke(car);
            else if (car.Status == EnumStatus.Dirty)
                UnsuccessWashEvent?.Invoke(car);
        }

        public override string ToString()
        {
            return $"\"{StationName}\"";
        }
    }
}
