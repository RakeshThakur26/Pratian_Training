using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandlingDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = File.OpenText("C://Pratian_Training//abc.txt");
                int inp1, inp2, output;

                inp1 = int.Parse(sr.ReadLine());
                inp2 = int.Parse(sr.ReadLine());

                output = inp1 / inp2;
                sr.Close();
                Console.WriteLine(output);

            }

            catch (OverflowException ex)
            {
                Console.WriteLine("The value is too large");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Number is cannot divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid values in file ");
            }

            Console.ReadLine();
        }
    }
}
