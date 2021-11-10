
// BL   
using System;
using System.Net.Mail;

namespace StudentResultCalculatorLibrary
{
    public class ResultCalculator
    {
        private readonly INotification notification;

        public ResultCalculator(INotification notification)
        {
            this.notification = notification;
        }

        /// <summary>
        /// Calculates Student result - throws exp when s1,s2,s3 is lessthan zero or more than 100
        /// </summary>
        /// <param name="s1">Subject 1 Marks</param>
        /// <param name="s2">Subject 2 Marks</param>
        /// <param name="s3">Subject 3 Marks</param>
        /// <returns>returns result [pass/fail/first]</returns>
        /// <exception cref="InvalidMarksException"></exception>
        public  string CalculateResult(int s1, int s2, int s3)
        {
            // throws exp when s1 is lessthan zero or more than 100
            if (s1 < 0 || s1 > 100 || s2 < 0 || s2 > 100 | s3 < 0 || s3 > 100)
                throw new InvalidMarksException("Marks should be within 0 and 100 only");
            
            string result;
            double avg = (s1 + s2 + s3) / 3;
            if (avg >= 65)
                result = "First Class";
            else if (avg >= 59)
                result = "Second Class";
            else if (avg >= 35)
                result = "Pass";
            else
                result = "Fail";

            // Mail the result to student
            //INotification notification = new Notification();
            notification.Notify("Your result is " + result, "student1@mail.com");


            return result;
        }
    }
}

