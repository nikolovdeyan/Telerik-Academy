using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Discipline : IComment
    {
        private string name;
        private string[] lectures;
        private string[] exercises;

        public Discipline(string name, string[] lectures, string[] exercises)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException ("Name not provided for discipline.");
                }

                this.name = value;
            }
        }

        public string[] Lectures
        {
            get
            {
                return this.lectures;
            }

            private set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Discipline should have at least one lecture applied.");
                }

                this.lectures = value;
            }
        }

        public string[] Exercises
        {
            get
            {
                return this.Exercises;
            }

            private set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Discipline should have at least one exercise defined.");
                }

                this.exercises = value;
            }
        }

        public string Comment
        {
            get;

            private set;
        }
    }
}
