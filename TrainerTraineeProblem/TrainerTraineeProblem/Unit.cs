using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeProblem
{
    class Unit
    {
        public int DurationHrs { get; set; }
        public List<Topic> TopicList = new List<Topic>();
        public int getDurationHours()
        {
            return DurationHrs;
        }
    }
}
