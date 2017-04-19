using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public abstract class Cat : Animal
    {
        private const string SoundOfCat = "Meow!";

        public Cat(string name, int age, Gender gender) 
            : base(name, age, gender)
        {
        }

        public override string MakeSound()
        {
            return Cat.SoundOfCat;
        }
    }
}
