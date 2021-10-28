using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    class RegCustomer : Customer
    {
        public double splDiscount { get; set; }

        public RegCustomer(double discount)
        {
            this.splDiscount = discount;
        }

        public double getsplDiscount()
        {
            return splDiscount;
        }
    }
}
