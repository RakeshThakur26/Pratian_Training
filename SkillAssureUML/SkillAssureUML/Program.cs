using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureUML
{
    class Program
    {
        static void Main(string[] args)
        {
            MCQquestion mcq1 = new MCQquestion();
            mcq1.QuestionName = "3 + 7 = ?";
            mcq1.option1 = "10";
            mcq1.option2 = "4";
            mcq1.option3 = "9";
            mcq1.option4 = "6";
            mcq1.RightOption = 1;

            Console.WriteLine("Question : " + mcq1.QuestionName);
            Console.WriteLine("1 : " + mcq1.option1);
            Console.WriteLine("2 : " + mcq1.option2);
            Console.WriteLine("3 : " + mcq1.option3);
            Console.WriteLine("4 : " + mcq1.option4);

            Console.WriteLine("Please select correct option");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == mcq1.RightOption)
                mcq1.marks = 1;
            else
                mcq1.marks = 0;

            Assessment assessment = new Assessment();
            assessment.mcqs.Add(mcq1);
           // assessment.handsOns.Add(null);
            assessment.AssessmentId = "1";
            assessment.Desc = "Assessment 1 on C#";
            assessment.AssessmentDate = DateTime.Today;

            Course course = new Course();
            course.assessments.Add(assessment);
           course.assessments.Add(assessment);

            SkillAssureTrainingModel skillassure = new SkillAssureTrainingModel();
            Console.WriteLine("Enter Client Name");

            skillassure.ClientName =  Console.ReadLine();

            skillassure.courses.Add(course);

            Console.WriteLine("Total number of assignments in the trainings = " + skillassure.getTotalAssessmentInTheTraining());
            Console.WriteLine("Total number of MCQ based Questions = " + skillassure.getNumMCQBasedQuestions());
            Console.WriteLine("Total number of Hands On Questions = " + skillassure.getNumHandsOnQuestions());
            Console.WriteLine("Total Scores of all assignments = " + skillassure.getTotalScoresOfAlAssignments());

            Console.ReadLine();

        }
    }
}
