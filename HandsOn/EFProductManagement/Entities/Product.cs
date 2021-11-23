using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProductManagement.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }

        [Column(TypeName ="ntext")]
        public string Description { get; set; }
        public string Brand { get; set; }
        public Catagory catagory { get; set; } 
        public virtual List<Suppliers> Suppliers { get; set; }
    }
}
