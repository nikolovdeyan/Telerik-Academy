using Methods.Models;
using Methods.Utils;
using System;

namespace Methods
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Test: Calculate triangle area with sides 3, 4, 5: ");
            Console.WriteLine(Utilities.CalcTriangleArea(3, 4, 5));
            Console.WriteLine();

            Console.WriteLine("Test: Convert a single digit to string with 5: ");
            Console.WriteLine(Utilities.ConvertSingleDigitNumberToString(5));
            Console.WriteLine();

            Console.WriteLine("Test: Find max element amongst the given params 5, -1, 3, 2, 14, 2, and 3: ");
            Console.WriteLine(Utilities.FindMaxElement(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine();

            Console.WriteLine("Test: Print a given floating point number with different formats applied: ");
            Console.WriteLine(" - 1.3 as a floating point number: ");
            Utilities.PrintAsNumber(1.3, "f");
            Console.WriteLine(" - 0.75 as a percentage: ");
            Utilities.PrintAsNumber(0.75, "%");
            Console.WriteLine(" - 2.30 right aligned: ");
            Utilities.PrintAsNumber(2.30, "r");
            Console.WriteLine();

            bool horizontal; 
            bool vertical;
            Console.WriteLine("Test: Calculate a line width and if it has horizontal or vertical alignment: ");
            Console.WriteLine(Utilities.CalculateLineLength(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
            Console.WriteLine();

            Console.WriteLine("Test: Compare age of two students:  ");
            Student peter = new Student()
            {
                FirstName = "Peter",
                LastName = "Ivanov",
                OtherInfo = "From Sofia, born at 17.03.1992"
            };

            Student stella = new Student()
            {
                FirstName = "Stella",
                LastName = "Markova",
                OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993"
            };

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName, 
                stella.FirstName, 
                peter.IsOlderThan(stella));
        }
    }
}