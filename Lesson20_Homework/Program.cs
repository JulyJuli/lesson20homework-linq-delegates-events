using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson20_Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("================ Task 1 ================");

            IEnumerable<int> numbers1 = Enumerable.Range(10, 41);

            string result1 = string.Join(", ", numbers1);
            Console.WriteLine(result1);

            Console.WriteLine("================ Task 2 ================");

            IEnumerable<int> numbers2 = Enumerable.Range(10, 41).Where(num => num % 3 == 0);

            string result2 = string.Join(", ", numbers2);
            Console.WriteLine(result2);

            Console.WriteLine("================ Task 3 ================");

            IEnumerable<string> linqString = Enumerable.Repeat("Linq", 10);

            string result3 = string.Join(", ", linqString);
            Console.WriteLine(result3);

            Console.WriteLine("================ Task 4 ================");

            string string4 = "aaa;abb;ccc;dap";

            List<string> list4 = string4.Split(';').ToList();

            var filteredList4 = from word in list4
                                where word.Contains('a')
                                select word;

            string result4 = string.Join(", ", filteredList4);
            Console.WriteLine(result4);

            Console.WriteLine("================ Task 5 ================");

            string string5 = "aaa;abb;ccc;dap";

            List<string> list5 = string5.Split(';').ToList();

            var filteredList5 = from word in list5
                                let charNum = word.Count<char>(a => a == 'a')
                                select charNum;

            string result5 = string.Join(", ", filteredList5);
            Console.WriteLine(result5);

            Console.WriteLine("================ Task 6 ================");

            string string6 = "aaa;xabbx;abb;ccc;dap";

            List<string> list6 = string6.Split(';').ToList();

            Console.WriteLine(list6.Contains("abb"));

            Console.WriteLine("================ Task 7 ================");

            string string7 = "aaa;xabbx;abb;ccc;dap";

            List<string> list7 = string7.Split(';').ToList();

            string result7 = list7.OrderByDescending(word => word.Length).First();
            Console.WriteLine(result7);

            Console.WriteLine("================ Task 8 ================");

            string string8 = "aaa;xabbx;abb;ccc;dap";

            List<string> list8 = string8.Split(';').ToList();

            var lengthList = from word in list8
                             let length = word.Count<char>()
                             select length;

            double result8 = lengthList.Average();
            Console.WriteLine(result8);

            Console.WriteLine("================ Task 9 ================");

            string string9 = "aaa;xabbx;abb;ccc;dap;zh";

            List<string> list9 = string9.Split(';').ToList();

            var charArray = list9.OrderBy(word => word.Length).First().ToCharArray();
            Array.Reverse(charArray);

            string result9 = new string(charArray);
            Console.WriteLine(result9);

            Console.WriteLine("================ Task 10 ================");

            string string10 = "baaa;aabb;xabbx;abb;ccc;dap;zh";

            List<string> list10 = string10.Split(';').ToList();

            string startsWithAa = list10.First(word => word.StartsWith("aa"));

            Console.WriteLine(startsWithAa.All(character => character == 'a'));
        }
    }
}
