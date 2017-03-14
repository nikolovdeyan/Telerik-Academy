using Events.Core;

namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize Singleton
            var engine = Engine.Instance;

            engine.Start();

// Some commands to test the code below:
// yyyy-MM-ddTHH:mm:ss
// AddEvent 2017 - 03 - 13A09: 00:00 | MyTestEvent Number 1
// AddEvent 2017 - 03 - 13P14: 00:00 | MyTestEvent Number 2
// AddEvent 2017 - 03 - 13P14: 20:00 | MyTestEvent Number 3
// AddEvent 2017 - 03 - 14A10: 30:00 | MyTestEventWithLocation Number 4 | Sofia, Bulgaria
// AddEvent 2017 - 03 - 15P15: 30:00 | MyTestEventWithLocation Number 5 | Sofia, Bulgaria
// DeleteEvents MyTestEvent Number 1
// ListEvents 2017 - 03 - 13A09: 00:00 | 3
        }
    }
}