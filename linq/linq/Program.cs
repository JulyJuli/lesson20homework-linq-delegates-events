using System;
using System.Linq;

namespace linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var arrayNumbers = Enumerable.Range(10, 41).ToArray();
            Console.WriteLine($"1) {string.Join(',', arrayNumbers)}");
            Console.WriteLine($"2) {string.Join(',', arrayNumbers.Where(num => num % 3 == 0))}");
            Console.WriteLine($"3) {string.Join(' ', Enumerable.Range(0, 10).Select(num => "Link"))}");

            var words = "aaa;abb;ccc;dap";
            Console.WriteLine($"4) {string.Join(' ',words.Split(';').Where(word => word.Contains('a')))}");
            Console.WriteLine($"5) {string.Join(',',words.Split(';').Where(word => word.Contains('a')).Select(word => word.ToCharArray().Count(ch => ch.Equals('a'))))}");

            words = "aaa;xabbx;abb;ccc;dap";
            Console.WriteLine($"6) {words.Contains("abb")}");
            Console.WriteLine($"7) {words.Split(';').OrderBy( s => s.Length ).Last()}");
            Console.WriteLine($"8) {words.Split(';').Select(word => word.Length).Average()}");

            words = "aaa;xabbx;abb;ccc;dap;zh";
            Console.WriteLine($"9) {string.Join("",words.Split(';').OrderBy( s => s.Length ).FirstOrDefault().ToCharArray().Reverse())}");

            words = "baaa;aabb;xabbx;abb;ccc;dap;zh";
            Console.WriteLine($"10) {words.Split(';').FirstOrDefault(word => word.StartsWith("aa")).ToCharArray().GroupBy(group => group.Equals('a')).Count() == 1}");
        }
    }
}
