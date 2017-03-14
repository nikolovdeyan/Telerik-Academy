using System;

namespace Events.Contracts
{
    public interface IEvent
    {
        DateTime Date { get; }

        string Title { get; }

        string Location { get; }

        int CompareTo(object obj);

        string ToString();
    }
}
