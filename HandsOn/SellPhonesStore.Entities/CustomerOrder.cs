using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class CustomerOrder
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer customer { get; set; }
        public float OrderTotal { get; set; }
        public List<OrderedPhone> orderedPhones { get; set; } = new List<OrderedPhone>();

    }
}
