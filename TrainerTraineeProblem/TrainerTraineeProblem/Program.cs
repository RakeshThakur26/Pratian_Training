using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Training training = new Training();
           
            Console.WriteLine("Enter organization name : ");
            string name = Console.ReadLine();
            Organization org = new Organization { Name = name };

            //creating 2 objects of  Trainer class and assigning Organization object
            Trainer trainer = new Trainer { Org = org };
            Trainer trainer2 = new Trainer { Org = org };

            //creating 3 objects of  Traieee class and assigning Trainer to each trainee
            Trainee t1 = new Trainee { Trainer = trainer };
            Trainee t2 = new Trainee { Trainer = trainer };
            Trainee t3 = new Trainee { Trainer = trainer2 };

            training.Trainer = trainer;
            training.Trainer = trainer2;

            Course c = new Course();

            // Creating 3 module objects
            Module m1 = new Module();
            Module m2 = new Module();
            Module m3 = new Module();

            Console.WriteLine("Enter duration for unit 1 : ");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Unit u1 = new Unit { DurationHrs = d1 };

            Console.WriteLine("Enter duration for unit 2 : ");
            int d2 = Convert.ToInt32(Console.ReadLine());
            Unit u2 = new Unit { DurationHrs = d2 };

            // topics of units
            Topic top1 = new Topic { Name = "C#" };
            Topic top2 = new Topic { Name = "SQL" };
            Topic top3 = new Topic { Name = "Azure" };

            // Adding topics to topiclist in Unit
            u1.TopicList.Add(top1);
            u2.TopicList.Add(top2);
            u1.TopicList.Add(top3);
            u1.TopicList.Add(top2);
            u2.TopicList.Add(top1);
            u2.TopicList.Add(top3);

            // Adding Unit object to unitlist in modules
            m1.Units.Add(u1);
            m1.Units.Add(u2);
            m2.Units.Add(u1);
            m2.Units.Add(u2);
            m3.Units.Add(u1);
            m3.Units.Add(u2);

            // Adding modules to modulelist in courses
            c.ModuleList.Add(m1);
            c.ModuleList.Add(m2);
            c.ModuleList.Add(m3);

            training.Course = c;
            // Adding trainee objects to traineelist in trainings
            training.trainees.Add(t1);
            training.trainees.Add(t2);
            training.trainees.Add(t3);

            Console.WriteLine("********************************************");

            Console.WriteLine("Total number of trainees = " + training.getNumOfTrainees());
            
            Console.WriteLine("Total Training duration  = " + training.getTrainingDurationInHrs());
           
            Console.WriteLine("Name of the Training organization = " + training.getTrainingOrganizationName());
            Console.WriteLine("********************************************");
            Console.ReadLine();

        }
    }
}
