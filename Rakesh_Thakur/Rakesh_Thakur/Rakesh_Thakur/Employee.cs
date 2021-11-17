using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakesh_Thakur
{
    class Employee : Person
    {
        private long empId;
        private float basic;
        private int experiance;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
         public string Name
        {
            get { return name; }
            set { name = value; }
        }
         public string Address
        {
            get { return address; }
            set { address = value; }
        }



        public long EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
         public int Experiance
        {
            get { return experiance; }
            set { experiance = value; }
        }

        public float Basic
        {
            get { return basic; }
            set { basic = value; }
        }

        public float getSalary()
        {
            return (this.basic + SalaryCalculator.calculateAllowance(this.Experiance, this.Basic));
        }

    }
}
