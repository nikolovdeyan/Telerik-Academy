using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value > 6 || value < 2)
                {
                    throw new ArgumentOutOfRangeException("Allowed grades for students are between 2 and 6.");
                }

                this.grade = value;
            }
        }

        public override string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name of the student cannot be blank.");
                }

                this.firstName = value;
            }
        }

        public override string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name of the student cannot be blank.");
                }

                this.lastName = value;
            }
        }
    }
}
