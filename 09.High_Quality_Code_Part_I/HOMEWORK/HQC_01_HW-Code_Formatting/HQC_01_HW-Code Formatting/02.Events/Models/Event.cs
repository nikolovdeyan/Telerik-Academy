using Events.Contracts;
using System;
using System.Text;

namespace Events.Models
{
    public class Event : IComparable, IEvent
    {
        private const string DateTimeFormatter = "yyyy-MM-ddtHH:mm:ss";
        private const string CommandDelimiter = " | ";

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;

            this.Title = title;

            this.Location = location;
        }

        public DateTime Date { get; private set; }

        public string Title { get; private set; }

        public string Location { get; private set; }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;

            int orderByDate = this.Date.CompareTo(other.Date);
            int orderByTitle = this.Title.CompareTo(other.Title);
            int orderByLocation = this.Location.CompareTo(other.Location);

            if (orderByDate == 0 && orderByTitle == 0)
            {
                return orderByLocation;
            }
            else if (orderByDate == 0)
            {
                return orderByTitle;
            }
            else
            {
                return orderByDate;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string dateString = this.Date.ToString(DateTimeFormatter);

            string titleString = CommandDelimiter + this.Title;

            string locationString = 
                (this.Location != null && 
                this.Location != string.Empty) ? (CommandDelimiter + this.Location) : string.Empty;

            sb.Append(dateString)
                .Append(titleString)
                .Append(locationString);

            return sb.ToString();
        }
    }
}