using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakesh_Thakur
{
    class Customer : Person
    {
        private long customerId;
        private string emailId;
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



        public long CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }
    }
}
