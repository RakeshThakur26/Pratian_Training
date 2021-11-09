using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();
            Console.WriteLine("Enter Current speed");
            vehicle1.CurrentSpeed = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Max speed");
            vehicle1.MaximumSpeed = Convert.ToInt32(Console.ReadLine());

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    vehicle1.IncreaseSpeed();
                }
            }
            catch (SpeedMorethanMaximumSpeedException ex)
            {
                Console.WriteLine(ex.Message);
            }

           

            Console.Read();
        }
    }
}
