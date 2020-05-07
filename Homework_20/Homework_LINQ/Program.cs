using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Print all numbers from 10 to 50 separated by commas");
            IEnumerable<int> numbers = Enumerable.Range(10, 40 + 1);
            foreach (var n in numbers)
            {
                Console.Write(n + ", ");
            }

            Console.WriteLine("\n\n2.Print only that numbers from 10 to 50 that can be divided by 3");
            IEnumerable<int> number = Enumerable.Range(10, 40 + 1).Where(n => n % 3 == 0);
            foreach (var numb in number)
            {
                Console.Write(numb + ", ");
            }

            Console.WriteLine("\n\n3.Output word Linq 10 times");
            IEnumerable<string> word = Enumerable.Repeat("Linq", 10);
            foreach (var n in word)
            {
                Console.Write(n + " ");
            }


            Console.WriteLine("\n\n4.Output all words with letter 'a' in string aaa;abb;ccc;dap");
            var a = "a";
            string[] strings = { "aaa", "abb", "ccc", "dap" };
            var stringWords = strings.Where(s => s.Contains(a));
            foreach (var n in stringWords)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n\n5.Output number of letters 'a' in the words with this letter in string aaa;abb;ccc;dap separated by comma");
            var b = "a";
            string[] strings2 = { "aaa", "abb", "ccc", "dap" };
            var stringsWords2 = strings.Where(s => s.Contains(b)).Select(s => string.Concat(s.Count().ToString()));
            foreach (var count in stringsWords2)
            {
                Console.Write(count + ", ");
            }

            Console.WriteLine("\n\n6.Output true if word abb exists in line  aaa;xabbx;abb;ccc;dap, otherwise false");
            var words = "abb";
            string[] line = { "aaa", "xabbx", "abb", "ccc", "dap" };
            Console.WriteLine(line.Contains(words));

            Console.WriteLine("\n\n7.Get the longest word in string aaa;xabbx;abb;ccc;dap");
            string[] line4 = { "aaa", "xabbx", "abb", "ccc", "dap" };
            Console.WriteLine(line4.OrderByDescending(l => l.Length).First());

            Console.WriteLine("\n\n8.Calculate average length of word in string aaa;xabbx;abb;ccc;dap");
            string[] line1 = { "aaa", "xabbx", "abb", "ccc", "dap" };
            Console.WriteLine(line1.Average(s => s.Length));

            Console.WriteLine("\n\n9.Print the shortest word reversed in string aaa;xabbx;abb;ccc;dap;zh");
            string[] line3 = { "aaa", "xabbx", "abb", "ccc", "zh", "dap" };
            var shortest = line3.OrderByDescending(l => l.Length).Last().Reverse().ToArray();
            Console.WriteLine(shortest);

            Console.WriteLine("\n\n10.Print true if in the first word that starts from aa all letters are 'a' otherwise false baaa;aabb;xabbx;abb;ccc;dap;zh");
            var starts = "aa";
            string[] line2 = { "baaa", "aabb", "xabbx", "abb", "ccc", "dap", "zh" };
            var boolvariable = line2.All(l => l.StartsWith(starts));
            Console.WriteLine(boolvariable);

            Console.ReadKey();
        }
    }
}