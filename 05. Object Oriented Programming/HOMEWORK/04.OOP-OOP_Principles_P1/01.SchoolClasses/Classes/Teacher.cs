using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Teacher : Person, IComment
    {
        private ICollection<Discipline> disciplinesTaught;

        public Teacher(string name, List<Discipline> listOfDisciplines)
            : base(name)
        {
            this.DisciplinesTaught = listOfDisciplines;
        }

        public ICollection<Discipline> DisciplinesTaught
        {
            get
            {
                return this.disciplinesTaught;
            }

            private set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Teacher should have at least one discipline applied.");
                }

                this.disciplinesTaught = value;
            }
        }

    }
}
