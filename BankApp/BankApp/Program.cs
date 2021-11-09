using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "";
            string sub_type = "";

            Console.WriteLine("Please select account type");
            Console.WriteLine("1. Corporate account\n2. Personal account");
            int choice1 = Convert.ToInt32(Console.ReadLine());

            if (choice1 == 1)
                type = "Corporate";
            else if(choice1 == 2)
                type = "Personal";


            Console.WriteLine("Please select Sub type");
            Console.WriteLine("\n1. Savings account\n2. Current account\n3. Over Draft account");
            int choice2 = Convert.ToInt32(Console.ReadLine());

            Bank bank = new Bank();
            Customer customer1 = new Customer();

            if (choice2 == 1)
            {
                Savings account = new Savings(type);
                
            }
                
            else if (choice2 == 2)
            {
                Account account = new Current(type);
            }
               
            else if(choice2 == 3)
            {
                Account account = new OverDraft(type);
            }
               
                  



            Console.ReadLine();
        }
    }
}
