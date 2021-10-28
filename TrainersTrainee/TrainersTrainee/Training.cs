using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersTrainee
{
    class Training
    {
        public string TrainingName { get; set; }
        // List<Trainee> trainees = new List<Trainee>();

        Trainee tt = new Trainee();
        Trainer trnr = new Trainer();

        public Trainee TT
        {
            get { return tt; }
            set { tt = value; }
        }
        public Trainer Trnr
        {
            get { return trnr; }
            set { trnr = value; }
        }

        public int getNumOfTrainees()
        {
            return Trainee.count;
        }

        public void setTraings()
        {
            Console.WriteLine("Enter Training Name ");
            this.TrainingName = Console.ReadLine();

            this.Trnr.setTrainerForTraining();

        }


        public string getTrainingOrganizationName()
        {
            return (this.Trnr.getOrganization());
        }


    }
}
