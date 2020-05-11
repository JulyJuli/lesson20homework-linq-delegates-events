using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.Print all numbers from 10 to 50 separated by commas

            int[] mas = Enumerable.Range(10, 41).ToArray();
            Console.WriteLine(string.Join(",", mas));
            Console.WriteLine("____________________");

            //2.Print only that numbers from 10 to 50 that can be divided by 3

            for (int i = 10; i < mas.Count(); i++)
            {
                if (mas[i] % 3 == 0)
                {
                    Console.WriteLine("{0} ", mas[i]);
                }
            }
            Console.WriteLine("____________________");

            //3.Output word "Linq" 10 times

            IEnumerable<string> strings = Enumerable.Repeat("Linq", 10);

            foreach (String str in strings)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("____________________");

            //4.Output all words with letter 'a' in string "aaa;abb;ccc;dap"

            string[] z = "aaa;abb;ccc;dap".Split(';');
            foreach (string r in z.Where(k => k.Contains("a")))
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("____________________");

            //5.Output number of letters 'a' in the words with this letter in string "aaa;abb;ccc;dap" separated by comma

            string[] n = "aaa;abb;ccc;dap".Split(';');

            foreach (string r in n.Where(w => w.Contains("a")))
            {
                Console.WriteLine(r.Count());
            }
            Console.WriteLine("____________________");//?? считает общее количество символов в словах с буквой "А". Доработаю

            //6.Output true if word "abb" exists in line  "aaa;xabbx;abb;ccc;dap", otherwise false

            string[] srt1 = "aaa;xabbx;abb;ccc;dap".Split(';');
            if (srt1.Contains("abb"))
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
            Console.WriteLine("____________________");

            //7.Get the longest word in string "quot;aaa;xabbx;abb;ccc;dap";

            string[] srt4 = "quot;aaa;xabbx;abb;ccc;dap".Split(';');
            string maxLengthWord = srt4.Where(x => x.Length == srt4.Select(y => y.Length).Max()).First();
            Console.WriteLine(maxLengthWord);
            Console.WriteLine("____________________");

            //8.Calculate average length of word in string "aaa;xabbx;abb;ccc;dap"

            string[] srtg = "quot;aaa;xabbx;abb;ccc;dap".Split(';');

            double average = srtg.Average(word => word.Length);

            Console.WriteLine("The average grade is {0}.", average);
            Console.WriteLine("____________________");

            //9.Print the shortest word reversed in string "aaa; xabbx; abb; ccc; dap; zh"

            string[] srt3 = "aaa;xabbx;abb;ccc;dap;zh".Split(';');
            string minLengthWord = srt3.Where(x => x.Length == srt3.Select(y => y.Length).Min()).First();
            Console.WriteLine(minLengthWord);
            Console.WriteLine("____________________");

            //10.Print true if in the first word that starts from "aa" all letters are 'a' otherwise false "baaa;aabb;xabbx;abb;ccc;dap;zh"

            string[] srt5 = "baaa;aabb;xabbx;abb;ccc;dap;zh".Split(';');
            //?? не сделал


            Console.ReadKey();
        }
    }
}

