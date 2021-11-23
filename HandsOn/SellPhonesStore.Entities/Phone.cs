using System;
using System.ComponentModel.DataAnnotations;

namespace SellPhonesStore.Entities
{
    public class Phone
    {
        [Key]
        public long PhoneId { get; set; }
        [Required] [StringLength(500)]
        public string PhoneDescription { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 1")]
        public float Price { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string BrandName { get; set; }
        public int InStock { get; set; }
    }
}
