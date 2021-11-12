using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPerson person1 = new ClsPerson();
            person1.Name = "John";
            person1.Age = 16;
            person1.PlaceOfBirth = "Chennai";

            ClsPerson person2 = new ClsPerson();
            person2.Name = "Smita";
            person2.Age = 22;
            person2.PlaceOfBirth = "Delhi";

            ClsPerson person3 = new ClsPerson();
            person3.Name = "Vincet";
            person3.Age = 25;
            person3.PlaceOfBirth = "Bangalore";

            ClsPerson person4 = new ClsPerson();
            person4.Name = "Jyothi";
            person4.Age = 10;
            person4.PlaceOfBirth = "Bangalore";

            Hashtable people = new Hashtable();

           // Dictionary<string, ClsPerson> people = new Dictionary<string, ClsPerson>();
            people.Add(person1.Name, person1.CanVote());
            people.Add(person2.Name, person2.CanVote());
            people.Add(person3.Name, person3.CanVote());
            people.Add(person4.Name, person4.CanVote());

            ClsPerson person5 = new ClsPerson();
            person5.Name = "Jyothi";
            person5.Age = 10;

            ClsPerson person6 = new ClsPerson();          
            person6.Age = 10;

            //people.Add(person5.Name, person5.CanVote());
            people.Add(person6.Name, person6.CanVote());

            Console.WriteLine("Name\tEligible to Vote");
            Console.WriteLine("******************************************");

            foreach (DictionaryEntry item in people)
            {
                Console.Write(item.Key +  "\t");
                if ((bool)item.Value)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
                Console.WriteLine();
            }

            //foreach (var item in people)
            //{
            //    Console.Write(item.Key + "\t" + item.Value.Age + "\t");
            //    if(item.Value.CanVote())
            //        Console.WriteLine("Yes");
            //    else
            //        Console.WriteLine("No");
            //}


            Console.Read();
        }
    }
}
