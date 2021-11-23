using System;
using System.ComponentModel.DataAnnotations;

namespace SellPhonesStore.Entities
{
    public class OrderedPhone
    {
        [Key]
        public long OrderPhoneId { get; set; }
        public Phone OrdPhone { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 1")]
        public float Quantity { get; set; }
    }
}
