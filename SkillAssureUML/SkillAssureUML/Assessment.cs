using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureUML
{
    class Assessment
    {
        public string AssessmentId { get; set; }
        public string Desc { get; set; }
        public int NoOfQuestions { get; set; }
        public DateTime AssessmentDate { get; set; }
        public List<MCQquestion> mcqMarks { get; set; } = new List<MCQquestion>();
        public List<HandsOnQuestion> handsOnMarks { get; set; } = new List<HandsOnQuestion>();
        public int TotalMarks()
        {
            int total = 0;
            total += this.mcqMarks[0].marks;
            total += this.handsOnMarks[0].marks;

            return total;
        }
    }
}
