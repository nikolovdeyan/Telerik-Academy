using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    // Class Person is a base class for both Student and Teacher
    public class Person : IComment
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Every person should have a name.");
                }

                this.name = value;
            }
        }

        public string Comment
        {
            get;

            private set;
        }

    }
}
