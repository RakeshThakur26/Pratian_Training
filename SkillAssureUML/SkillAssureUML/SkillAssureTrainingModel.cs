using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureUML
{
    class SkillAssureTrainingModel
    {
        public string ClientName { get; set; }
        public List<Course> courses { get; set; } = new List<Course>();

        public int getTotalAssessmentInTheTraining()
        {
            int total = 0;
            foreach (var item in this.courses)
            {
                total += item.assessments.Count;
            }
            return total;
        }

        public int getNumMCQBasedQuestions()
        {
            int total = 0;
            foreach (var item in this.courses)
            {
                for (int i = 0; i < item.assessments.Count; i++)
                {
                    total += item.assessments[i].mcqs.Count;
                }
            }
            return total;
        }

         public int getNumHandsOnQuestions()
        {
            int total = 0;
            foreach (var item in this.courses)
            {
                for (int i = 0; i < item.assessments.Count; i++)
                {
                    total += item.assessments[i].handsOns.Count;
                }
            }
            return total;
        }

         public int getTotalScoresOfAlAssignments()
        {
            int total = 0;
            foreach (var item in this.courses)
            {
                for (int i = 0; i < item.assessments.Count; i++)
                {
                    total += item.assessments[i].TotalMarks();
                }
            }
            return total;
        }


    }
}
