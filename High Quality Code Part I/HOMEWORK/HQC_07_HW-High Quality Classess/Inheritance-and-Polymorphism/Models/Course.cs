using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.Models
{
    public abstract class Course
    {
        private string courseName;
        private string teacherName;
        private List<string> students;

        public Course(string courseName, string teacherName, List<string> students)
        {
            this.CoureseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public Course(string courseName)
        {
            this.CoureseName = this.courseName;
            this.TeacherName = this.teacherName;
            this.Students = new List<string>();

            for (int i = 0; i < this.Students.Count; i++)
            {
                this.AddStudent(this.Students[i]);
            }
        }

        public Course(string courseName, string teacherName)
        {
            this.CoureseName = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();

            for (int i = 0; i < this.Students.Count; i++)
            {
                this.AddStudent(this.Students[i]);
            }
        }

        public string CoureseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                this.teacherName = value;
            }
        }

        public List<string> Students { get; set; }

        public void AddStudent(string name)
        {
            if (name == null || name.Length == 0)
            {
                throw new ArgumentException("Student name cannot be null or empty");
            }

            this.Students.Add(name);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.CoureseName);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
