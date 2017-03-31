using System;
using System.Text.RegularExpressions;

namespace _15.ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            string result = Regex.Replace(inputStr, @"<a.href=""([^>]*)"">([^<]*(?:(?!</a)<[^<]*)*)</a>", "[$2]($1)");

            Console.WriteLine(result);
        }
    }
}
