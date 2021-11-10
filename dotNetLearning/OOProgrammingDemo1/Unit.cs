using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo1
{
    public class Unit
    {
        public int DurationInHrs { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
}
