using System;
using System.Linq;

namespace HomeWork20
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Print all numbers from 10 to 50 separated by commas

            var numbers = string.Join(",", Enumerable.Range(10, 41));

            Console.Write(numbers);

            Console.WriteLine($"\n");

            //2. Print only that numbers from 10 to 50 that can be divided by 3

            var numbers2 = Enumerable.Range(10, 41).Where(number => number % 3 == 0);

            foreach (int number in numbers2)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine($"\n");

            //3. Output word "Linq" 10 times

            var linqWord = Enumerable.Repeat("linq", 10);

            foreach (string word in linqWord)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine($"\n");

            //4. Output all words with letter 'a' in string "aaa;abb;ccc;dap"

            string wordA = "aaa;abb;ccc;dap";

            var words = wordA.Split(';').Where(m => m.Contains("a"));

            foreach (string b in words)
            {
                Console.Write(b + " ");
            }

            Console.WriteLine($"\n");

            //5. Output number of letters 'a' in the words with this letter in string "aaa;abb;ccc;dap" separated by comma

            var words2 = string.Join(", ",wordA.Split(';').Where(b => b.Contains('a')).Select(stringSelect=> stringSelect.Count(charSelect=> charSelect == 'a')));            
           
            Console.Write(words2);

            Console.WriteLine($"\n");

            //6. Output true if word "abb" exists in line  "aaa;xabbx;abb;ccc;dap", otherwise false

            string someString = "aaa;xabbx;abb;ccc;dap";
            string check = "abb";

            var strings = someString.Split(';').Any(d => d.Contains(check)) ? "true" : "false";
            Console.Write(strings);

            Console.WriteLine($"\n");

            //7. Get the longest word in string "aaa;xabbx;abb;ccc;dap"

             var longWord = someString.Split(';').OrderByDescending(j=>j.Length).First();

            Console.Write(longWord);

            Console.WriteLine($"\n");

            //8. Calculate average length of word in string "aaa;xabbx;abb;ccc;dap"

            var averageLength = someString.Split(';').Select(r => r.Length).Average();
            
            Console.Write((int)averageLength);

            Console.WriteLine($"\n");

            // 9.Print the shortest word reversed in string "aaa;xabbx;abb;ccc;dap;zh"

            string oneString = "aaa;xabbx;abb;ccc;dap;zh";

            var reversWord = oneString.Split(';').OrderByDescending(i => i.Length).Last().ToCharArray().Reverse().ToArray();

            Console.Write(reversWord);

            Console.WriteLine($"\n");

            //10. Print true if in the first word that starts from "aa" all letters are 'a' 
            // otherwise false "baaa;aabb;xabbx;abb;ccc;dap;zh"

            string isFalse = "baaa;aabb;xabbx;abb;ccc;dap;zh";

            var checkWordA = oneString.Split(';').FirstOrDefault(y => y.StartsWith("aa")).All(s => s == 'a') ? "true":isFalse;

            Console.Write(checkWordA);

            Console.WriteLine($"\n");

            Console.ReadKey();
        }
    }
}
