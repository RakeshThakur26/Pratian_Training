using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeProblem
{
    class Training
    {
        public Trainer Trainer { get; set; }
        public List<Trainee> trainees { get; set; } = new List<Trainee>();

        public Course Course { get; set; }

        public int getNumOfTrainees()
        {
            return trainees.Count;
        }

        public string getTrainingOrganizationName()
        {
            return Trainer.Org.Name;
        }

        public int getTrainingDurationInHrs()
        {
            int total = 0;
            for (int i = 0; i < Course.ModuleList.Count; i++)
            {
                Module MOD = Course.ModuleList[i];
                for (int j = 0; j < MOD.Units.Count; j++)
                {
                    total += MOD.Units[j].DurationHrs;
                }
            }
                       
            return total;
        }
    }
}
