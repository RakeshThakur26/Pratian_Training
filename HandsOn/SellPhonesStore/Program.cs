﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellPhonesStore.DataAccess;
using SellPhonesStore.Entities;

namespace SellPhonesStore
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int ch;
            while (true)
            {
                Console.WriteLine("1. Save Phone details\n2. Save Customer Details\n3. Save Orders\n4. Save Ordered phone");
                Console.WriteLine("5. Get Customer orders\n6. Get all Customer orders");

                Console.Write("Enter your choice : ");
                ch = Convert.ToInt32(Console.ReadLine());
                IPhoneRepository repo = new PhoneRepository();
                Phone phone = new Phone();
                Customer customer = new Customer();
                CustomerOrder order = new CustomerOrder(); 

                switch (ch)
                {
                    case 1: Console.WriteLine("Enter phone details..");
                        Console.Write("Enter phone description : ");
                        phone.PhoneDescription = Console.ReadLine();

                        Console.Write("Enter phone price : ");
                        phone.Price = (float)Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Stocks : ");
                        phone.InStock = Convert.ToInt32(Console.ReadLine());

                        phone.ManufacturingDate = DateTime.Today;
                        Console.WriteLine($"{repo.SavePhone(phone)} Saved successfully..");
                        break;

                    case 2: Console.WriteLine("Enter Customer details..");
                        Console.Write("Enter name : ");
                        customer.CustomerName = Console.ReadLine();
                        Console.Write("Enter email : ");
                        customer.EmailId = Console.ReadLine();
                        Console.Write("Enter City : ");
                        customer.City = Console.ReadLine();

                        Console.WriteLine($"{repo.SaveCustomer(customer)} is added Successfully..");
                        break;
                        
                    case 3: Console.WriteLine("Enter Order details..");
                        Console.Write("Enter customer id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        customer = repo.GetCustomerById(id);
                        order.customer = customer;
                        order.OrderDate = DateTime.Today;
                        Console.Write("Enter order total : ");
                        order.OrderTotal = (float)Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"{repo.SaveOrder(order)} is added Successfully..");
                        break;
  
                    case 4:
                        OrderedPhone op = new OrderedPhone();
                        Console.Write("Enter Phone id : ");
                        long pid = Convert.ToInt64(Console.ReadLine());
                        op.OrdPhone = repo.GetPhoneById(pid);
                        op.Quantity = 10;
                        Console.WriteLine($"{repo.SaveOrderedPhone(op, 1)} is added Successfully..");
                        break;

                    case 5:
                        Console.Write("Enter customer Id : ");
                        long custId = Convert.ToInt64(Console.ReadLine());

                        var custord = repo.GetCustomerOrders(custId);
                        foreach (var o in custord)
                        {
                            Console.WriteLine(o.customer.CustomerName +"\t" + o.OrderId );
                        }
                        break;
                   case 6:
                        var orders = repo.GetAllCustomerOrders();
                        foreach (var o in orders)
                        {
                            Console.WriteLine(o.OrderId + "\t" + o.customer.CustomerName);
                        }
                        break;


                }


            }


            

            Console.Read();
        }
    }
}
