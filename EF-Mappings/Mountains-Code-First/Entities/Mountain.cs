using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountains_Code_First.Entities
{
    public class Mountain
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Peak> Peaks { get; set; }
        public virtual ICollection<Country> Countries { get; set; }

        public Mountain()
        {
            this.Countries = new HashSet<Country>();
            this.Peaks = new HashSet<Peak>();
        }

    }
}
