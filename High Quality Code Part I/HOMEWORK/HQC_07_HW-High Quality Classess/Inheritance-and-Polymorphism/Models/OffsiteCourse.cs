using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.Models
{
    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string courseName)
            : base(courseName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, List<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, List<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}