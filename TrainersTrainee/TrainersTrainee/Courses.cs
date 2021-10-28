using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersTrainee
{
    class Courses
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        List<Training> trainings = new List<Training>();

        List<Module> modules = new List<Module>();

        public List<Module> GetModules(Courses course)
        {
            return (course.modules);
        }
    }
}
