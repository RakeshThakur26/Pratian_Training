using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 100;
            int Number2 = 200;

            // Displaying Numbers before swap
            DisplayValues("Before Swapping...", Number1, Number2);

            // Calling function to operate swap logic
            SwapValues(ref Number1, ref Number2);

            // Displaying Numbers after swap
            DisplayValues("After Swapping...", Number1, Number2);

            Console.ReadLine();
        }

    
        private static void SwapValues(ref int Number1, ref int Number2)
        {
            // Bitwise operator to swap 2 numbers
            Number1 = Number1 ^ Number2;
            Number2 = Number1 ^ Number2; 
            Number1 = Number1 ^ Number2;
        }

 
        private static void DisplayValues(string Str, int Number1, int Number2) 
        {
		    Console.WriteLine(Str);
		    Console.WriteLine("Number 1 = " + Number1);
            Console.WriteLine("Number 2 = " + Number2);
	    }
    }
}
