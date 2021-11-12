using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            bool acceptFlag = false;
           // int ch=1;
            while(!acceptFlag)
            {
                Console.WriteLine("Enter integer value : ");
                int n = Convert.ToInt32(Console.ReadLine());
                list.Add(n);
                Console.WriteLine("Do you want to continue? If yes press y else n");
                //ch = Convert.ToInt32(Console.ReadLine()); 
                string choice = Console.ReadLine();
                if (choice == "y")
                    acceptFlag = false;
                else
                    acceptFlag = true;
            }

            // Displaying total number of elements in the list
            Console.WriteLine("Total number of elements in the List : " + list.Count);
            int avg = Convert.ToInt32(list.Average());
           
            // Inserting element into the middle of the list
            if (list.Count % 2 == 1)
                list.Insert((list.Count/2)+1, avg);
            else
                list.Insert((list.Count/2), avg);

            // Displaying th list elements
            Console.Write("Elements are : ");
            foreach (var item in list)           
                Console.Write(item + "  ");

            // Removing element present at 2nd position
            list.RemoveAt(1);

            // Removing Average value inserted element
            list.Remove(avg);

            // Displaying th list elements
            Console.Write("\nElements After Removing : ");
            foreach (var item in list)
                Console.Write(item + "  ");


            Console.Read();
        }
    }
}
