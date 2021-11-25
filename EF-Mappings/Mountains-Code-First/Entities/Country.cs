using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountains_Code_First.Entities
{
    public class Country
    {
        [Key]
        [StringLength(2, MinimumLength =2)]
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Mountain> Mountains { get; set; }

        public Country()
        {
            this.Mountains = new HashSet<Mountain>();
        }

    }
}
