using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();

            StoreData(Emp);

            ShowData(Emp);

            Console.ReadLine();
        }


        // Taking input details from user 
        static void StoreData(Employee Emp)
        {
            Console.WriteLine("Enter employee id : ");
            Emp.Id = CustomConsole.ReadInt();

            Console.WriteLine("Enter Employee name : ");
            Emp.Name = CustomConsole.ReadString();

            Console.WriteLine("Enter gender : ");
            Emp.Gender = CustomConsole.ReadString();

            Console.WriteLine("Enter address 1 : ");
            Emp.Addr.Address1 =  CustomConsole.ReadString(); 
            
            Console.WriteLine("Enter address 2 : ");
            Emp.Addr.Address2 =  CustomConsole.ReadString();

            Console.WriteLine("Enter City name : ");
            Emp.Addr.City =  CustomConsole.ReadString();

            Console.WriteLine("Enter Pincode : ");
            Emp.Addr.Pincode =  CustomConsole.ReadInt();
        }

        static void ShowData(Employee Emp)
        {
            //----------------Display the employee information
            Console.WriteLine("Employee Id : " + Emp.Id);
            Console.WriteLine("Employee Name : " + Emp.Name);
            Console.WriteLine("Employee Gender : " + Emp.Gender);

            Console.WriteLine("Employee Address : --------------");
            Console.WriteLine("Address 1 : " + Emp.Addr.Address1);
            Console.WriteLine("Address 2 : " + Emp.Addr.Address2);
            Console.WriteLine("City : " + Emp.Addr.City);
            Console.WriteLine("PinCode : " + Emp.Addr.Pincode);
            Console.WriteLine("----------------------------------");

        }
    }
}
