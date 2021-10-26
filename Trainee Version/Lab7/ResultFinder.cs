using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class ResultFinder
    {
     
        public int Marks1 { get; set; }
	    public int Marks2 { get; set; }
	    public int Marks3 { get; set; }
        
        // Displaying  Marks details
        public void DisplayMarks()
        {
	        Console.WriteLine("Marks 1 : " + Marks1);
            Console.WriteLine("Marks 2 : " + Marks2);
            Console.WriteLine("Marks 3 : " + Marks3);
           
        }

        // Returnning total marks
        public int GetTotal()
        {
            return (Marks1 + Marks2 + Marks3);
        }

        // Returning average marks
        public double GetAverage()
        {
            return (GetTotal() / 3);
        }

        // Checking each subject
        public bool hasPassed(int m1, int m2, int m3)
        {
            if(m1 >= 35 && m2 >= 35 && m3 >= 35)
                return true;

            return false;
        }

        // Returning Result
        public string GetResult()
        {
            int average = Convert.ToInt32( GetAverage());
            if(average >= 70 && hasPassed(Marks1, Marks2, Marks3))
                return "Distinction";
            else if(average >= 60 && average < 70 && hasPassed(Marks1, Marks2, Marks3))
                return "First class";
            else if(average >= 50 && average < 60 && hasPassed(Marks1, Marks2, Marks3))
                return "Second class";
            else if(average >= 35 && hasPassed(Marks1, Marks2, Marks3))
                return "Pass class";
            else 
                return "Fail";
        }
    }
}
