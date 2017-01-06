using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            // First create an array of strings with different lengths
            string[] myStrArr = new string[]
            {
                "I don't want to hear you",
                "I don't want to hear you, no",
                "Yeah but his bird thinks its amazing, though",
                "So all that's left",
                "Is the proof that love's not only blind but deaf"
            };

            // Find the string with maximum length for an array of strings with LINQ.
            var largestStr = myStrArr.OrderByDescending(str => str.Length).First();

            // Print results
            Console.WriteLine("******************************************");
            Console.WriteLine("The longest string is:");
            Console.WriteLine(largestStr);

        }
    }
}
