using System;
using System.Text;

namespace Events.Models
{
    public static class Messages
    {
        internal static StringBuilder output = new StringBuilder();

        public static void EventAdded()
        {
            output.Append("Event added");
            output.Append(Environment.NewLine);
        }

        public static void EventDeleted(int count)
        {
            if (count == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted", count)
                    .Append(Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            output.Append("No events found")
                .Append(Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint)
                    .Append(Environment.NewLine);
            }
        }
    }
}
