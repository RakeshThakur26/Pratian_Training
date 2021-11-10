using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // accept two integers and find the sum many times

            int fno;
            int sno;
            int sum;

            while(true)
            {
                try
                {
                    Console.Write("Enter First Number: ");
                    fno = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second Number: ");
                    sno = int.Parse(Console.ReadLine());
                    sum = fno + sno;
                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                } 
               
                catch(FormatException ex)
                {
                    Console.WriteLine("Please enter only interger number");
                    
                } 
                catch(Exception ex) // Catch All 
                {
                    Console.WriteLine(ex.Message);
                }
                //catch(OverflowException)
                //{
                //    Console.WriteLine("Kindly enter small numbers");
                //}
                finally 
                {
                    // resource management
                }
               
            }



        }
    }
}
