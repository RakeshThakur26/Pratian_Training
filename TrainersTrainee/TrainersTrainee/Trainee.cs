using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersTrainee
{
    class Trainee
    {
        public static int count = 0;
        public string TraineeId { get; set; }
        public string TraineeName { get; set; }

        List<Training> trainings = new List<Training>();

        public Trainee()
        {
            count++;
        }
        
       
        
      
    }
}
