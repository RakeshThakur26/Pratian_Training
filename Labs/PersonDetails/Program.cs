using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details of person 1 ");
            Person person1 = new Person();
            Console.WriteLine("Enter name : ");
            person1.Name = Console.ReadLine();
            Console.WriteLine("Enter age :");
            person1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sex : ");
            person1.Sex = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter details of person 2 ");
            Person person2 = new Person();
            Console.WriteLine("Enter name : ");
            person2.Name = Console.ReadLine();
            Console.WriteLine("Enter age :");
            person2.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sex : ");
            person2.Sex = Convert.ToChar(Console.ReadLine());

            if(Program.equals(person1, person2))
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");

            Console.ReadLine();
        }

        static bool equals(Person p1, Person p2)
        {
            if ((p1.Name.Equals(p2.Name)) && (p2.Age.Equals(p1.Age)) && (p1.Sex == p2.Sex))
                return true;
            return false;
        }
    }
}
