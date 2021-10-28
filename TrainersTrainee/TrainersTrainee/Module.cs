using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersTrainee
{
    class Module
    {
        public int ModuleNumber { get; set; }
        public string ModuleName { get; set; }

        List<Unit> units = new List<Unit>();

        public List<Unit> getUnits(Module module)
        {
            return (module.units);
        }
    }
}
