using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClsPerson> people = new List<ClsPerson>();

            ClsPerson person1 = new ClsPerson();
            Console.WriteLine("Enter person 1 Name :");
            person1.Name = Console.ReadLine();

            ClsPerson person2 = new ClsPerson();
            Console.WriteLine("Enter person 2 Name :");
            person2.Name = Console.ReadLine();

            ClsPerson person3 = new ClsPerson();
            Console.WriteLine("Enter person 3 Name :");
            person3.Name = Console.ReadLine();

            ClsPerson person4 = new ClsPerson();
            Console.WriteLine("Enter person 4 Name :");
            person4.Name = Console.ReadLine();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            Console.WriteLine("\nList of names");

            foreach (var item in people)
                Console.WriteLine(item.Name);

            Console.Read();
        }
    }
}
