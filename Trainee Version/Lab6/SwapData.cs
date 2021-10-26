using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    class SwapData
    {
     
        public int Number1 { get; set; }
        public int Number2 { get; set; }

      
        public void SwapValues()
        {
            // Swapping 2 numbers using bitwise operator

            Number1 = Number1 ^ Number2; 
            Number2 = Number1 ^ Number2;
            Number1 = Number1 ^ Number2;
        }

    
        public void DisplayValues(string Str)
        {
            Console.WriteLine(Str);
            Console.WriteLine("Number 1 = " + Number1);
            Console.WriteLine("Number 2 = " + Number2);
        }
    }
}
