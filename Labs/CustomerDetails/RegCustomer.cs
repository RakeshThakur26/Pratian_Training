using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDetails
{
    class RegCustomer : Customer
    {
        public double fees;
        public RegCustomer(string custId, string name, Address addr, double fees) : base(custId, name, addr)
        {
            this.fees = fees;
            this.CustId = custId;
            this.Name = name;
            this.address = addr;
        }

        public void Display()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("\nCustomer Id : " + this.CustId);
            Console.WriteLine("Customer Name : " + this.Name);
            Console.WriteLine("Customer Address 1 : " + this.address.address1 + "\nCustomer Address 2 : " + this.address.address2 + "\nCustomer city : " + this.address.City + ", Pincode : " + this.address.Pincode );
            Console.WriteLine("Fees : " + this.fees);
            Console.WriteLine("********************************");

        }
    }
}
