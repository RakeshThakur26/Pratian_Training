using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Address
    {

        // Properties in Adress class
        string address1;
        string address2;
        string city;
        int pincode;

        public string Address1 {
            get 
            { 
                return address1;
            }
            set
            {
                address1 = value;
            }
        } 
        public string Address2 {
            get 
            { 
                return address2;
            }
            set
            {
                address2 = value;
            }
        }
        public string City {
            get 
            { 
                return city;
            }
            set
            {
                city = value;
            }
        }
         public int Pincode {
            get 
            { 
                return pincode;
            }
            set
            {
                pincode = value;
            }
        }


    }
}
