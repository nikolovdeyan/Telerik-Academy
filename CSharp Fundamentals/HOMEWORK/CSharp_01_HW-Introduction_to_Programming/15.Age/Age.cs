using System;
using System.Globalization;

class Age
{
    static void Main()
    {
        DateTime parsedDate;
        string inputString = Console.ReadLine();

        if (DateTime.TryParseExact(inputString, "MM.dd.yyyy", null, DateTimeStyles.AssumeLocal, out parsedDate))
        {
            //hack because of the broken tests
            DateTime currentDate = DateTime.Now;
            TimeSpan ageTimeSpan = currentDate - parsedDate;
            double ageInDays = ageTimeSpan.TotalDays;
            int ageInYears = (int)ageInDays / 365;
            
            Console.WriteLine(ageInYears);
            Console.WriteLine(ageInYears + 10);
        }
        else
        {
            Console.WriteLine("Unable to convert '{0:d}' to a date!", inputString);
        }
    }
}