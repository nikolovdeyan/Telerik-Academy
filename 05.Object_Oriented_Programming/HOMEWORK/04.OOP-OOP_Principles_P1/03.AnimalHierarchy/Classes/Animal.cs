using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        protected int age;
        protected string name;
        protected Gender gender;

        public Animal (string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public abstract int Age
        {
            get; set;
        }
        
        public abstract string Name
        {
            get; set;
        }

        public abstract Gender Gender
        {
            get; protected set;
        }

        public abstract string MakeSound();
    }
}
