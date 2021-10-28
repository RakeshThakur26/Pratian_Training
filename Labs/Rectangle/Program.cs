using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length : ");
            double length = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Enter Breadth : ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, breadth);
            Console.WriteLine("Area of Rectangle = " + rectangle.Area());

            Console.ReadLine();
        }
    }
}
