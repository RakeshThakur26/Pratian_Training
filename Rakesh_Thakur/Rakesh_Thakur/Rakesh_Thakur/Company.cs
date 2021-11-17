using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakesh_Thakur
{
    class Company
    {
        private string name;
        private DateTime incorporationDate;

        public List<Customer> customers { get; set; } = new List<Customer>();
        public List<Employee> employees { get; set; } = new List<Employee>();
        public List<Branch> branches { get; set; } = new List<Branch>();
 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
         public DateTime IncorporationDate
        {
            get { return incorporationDate; }
            set { incorporationDate = value; }
        }

        public int getTotalCustomers()
        {
            return customers.Count;
        }
        public Employee getEmployeeByEmployeeId(long id)
        {
         
            foreach (var item in employees)
            {
                if (item.EmpId == id)               
                    return item;
            }       

            throw new EmployeeDoesnotExistException("Employee does not exists");            

        }
        public List<Employee> getExperiancedEmployees(int yearOfExperiance)
        {
            List<Employee> expemployees = new List<Employee>();
            foreach (var item in employees)
            {
                if (item.Experiance > yearOfExperiance)
                    expemployees.Add(item);
            }
            return expemployees;
        }

         public float getTotalSalaryPayout()
        {
            float total = 0;
            foreach (var item in employees)
            {
                total += item.getSalary();
            }
            return total;            
        }

        public Dictionary<int, Employee> getEmployeesGroupedByAge()
        {
            Dictionary<int, Employee> groupedEmp = new Dictionary<int, Employee>();
            foreach (var item in employees)
            {
                groupedEmp.Add(item.Age, item);
            }

            return groupedEmp;
        }

    }
}
