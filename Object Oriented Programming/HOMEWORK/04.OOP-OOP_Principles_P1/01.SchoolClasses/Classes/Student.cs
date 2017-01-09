using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Student : Person, IComment
    {
        private string studentNumber;

        public Student(string name, string studentNumber)
            : base(name)
        {
            this.StudentNumber = studentNumber;
        }

        public string StudentNumber
        {
            get
            {
                return this.studentNumber;
            }

            private set
            {                
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Student number was not provided for student.");
                }

                this.studentNumber = value;
            }
        }

    }
}
