using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class Customer
    {

        [Key]
        public long CustomerId { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public string Pincode { get; set; }
        public long MobileNo { get; set; }
        public List<CustomerOrder> orders { get; set; }
    }
}
