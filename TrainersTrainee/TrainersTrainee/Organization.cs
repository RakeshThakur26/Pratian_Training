using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersTrainee
{
    class Organization
    {
        public string OrganizationName { get; set; }

        List<Trainer> trainers = new List<Trainer>();

        public string getNames()
        {
            return this.OrganizationName;
        }
    }
}
