using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of 2 intergers ");
            Console.WriteLine("Enter 2 integers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of 2 integers = " + Program.add(num1, num2));

            Console.WriteLine("\nAddition of 2 doubles ");
            Console.WriteLine("Enter 2 double numbers : ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum of 2 doubles = " + Program.add(n1, n2));


            Console.WriteLine("\nConcatination  of 2 strings ");
            Console.WriteLine("Enter 2 strings : ");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine("Sum of 2  = " + Program.add(str1, str2));

            Console.ReadLine();
        }

        static int add(int a, int b)
        {
            return a + b;
        }
        static string add(string a, string b)
        {
            return a + b;
        }
        static double add(double a, double b)
        {
            return a + b;
        }

        static dynamic add(dynamic a, dynamic b)
        {
            return a + b;
        }

    }
}
