using Human.Contracts;
using Human.Enums;

namespace Human.Models
{
    public class Person : IPerson
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
