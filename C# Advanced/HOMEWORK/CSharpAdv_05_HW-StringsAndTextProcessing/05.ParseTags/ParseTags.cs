using System;
using System.Text.RegularExpressions;

namespace _05.ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string pattern = @"<upcase>(.*?)</upcase>";

            string output = Regex.Replace(inputStr, pattern, m => m.Groups[1].Value.ToUpper());
            Console.WriteLine(output);
        }
    }
}
