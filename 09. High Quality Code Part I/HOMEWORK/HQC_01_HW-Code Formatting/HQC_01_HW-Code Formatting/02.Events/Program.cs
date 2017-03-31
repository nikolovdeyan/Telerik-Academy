using Events.Core;

// Dear reviewer, please read the !ReadMe.txt file for my notes on this task
namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize Singleton
            var engine = Engine.Instance;

            engine.Start();
        }
    }
}