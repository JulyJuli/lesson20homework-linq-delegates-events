using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDeleagatesEvents
{
    public class Car
    {
        private List<CarWash> VisitedWashes { get; set; }
        public int ID { get; set; }
        public string Model { get; set; }
        public bool IsDirty { get; set; }
        private CarWash SelectedCarwash { get; set; }
        public WashingCard Card { get; set; }


        public Car(int id, string model, int balance, bool isDirty)
        {
            ID = id;
            Model = model;
            IsDirty = isDirty;
            VisitedWashes = new List<CarWash>();
            Card = WashingCard.Cards[new Random(ID).Next(0, WashingCard.Cards.Count)];
        }

        public void GetCleaning()
        {
            // Case, when car dont need a carwash.
            if (IsDirty == false)
            {
                NoCleanNeededNitification();
                return;
            }

            // Case for no available washes.
            if (CarWash.CarWashList.Count == 0)
            {
                Console.WriteLine("No car washes available.");
            }

            // Case, when no unvisited carwashes available. 
            else if (CarWash.CarWashList.Count == this.VisitedWashes.Count)
            {
                PoorDirtyCarHandler();
            }

            // Case when we have unvisited washes.
            // Car is dirty == true.
            else
            {
                SelectedCarwash = CarWashSelect();

                SelectedCarwash.CarProcessing(this);

                if (IsDirty)
                {
                    GetCleaning();
                }
            }
        }

        protected CarWash CarWashSelect()
        {
            Random random = new Random();
            CarWash result = CarWash.CarWashList.Except(VisitedWashes)
                .ToList()[random.Next(0, 
                (CarWash.CarWashList.Count - VisitedWashes.Count)
                )];

            VisitedWashes.Add(result);
            return result;
        }

        public void SuccesWashHandler(CarWash carWash)
        {
            IsDirty = false;
            Console.WriteLine(this.Model + " was washed on " + carWash.Name);
        }

        public void LowFoundsHandler(CarWash carWash)
        {
            Console.WriteLine(this.Model + " was not washed on " + carWash.Name + " - low founds");
        }

        public void NoCleanNeededNitification()
        {
            Console.WriteLine(this.Model + " was not washed - car is clean");
        }

        public void PoorDirtyCarHandler()
        {
            Console.WriteLine($"Can't afford any cleaning - {this.Model} will stay dirty.");
        }

    }
}
