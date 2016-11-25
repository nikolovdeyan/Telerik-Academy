using System;

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int inputYear = int.Parse(Console.ReadLine());
            Console.WriteLine(IsLeapYear(inputYear));
        }

        static string IsLeapYear(int year)
        {
            // Using this common trick to determine the year type
            string yearType = "Common";

            if (year % 4 == 0 
                && year % 100 != 0 
                || year % 400 == 0)
            {
                yearType = "Leap";
            }

            return yearType;
        }
    }
}
