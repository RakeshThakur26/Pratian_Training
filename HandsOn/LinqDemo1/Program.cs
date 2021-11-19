using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            var LinqEven = from n in numbers
                           where n % 2 == 0
                           orderby n descending
                           select n;

            var LingOdd = numbers.Where(n => n % 2 == 1).OrderByDescending(n=>n);
            numbers.Add(10);

            foreach (var item in LinqEven)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
