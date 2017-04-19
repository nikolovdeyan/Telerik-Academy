using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Tomcat : Cat 
    {
        private const Gender TomcatGender = Gender.Male;

        public Tomcat (string name, int age)
            : base (name, age, Tomcat.TomcatGender)
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
                if (value != Tomcat.TomcatGender)
                {
                    throw new ArgumentException("Kitten gender is set to female by default.");
                }
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
    }
}
