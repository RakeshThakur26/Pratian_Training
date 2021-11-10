using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultCalculatorLibrary
{
    public class StudentCalculatorClass
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        /// <exception cref="InvalidMarksException"></exception>
        public static string StudentCalculator(int s1, int s2, int s3)
        {        

            if (s1 < 0 || s1 > 100 || s2 < 0 || s2 > 100 || s3 < 0 || s3 > 100)
                throw new InvalidMarksException("Enter marks between 0 and 100 only");

           string result;
           double avg = (s1 + s2 + s3) / 3;
            if (avg >= 65)
                result = "First";
            else if (avg >= 59)
                result = "Second";
            else if (avg >= 35)
                result = "Pass";
            else
                result = "Fail";

            return result;
        }


        
    }
}
