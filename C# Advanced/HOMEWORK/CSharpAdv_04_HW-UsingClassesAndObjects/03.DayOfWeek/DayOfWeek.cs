using System;

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("Today is {0}", today.ToString("dddd"));
        }
    }
}