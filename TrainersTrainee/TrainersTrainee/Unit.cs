using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersTrainee
{
    class Unit
    {
        public int UnitNumber { get; set; }
        public string UnitName { get; set; }
        public int Durationhrs { get; set; }

        List<Topic> topics = new List<Topic>();

        public int getDurationHrs(Unit u)
        {
            return u.Durationhrs;
        }
    }
}
