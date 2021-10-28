using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersTrainee
{
    class Program
    {
        static void Main(string[] args)
        {
            Training[] trainings = new Training[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter details for " + (i+1) + " Training");
                trainings[i] = new Training();
                trainings[i].setTraings();
                Console.WriteLine();
            }

            Console.WriteLine("**********************");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Organisation Name : " + trainings[i].getTrainingOrganizationName());
                Console.WriteLine();
            }
            Console.WriteLine("**********************");

            Console.Read();
        }
    }
}
