using Events.Contracts;
using Events.Models;
using System;
using System.Globalization;

namespace Events.Core
{
    public class Engine : IEngine
    {
        private const char CommandDelimiter = '|';
        private const int DateTimeFormatterLength = 20;
        private const string DeleteEventsCommandString = "DeleteEvents";
        private const string ListEventsCommandString = "ListEvents";
        private const string AddEventsCommandString = "AddEvent";
        private const string DateTimeFormatString = "yyyy-MM-ddtHH:mm:ss";

        private static IEngine instanceHolder = new Engine();

        // Singleton -> private constructor
        private Engine()
        {
            Events = new EventHolder();
        }

        public static IEngine Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        internal static EventHolder Events { get; private set; }

        public void Start()
        {
            while (ExecuteNextCommand())
            {
            }

            Console.WriteLine(Messages.output);
        }

        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command[0] == 'A')
            {
                AddEvent(command);

                return true;
            }

            if (command[0] == 'D')
            {
                DeleteEventsCommand(command);

                return true;
            }

            if (command[0] == 'L')
            {
                ListEventsCommand(command);

                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }

        private static void ListEventsCommand(string command)
        {
            int delimiterIndex = command.IndexOf(CommandDelimiter);
            string countString = command.Substring(delimiterIndex + 1);
            int count = int.Parse(countString);

            DateTime date = GetDate(command, ListEventsCommandString);

            Events.ListEvents(date, count);
        }

        private static void DeleteEventsCommand(string command)
        {
            string titleToDelete = command.Substring(DeleteEventsCommandString.Length + 1);

            Events.DeleteEvents(titleToDelete);
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, AddEventsCommandString, out date, out title, out location);

            Events.AddEvent(date, title, location);
        }

        private static void GetParameters(
            string commandForExecution, 
            string commandType, 
            out DateTime dateAndTime, 
            out string eventTitle, 
            out string eventLocation)
        {
            int firstDelimiterIndex = commandForExecution.IndexOf(CommandDelimiter);
            int lastDelimiterIndex = commandForExecution.LastIndexOf(CommandDelimiter);

            dateAndTime = GetDate(commandForExecution, commandType);

            if (firstDelimiterIndex == lastDelimiterIndex) 
            {
                // If no location is provided
                eventTitle = commandForExecution.Substring(firstDelimiterIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(
                    firstDelimiterIndex + 1, 
                    lastDelimiterIndex - firstDelimiterIndex - 1)
                    .Trim();

                eventLocation = commandForExecution.Substring(lastDelimiterIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            string dateTimeString = command.Substring(commandType.Length + 1, DateTimeFormatterLength).Trim();

            Console.WriteLine(dateTimeString);

            DateTime date = DateTime.ParseExact(dateTimeString, DateTimeFormatString, CultureInfo.InvariantCulture);

            return date;
        }
    }
}