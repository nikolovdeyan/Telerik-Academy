using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Frog : Animal
    {
        private const string SoundOfFrog = "Rrribbit!";

        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public override Gender Gender
        {
            get
            {
                return this.gender;
            }

            protected set
            {
                this.gender = value;
            }
        }

        public override string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public override string MakeSound()
        {
            return Frog.SoundOfFrog;
        }
    }
}
