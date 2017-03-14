using System;
using Events.Contracts;
using Wintellect.PowerCollections;

namespace Events.Models
{
    public class EventHolder : IEventHolder
    {
        private MultiDictionary<string, Event> eventsByTitle = new MultiDictionary<string, Event>(true);

        private OrderedBag<Event> eventsByDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);

            this.eventsByTitle.Add(title.ToLower(), newEvent);
            this.eventsByDate.Add(newEvent);

            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in this.eventsByTitle[title])
            {
                removed++;
                this.eventsByDate.Remove(eventToRemove);
            }

            this.eventsByTitle.Remove(title);

            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.eventsByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);

            int numShownEvents = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (numShownEvents == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                numShownEvents++;
            }

            if (numShownEvents == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
