using Human.Contracts;
using Human.Core;

namespace Human
{
    public class Startup
    {
        public static void Main()
        {
            IPersonFactory factory = new PersonFactory();

            factory.CreatePerson(0);
        }
    }
}
