using HW_DelegatesEventsLinq.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_DelegatesEventsLinq
{
    class Program
    {
        static void Main(string[]args)
        {
            //        Tasks:     
             
            //            1.Print all numbers from 10 to 50 separated by commas
           
            var newList1 = Enumerable.Range(10, 41);
            Console.WriteLine(string.Join(",", newList1));

            //var stringNumberWithCommas1 = string.Join(",", Enumerable.Range(10, 41));
            //Console.WriteLine(stringNumberWithCommas1);
            Console.WriteLine(new string('=',75));
            //============================================================================================
            //2.Print only that numbers from 10 to 50 that can be divided by 3

            var numbersDevBy3 = Enumerable.Range(10, 41).Where(x => x % 3 == 0);
            
            foreach(var x in numbersDevBy3)
                Console.Write(x+" ");
            Console.WriteLine(new string('=', 75));
            //============================================================================================
            //3.Output word "Linq" 10 times
            var listStrLINQ = Enumerable.Repeat("LINQ", 10);
            foreach(var linq in listStrLINQ)
                Console.Write(linq+" ");
            Console.WriteLine();                      
            
            Action<string> action1 = str =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(str+" ");
                }
            };
            action1("Linq");
            Console.WriteLine();
            Console.WriteLine(new string('=', 75));
            //============================================================================================
            //4.Output all words with letter 'a' in string "aaa;abb;ccc;dap"
            string someStr = "psdftrewq;aaa;abb;ccc;dap;xabbx";
            //string someStr = "asd;asd;asd;asd;asd;asd";
            var listWordsWithA = someStr.Split(';').Where(x => x.Contains("a"));
            foreach (var x in listWordsWithA)
                Console.Write(x + " ");
                Console.WriteLine("\n"+new string('=', 75));
            //============================================================================================
            //5.Output number of letters 'a' in the words with this letter in string "aaa;abb;ccc;dap" separated by comma
            var q = someStr.Split(';');
            var newList =  from x in q
                     where x.Contains("a")
                     select string.Concat(x.Count().ToString(),",") ;
            var newList2 = someStr.Split(';').Where(i => i.Contains("a")).Select(i => string.Concat(i.Count().ToString(),","));
            foreach (var x in newList2)
                Console.Write(x);
            Console.WriteLine();
            //string [] s= someStr.Split(';');
            foreach (var x in newList)
                Console.Write(x);
            Console.WriteLine("\n" + new string('=', 75));
            //============================================================================================
            //6.Output true if word "abb" exists in line  "aaa;xabbx;abb;ccc;dap", otherwise false
            Console.WriteLine(someStr.Contains("abb")? "true" : "false");

            Predicate<string> predicateD = abb => someStr.Contains(abb);
            Console.WriteLine(predicateD("abb"));
            Console.WriteLine("\n" + new string('=', 75));
            //============================================================================================
            //7.Get the longest word in string "aaa;xabbx;abb;ccc;dap"
            Console.WriteLine(someStr);
            var masStr = someStr.Split(';');
            Action<string[]> findMaxWord = mas =>
              {
                  string max = mas[0];
                  for (int i = 1; i < mas.Length; i++)
                  {
                      max = max.Length < mas[i].Length ? mas[i] : max;
                  }
                  Console.WriteLine(max);
              };
            findMaxWord(masStr);

            //string lonlestStr = masStr.OrderByDescending(x => x.Length).First();
            //Console.WriteLine(lonlestStr);

            Console.WriteLine("\n" + new string('=', 75));
            //============================================================================================
            //8.Calculate average length of word in string "aaa;xabbx;abb;ccc;dap"
            
            var averageLength = someStr.Split(';').Average(x=> x.Length);
            Console.WriteLine(averageLength);
            Console.WriteLine("\n" + new string('=', 75));
            //============================================================================================
            //9.Print the shortest word reversed in string "aaa;xabbx;abb;ccc;dap;zh"
            string someString1 = "aaa;xabbx;abb;ccc;dap;zh";
            string shortestWord = someString1.Split(';').OrderBy(x => x.Length).First();            
            foreach(var chars in shortestWord.Reverse())
                Console.Write(chars);
            Console.WriteLine("\n" + new string('=', 75));
            //============================================================================================
            //10.Print true if in the first word that starts from "aa" all letters are 'a' otherwise false "baaa;aabb;xabbx;abb;ccc;dap;zh"
            string someString2 = "baaa;aaaa;aabb;xabbx;abb;ccc;dap;zh;aaaaaaa;";
            
            var ad = someString2.Split(';').Where(x => x.StartsWith("a")).First().All(x=>x=='a');
            Console.WriteLine(ad);

            var strAaa = from a in someString2.Split(';')
                         where a.StartsWith("a")
                         select a;
            var strAAAA = strAaa.First();
            var strAa = strAAAA.All(a => a == 'a');

            Console.WriteLine(strAa);
            Console.WriteLine("\n" + new string('=', 75));
            //============================================================================================

            //            Delegates and events
            //Задача «Автомойка» (придумала сама)
            //У вас есть 4 сущности: Car, WashingStation и WashingCard, WashingService где каждая из них содержит следующие поля:
            //WashingCard: срок действия, баланс
            //Car: марка, год выпуска, WashingCard, состояние (чистая / грязная), метод для обработки уведомлений
            // WashingService: имя услуги, стоимость
            //WashingStation: имя станции, список предоставляемых WashingService, события: успешная мойка/ недостаточно средств.

            //Опишите следующую логику программы : у вас есть 10 разных машин и 2 мойки.
            //Пусть каждая из грязных машин попробует заехать на автомойку и получить услугу.
            //Если средств недостаточно – обрабатываете событие «недостаточно средств» -например, пытаетесь поехать на вторую мойку или отказываетесь от идеи помыть машину.
            //Если все в порядке – обрабатываете событие «успешная мойка» -меняете статус машины на «чистая».
            //Не забывайте менять состояние баланса на WashingCard после мойки.
            //Старайтесь все состояния генерировать случайно
            Car car1 = new Car("Lada", 2005,
                new WashingCard(new DateTime(2021,03,12), 15.40m));
            Car car2 = new Car("BMW", 2018,
                new WashingCard(new DateTime(2022,04,13), 800.00m));
            Car car3 = new Car("Tavria", 2001, 
                new WashingCard(new DateTime(2023,05,14), 247.00m));
            Car car4 = new Car("Chevrolet", 2015, 
                new WashingCard(new DateTime(2024, 06,15), 560.00m));
            Car car5 = new Car("Renault", 2015, 
                new WashingCard(new DateTime(2025, 07,17), 540.00m));
            Car car6 = new Car("Mersedes", 2005, 
                new WashingCard(new DateTime(2021, 08 ,18), 154.00m));
            Car car7 = new Car("Daewoo", 2017, 
                new WashingCard(new DateTime(2022,09,18), 428.00m));
            Car car8 = new Car("Cherry", 2019, 
                new WashingCard(new DateTime(2023,10,19), 341.00m));
            Car car9 = new Car("Volga", 1998, 
                new WashingCard(new DateTime(2024,11,20), 58.00m));
            Car car10 = new Car("Ford", 1999, 
                new WashingCard(new DateTime(2025,12,21), 135.00m));
            List<Car> cars = new List<Car>();
            cars.AddRange(new List<Car> { car1, car2, car3, car4, car5, car6, car7, car8, car9, car10 });
            WashingStation station1 = new WashingStation("Yljana",
                new List<WashingService> {new WashingService(EnumService.ContactlessSink,155.00m),
                new WashingService(EnumService.ManualWash,140.00m),
                new WashingService(EnumService.VacuumCleaning,100.00m) });
            station1.SuccessWashEvent += Car.Station1_SuccessWashEventHendler;
            station1.UnsuccessWashEvent += Car.Station1_UnsuccessWashEventHendler;

            WashingStation station2 = new WashingStation("KharkovOil",
                new List<WashingService> {new WashingService(EnumService.ContactlessSink,130.00m),
                new WashingService(EnumService.ManualWash,125.00m),
                new WashingService(EnumService.VacuumCleaning,98.00m),
                new WashingService(EnumService.GlassCleaning,85.00m)
                });
            station2.SuccessWashEvent += Car.Station2_SuccessWashEventHendler;
            station2.UnsuccessWashEvent += Car.Station2_UnsuccessWashEventHendler;
            List<WashingStation> stations = new List<WashingStation>();
            stations.AddRange(new List<WashingStation> { station1, station2 });

            CarManage.GetWashing(cars, stations);
        }
    }
}
