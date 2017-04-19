using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class SchoolClass : IComment
    {
        private ICollection<Student> studentList;
        private ICollection<Teacher> teacherList;
        private string classId;

        public SchoolClass(ICollection<Student> students, ICollection<Teacher> teachers, string classID)
        {
            this.StudentList = students;
            this.TeacherList = teachers;
            this.ClassId = classID;
        }

        public ICollection<Student> StudentList
        {
            get
            {
                return this.studentList;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Classes should have at least one student enrolled.");
                }

                this.studentList = value;
            }
        }

        public ICollection<Teacher> TeacherList
        {
            get
            {
                return this.teacherList;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Classes should have at least one teacher enlisted.");
                }

                this.teacherList = value;
            }
        }

        public string ClassId
        {
            get
            {
                return this.classId;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class Id should not be empty.");
                }

                this.classId = value;
            }
        }

        public string Comment
        {
            get;

            private set;
        }
    }
}
