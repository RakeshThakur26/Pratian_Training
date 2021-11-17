using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakesh_Thakur
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Console.WriteLine("Enter Company Name");
            company.Name = Console.ReadLine();
            company.IncorporationDate = DateTime.Today;
            Console.WriteLine("*********************************");
           
            Console.WriteLine("Enter Employee details");

            Employee employee1 = new Employee();
            Console.WriteLine("Enter employee name ");
            employee1.Name = Console.ReadLine();

             Console.WriteLine("Enter employee age ");
            employee1.Age = Convert.ToInt32( Console.ReadLine());

             Console.WriteLine("Enter employee Address ");
            employee1.Address = Console.ReadLine();

            Console.WriteLine("Enter employee Id ");
            employee1.EmpId = Convert.ToInt64( Console.ReadLine());

            Console.WriteLine("Enter employee Basic ");
            employee1.Basic = float.Parse( Console.ReadLine());

             Console.WriteLine("Enter employee Experiance ");
            employee1.Experiance = int.Parse(Console.ReadLine());

            company.employees.Add(employee1);

            Console.WriteLine("*********************************");

            Console.WriteLine("Enter Customer details");
            Customer customer1 = new Customer();

            Console.WriteLine("Enter customer name");
            customer1.Name = Console.ReadLine();

            Console.WriteLine("Enter Customer age ");
            customer1.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Address ");
            customer1.Address = Console.ReadLine();

            Console.WriteLine("Enter Customer Id ");
            customer1.CustomerId = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Email Id ");
            customer1.EmailId = Console.ReadLine();

            Console.WriteLine("*********************************");


            company.customers.Add(customer1);

            Console.WriteLine("Total number of customers = " + company.getTotalCustomers()) ;
            Console.WriteLine();
            Console.WriteLine("Total salary payout = " + company.getTotalSalaryPayout()) ;
            Console.WriteLine();
            try
            {
                Console.WriteLine("Get Employee by id = " + company.getEmployeeByEmployeeId(123).Name);
            }
            catch (EmployeeDoesnotExistException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("*********************************\n");

            List<Employee> experiancedEmp = company.getExperiancedEmployees(2);
            foreach (var item in experiancedEmp)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("*********************************\n");

            Dictionary<int, Employee> groupedEmplyoees = company.getEmployeesGroupedByAge();
            foreach (var item in groupedEmplyoees)
            {
                Console.WriteLine("Age = " +item.Key +", Employee name = " + item.Value.Name );
            }

            Console.ReadLine();
        }
    }
}
