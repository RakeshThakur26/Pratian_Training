using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProductManagement.Entities
{
    public class Suppliers
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public virtual Address Address { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
    [ComplexType]
    public class Address
    {
        public string Area { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string Country { get; set; }
    }
}
