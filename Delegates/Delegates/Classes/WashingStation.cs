using System;

namespace Delegates
{
    public class WashingStation
    {
        private int _balance = 0;
        public string Name { get; set; }

        public int Balance
        {
            get => _balance;
            set => _balance += value;
        }
        public WashingService WashingServices { get; set; }

        public event EventHandler<WashingService> NotEnoughMoney = delegate { };
        public event EventHandler<WashingService> SuccessfulWash = delegate { };
        public event EventHandler<WashingService> NoWashRequired = delegate { };

        public void СarArrived(Car car)
        {
            SuccessfulWash += car.Successful;
            NotEnoughMoney += car.NoMoney;
            NoWashRequired += car.NoNeedWash;

            if (car.IsDirty)
            {
                if (car.WashingCard.Balance >= WashingServices.Price)
                {
                    Balance = WashingServices.Price;
                    SuccessfulWash(null, WashingServices);
                }
                else
                {
                    NotEnoughMoney(null, WashingServices);
                }
            }
            else
            {
                NoWashRequired(null, WashingServices);
            }

            SuccessfulWash -= car.Successful;
            NotEnoughMoney -= car.NoMoney;
            NoWashRequired -= car.NoNeedWash;
        }
    }
}
