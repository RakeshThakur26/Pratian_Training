using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeProblem
{
    class Trainer
    {

        public Organization Org  = new Organization();

        
        public List<Trainee> trainees { get; set; } = new List<Trainee>();
        public List<Training> trainings { get; set; } = new List<Training>();
    }
}
