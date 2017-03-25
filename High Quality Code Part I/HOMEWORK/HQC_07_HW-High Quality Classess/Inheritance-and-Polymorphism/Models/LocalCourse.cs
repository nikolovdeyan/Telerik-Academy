using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.Models
{
    public class LocalCourse : Course
    {
        public LocalCourse(string courseName)
            : base(courseName)
        {
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, List<string> students, string lab)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name + " { Name = ");
            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}