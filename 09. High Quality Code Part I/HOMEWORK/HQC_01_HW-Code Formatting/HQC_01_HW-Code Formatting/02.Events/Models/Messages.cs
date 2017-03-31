using System;
using System.Text;

namespace Events.Models
{
    public static class Messages
    {
        internal static StringBuilder Output = new StringBuilder();

        public static void EventAdded()
        {
            Output.Append("Event added");
            Output.Append(Environment.NewLine);
        }

        public static void EventDeleted(int count)
        {
            if (count == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted", count)
                    .Append(Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            Output.Append("No events found")
                .Append(Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint)
                    .Append(Environment.NewLine);
            }
        }
    }
}
