using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeProblem
{
    class Module
    {
        public List<Unit> Units { get; set; } = new List<Unit>();

        public List<Unit> getUnits()
        {
            return Units;
        }
    }
}
