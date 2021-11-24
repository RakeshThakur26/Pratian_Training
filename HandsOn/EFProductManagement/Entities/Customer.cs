using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFProductManagement.Entities
{
   // [Table("Customers")] // Table per type
    public class Customer : Person
    {
        public string Type { get; set; }
        public double Discount { get; set; }
        public virtual Address Address { get; set; }

    }
}
