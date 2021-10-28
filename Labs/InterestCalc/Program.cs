using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principle amount");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time ");
            int time = Convert.ToInt32(Console.ReadLine());
            InterestCalculator interest = new InterestCalculator(principle, time);

            Console.WriteLine("Interest = " + interest.GetInterest());
            Console.ReadLine();
        }
    }
}
