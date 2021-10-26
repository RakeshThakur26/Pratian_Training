using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int Marks1 = CustomConsole.ReadInt();
            int Marks2 = CustomConsole.ReadInt();
            int Marks3 = CustomConsole.ReadInt();

            ResultFinder Finder = new ResultFinder();
            Finder.Marks1 = Marks1;
            Finder.Marks2 = Marks2;
            Finder.Marks3 = Marks3;

          
            Console.WriteLine("Marks entered------------- ");
           
            // Calling DisplayMarks function of ResultFinder class
            Finder.DisplayMarks();

            // Displaying the Total, Average and result 
             Console.WriteLine("Total : " +  Finder.GetTotal());
            Console.WriteLine("Average : " + Finder.GetAverage());
            Console.WriteLine("Result : " + Finder.GetResult());
            Console.ReadLine();
        }
    }
}
