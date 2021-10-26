using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
   
    public class Employee 
    {
        // Properties in Employee class
       public int Id { get; set; }
       public string Name { get; set; }
       public string Gender { get; set; }  
        
        // Creating object of Address class
        Address addr = new Address();

        public Address Addr
        {
            get
            {
                return addr;
            }
            set
            {
                addr = value;
            }
        }
    }
}
