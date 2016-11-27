using System;
using System.Text.RegularExpressions;

namespace _04.SubstringInText
{
    class SubstringInText
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string inputStr = Console.ReadLine().ToLower();

            int result = new Regex(Regex.Escape(pattern)).Matches(inputStr).Count;

            // My initial approach: 
            //for (int i = 0; i <= inputStr.Length - pattern.Length; i++)
            //{
            //    if (inputStr.Substring(i, pattern.Length) == pattern)
            //    {
            //        result += 1;
            //    }
            //}

            Console.WriteLine(result);
        }
    }
}
