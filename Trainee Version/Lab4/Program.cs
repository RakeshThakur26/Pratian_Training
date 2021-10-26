using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Taking inputs from user
            Console.WriteLine("Enter Capacity : ");
            int  Cap = CustomConsole.ReadInt();
            
            Console.WriteLine("MAX_CAPACITY is " + Cache.GetMaxCapacity());	   

            // calling SetMaxCapacity function to set value taken from user
            Cache.SetMaxCapacity(Cap);

		    Console.WriteLine("MAX_CAPACITY is " + Cache.GetMaxCapacity());

		    
            Console.WriteLine("MAX_CAPACITY is " + Cache.GetMaxCapacity());

            Console.ReadLine();
        }
    }
}
