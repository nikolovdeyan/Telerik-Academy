using System;
using System.Text;

namespace _23.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            char prevChar = '\0';
            foreach (var ch in inputStr)
            {
                if (ch == prevChar)
                {
                    continue;
                }
                else
                {
                    result.Append(ch);
                    prevChar = ch;
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
