using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProductManagement.Entities
{
    public abstract class Person
    {
       // [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.None)] // TPC
        public int personId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
