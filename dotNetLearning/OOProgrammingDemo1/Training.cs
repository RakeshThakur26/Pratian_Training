using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo1
{
    public class Training
    {
        public Trainer Trainer { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public Course Course { get; set; }


        public string GetOrgName()
        {
            return Trainer.TheOrganization.Name;
        }

        public int GetNoTrainees()
        {
            return Trainees.Count;
        }

        public int GetTrainingDurationInHrs()
        {
            int totDuration = 0;
            // iterate modules
            foreach (Module module in Course.Modules)
            {
                // iterate unit
                foreach (Unit unit in module.Units)
                {
                    totDuration += unit.DurationInHrs;
                }
            }
            return totDuration;
        }
    }
}
