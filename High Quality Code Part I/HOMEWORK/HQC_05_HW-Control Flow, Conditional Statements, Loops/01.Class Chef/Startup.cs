using Kitchen.Models;

namespace Kitchen
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            // Some tests are available in task 02
            Chef myChef = new Chef();

            myChef.Cook();
        }
    }
}
