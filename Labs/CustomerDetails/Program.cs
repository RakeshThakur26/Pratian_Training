using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Customer name ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter Customer Id ");
            string id = Console.ReadLine();
           
            Console.WriteLine("Enter Customer address 1 ");
            string addr1 = Console.ReadLine();
           
            Console.WriteLine("Enter Customer address 2 ");
            string addr2 = Console.ReadLine();
           
            Console.WriteLine("Enter Customer City ");
            string city = Console.ReadLine();
            
            Console.WriteLine("Enter Pincode ");
            int pincode = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter fees ");
            double fees = Convert.ToDouble(Console.ReadLine());
            Address address = new Address();
            address.address1 = addr1;
            address.address2 = addr2;
            address.City = city;
            address.Pincode = pincode;

            RegCustomer customer1 = new RegCustomer(id, name, address, fees);


            customer1.Display();

            Console.Read();

        }
    }
}
