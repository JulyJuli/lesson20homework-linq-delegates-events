using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLINQ
{
    public static class StringTasks
    {
        public static void Start()
        {
            Console.WriteLine("Tasks with strings.\n");
            Console.WriteLine("Task 1: nums 10...50 separated by comas.");
            StringBuilder firstString = new StringBuilder();
            for (int i = 10; i <= 50; i++)
            {
                firstString.Append($"{i}, ");
            }
            firstString.Remove(firstString.Length - 2, 2);
            Console.WriteLine("Result: " + firstString);
            Console.WriteLine(new string('~', Console.BufferWidth) + "\n");


            Console.WriteLine("Task 2: print only multiplies of 3 in previous string.");
            List<string> task2List = new List<string>();
            for (int i = 10; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    task2List.Add($"{i}");
                }
            }
            Console.WriteLine("Result: " + string.Join(", ", task2List));
            Console.WriteLine(new string('~', Console.BufferWidth) + "\n");


            Console.WriteLine("Task 3: output word \"LINQ\" 10 times.");
            int task3Num = 10;
            IEnumerable<string> linqCollection = Enumerable.Repeat("LINQ", task3Num);
            Console.Write("Result: ");
            foreach (var item in linqCollection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n" + new string('~', Console.BufferWidth) + "\n");


            Console.WriteLine("Task 4: output all words with letter 'a' in string \"aaa;abb;ccc;dap\".");
            string task4Input = "aaa;abb;ccc;dap";
            List<string> task4List = task4Input.Split(';').ToList();
            Console.Write("Result: ");
            foreach (var str in task4List)
            {
                if (str.Contains('a')) { Console.Write(str + " "); }
            }
            Console.WriteLine("\n" + new string('~', Console.BufferWidth) + "\n");


            Console.WriteLine("Task 5: output number of letters 'a' in the words " +
                "with this letter in string \"aaa;abb;ccc;dap\" separated by comma " +
                "all words with letter 'a' in string \"aaa;abb;ccc;dap\".");
            string task5Input = "aaa;abb;ccc;dap";
            Console.WriteLine("Result: " +
                string.Join(", ",
                task5Input.Split(';')
                    .Where(i => i.Contains('a'))
                    .Select(i => $"{i}: {i.Count(c => c == 'a')}")
                    .ToList()));
            Console.WriteLine(new string('~', Console.BufferWidth) + "\n");


            Console.WriteLine("Task 6: output true if word \"abb\" exists in line  \"aaa;xabbx;abb;ccc;dap\", otherwise false");
            string task6Input = "aaa;xabbx;abb;ccc;dap";
            string task6Search = "abb";
            Console.WriteLine("Result: " +
                task6Input.Split(';')
                .Where(i => i.Count() == task6Search.Count())
                .Contains(task6Search));
            Console.WriteLine(new string('~', Console.BufferWidth) + "\n");


            Console.WriteLine("Task 7: get the longest word in string \"aaa;xabbx;abb;ccc;dap\"");
            string task7Input = "aaa;xabbx;abb;ccc;dap";
            Console.WriteLine("Result: " +
            string.Join(", ", task7Input
                .Split(';')
                .Where(
                    word =>
                    word.Count() == task7Input
                    .Split(';')
                    .Max(w => w.Count()))
                .ToList()
                ));
            Console.WriteLine(new string('~', Console.BufferWidth) + "\n");


            Console.WriteLine("Task 8: calculate average length of word in string \"aaa;xabbx;abb;ccc;dap\"");
            string task8Input = "aaa;xabbx;abb;ccc;dap";
            Console.WriteLine("Result: " + task8Input.Split(';').Average(i => i.Count()));
            Console.WriteLine(new string('~', Console.BufferWidth) + "\n");


            Console.WriteLine("Task 9: print the shortest word reversed in string \"aaa;xabbx;abb;ccc;dap;zh\"");
            string task9Input = "aaa;xabbx;abb;ccc;dap;zh;ab";
            Console.WriteLine("Result: " +
                string.Join(", ",
                task9Input.Split(';')
                .Where(
                    word => word.Count() == task9Input.Split(';')
                        .Min(i => i.Length))
                .Select(word => string.Concat(word.Reverse()))
                .ToList())
                );
            Console.WriteLine(new string('~', Console.BufferWidth) + "\n");


            Console.WriteLine("Task 10: print true if in the first word that starts " +
                "from \"aa\" all letters are 'a' otherwise false \"baaa; aabb; xabbx; abb; ccc; dap; zh\"");
            string task10Input = "baaa;aabb;aaaaaa;xabbx;abb;ccc;dap;zh";
            string task10Search = "aa";
            Console.WriteLine("Result: " +
                task10Input.Split(';')
                .First(i => i.StartsWith(task10Search))
                .Any(i => i != 'a')
                );
            Console.WriteLine(new string('~', Console.BufferWidth) + "\n");
        }
    }
}
