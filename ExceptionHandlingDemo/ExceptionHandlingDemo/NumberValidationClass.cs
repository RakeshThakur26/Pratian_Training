using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class NumberValidationClass
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <exception cref="InvalidMobileNumberException"></exception>
        public static void Validate(string number)
        {
            if (number.Length != 10)
                throw new InvalidMobileNumberException("Number length should be 10..");

            else if (number[0] != '9')
                throw new InvalidMobileNumberException("Mobile number should start with 9..");
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] > '9' || number[i] < '0')
                    {
                        throw new InvalidMobileNumberException("Enter only digits");
                    }
                }
            }
           

        }
    }
}
