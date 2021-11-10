using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentResultCalculatorClassLibrary;


namespace StudentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Student Result Application");
            Console.WriteLine("-----------------------------------------");
            int s1, s2, s3;
            string name, result;

            while (true)
            {
                Console.Write("Enter student name : ");
                name = Console.ReadLine();
                Console.Write("\nEnter subject 1 marks : ");
                s1 = Convert.ToInt32(Console.ReadLine()); 
                Console.Write("\nEnter subject 2 marks : ");
                s2 = Convert.ToInt32(Console.ReadLine()); 
                Console.Write("\nEnter subject 3 marks : ");
                s3 = Convert.ToInt32(Console.ReadLine());

                StudentResultCalculator notif = new StudentResultCalculator(new EmailNotification());
               result = notif.StudentCalculator(s1,s2,s3);

                Console.WriteLine($"\nThe result of {name} for {s1}, {s2}, {s3} is {result}");
            }
            
        }
    }
}
