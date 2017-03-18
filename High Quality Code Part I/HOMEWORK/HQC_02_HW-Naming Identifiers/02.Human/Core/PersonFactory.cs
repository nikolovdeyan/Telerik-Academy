using Human.Contracts;
using Human.Models;

namespace Human.Core
{
    internal class PersonFactory : IPersonFactory
    {
        public void CreatePerson(int age)
        {
            // This factory method is useless, as the created instance of Person is never returned
            Person person = new Person();

            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Male Person Instance";
                person.Gender = Enums.Gender.male;
            }
            else
            {
                person.Name = "Female Person Instance";
                person.Gender = Enums.Gender.female;
            }
        }
    }
}