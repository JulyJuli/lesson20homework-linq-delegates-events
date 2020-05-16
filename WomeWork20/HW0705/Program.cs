using System;
using System.Collections.Generic;
using System.Linq;

namespace HW0705
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Console.WriteLine("//////////////////Task 1//////////////////\n");

            var numbers = string.Join(", ", Enumerable.Range(10, 41));
            Console.Write(numbers);

            //Task 2

            Console.WriteLine("\n\n//////////////////Task 2//////////////////\n");

            IEnumerable<int> whole = Enumerable.Range(10, 41).Where(n => n % 3 == 0);
            foreach (var i in whole)
            {                
                Console.Write($"{i} ");
            }

            //Task 3

            Console.WriteLine("\n\n//////////////////Task 3//////////////////\n");

            IEnumerable<string> linq = Enumerable.Repeat("Linq", 10);
            foreach (var item in linq)
            {
                Console.WriteLine(item);
            }

            //Task 4

            Console.WriteLine("\n\n//////////////////Task 4//////////////////\n");

            string words = "aaa;abb;ccc;dap";
            IEnumerable<string> word = words.Split(";").Where(p => p.Contains("a"));
            foreach (string item in word)
            Console.WriteLine(item);

            //Task 5

            Console.WriteLine("\n\n//////////////////Task 5//////////////////\n");

            string word1 = "aaa;abb;ccc;dap";
            var words1 = string.Join(", ", word1.Split(';').Select(p => p.Count(p => p == 'a')));
            foreach (var item in words1)
            {
                Console.Write(item);
            }           
            
            //Task 6

            Console.WriteLine("\n\n//////////////////Task 6//////////////////\n");

            string word2 = "aaa;xabbx;abb;ccc;dap";
            var words2 = word2.Split(";").Contains("abb") ? true : false;
            Console.WriteLine(words2);

            //Task 7

            Console.WriteLine("\n\n//////////////////Task 7//////////////////\n");

            string word3 = "aaa;xabbx;abb;ccc;dap";
            var words3 = word3.Split(";").OrderBy(p => p.Length).LastOrDefault();
            Console.WriteLine(words3);         

           //Task 8

           Console.WriteLine("\n\n//////////////////Task 8//////////////////\n");

            string word4 = "aaa;xabbx;abb;ccc;dap";
            var words5 = word3.Split(";").Select(p => p.Length).Average();
            Console.WriteLine(words5);

            //Task 9

            Console.WriteLine("\n\n//////////////////Task 9//////////////////\n");

            string word6 = "aaa;xabbx;abb;ccc;dap;zh";
            var words6 = word6.Split(";").OrderBy(p => p.Length).FirstOrDefault().Reverse();            
            foreach (var w in words6)
            {
                Console.Write(w);
            }                

            //Task 10

            Console.WriteLine("\n\n//////////////////Task 10//////////////////\n");

            string word7 = "baaa;aabb;xabbx;abb;ccc;dap;zh";
            var words7 = word7.Split(";").Select(p => p.Substring(0, 2).Equals("aa"));
            
            foreach (var item in words7)
            {                
                Console.WriteLine(item);
            }               
        }
    }
}
