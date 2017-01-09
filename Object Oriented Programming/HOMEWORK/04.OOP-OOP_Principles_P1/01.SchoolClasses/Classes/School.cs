using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class School
    {
        private ICollection<SchoolClass> classesList;

        public School(ICollection<SchoolClass> classes)
        {
            this.ClassesList = classes;
        }

        public ICollection<SchoolClass> ClassesList
        {
            get
            {
                return this.classesList;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("The school should have at least one class assigned.");
                }

                this.classesList = value;
            }
        }
    }
}