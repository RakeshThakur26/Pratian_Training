using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersTrainee
{
    class Trainer
    {
        public string TrainerId { get; set; }
        public string TrainerName { get; set; }

        List<Trainee> trainees = new List<Trainee>();

        List<Training> trainings = new List<Training>();

        Organization org = new Organization();

        public Organization Org
        {
            get { return org; }
            set { org = value; }
        }
        
       public void setTrainerForTraining()
        {
            Console.WriteLine("Enter trainer id : ");
            this.TrainerId = Console.ReadLine();

            Console.WriteLine("Enter organization Name : ");
            this.Org.OrganizationName = Console.ReadLine();

        }

        public string getOrganization()
        {
            return (this.Org.OrganizationName);
        }

    }
}
