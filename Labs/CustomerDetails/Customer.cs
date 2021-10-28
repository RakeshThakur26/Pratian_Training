﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDetails
{
    public class Customer
    {
        public string CustId { get; set; }
        public string Name { get; set; }
        public Address address { get; set; } = new Address();

        public Customer (string custId, string name, Address addr)
        {
            this.CustId = custId;
            this.Name = name;
            this.address = addr;
        }
    }
}
