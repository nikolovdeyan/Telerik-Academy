using System;

namespace Events.Contracts
{
    public interface IEventHolder
    {
        void AddEvent(DateTime date, string title, string location);

        void DeleteEvents(string titleToDelete);

        void ListEvents(DateTime date, int count);
    }
}