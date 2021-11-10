using StudentResultCalculatorLibrary;
using System;
class Program
{
    // UI Logic
    static void Main() // SRP
        {

        // accept student name, 3 subject marks and display the result
        // >= 60 First class
        // 59-45 Second Class
        // 35-44 Pass
        // <35 Fail

        // input output  - read and write
        // variable declarations
        // conditional statement
        // mathematical calculations

        Console.WriteLine("Welcome to Student Result Application");
        Console.WriteLine("-----------------------------------------");

        string name,result;
        int s1, s2, s3;
        
        while (true)
        {
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Subject 1 Marks :");
            s1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject 2 Marks :");
            s2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject 3 Marks :");
            s3 = int.Parse(Console.ReadLine());
            ResultCalculator calculator = new ResultCalculator(new EmailNotification());
            result = calculator.CalculateResult(s1, s2, s3);

            Console.WriteLine($"The result of {name} for {s1}, {s2}, {s3} is {result}");

        }


       

        
    }
    
    
}

