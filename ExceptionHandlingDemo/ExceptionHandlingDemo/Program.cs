using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Employee mobile number : ");
                string mobile = Console.ReadLine();
                NumberValidationClass.Validate(mobile);

                Console.WriteLine("Number is valid");

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null pointer Exception...");
            }
            catch(InvalidMobileNumberException exc)
            {
                Console.WriteLine(exc.Message);
            }





            Console.Read();
        }
    }
}
