using System;

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            char[] inputStrArr = inputStr.ToCharArray();

            foreach (var ch in inputStrArr)
            {
                Console.Write("\\u" + ((int)ch).ToString("X").PadLeft(4, '0'));
            }
        }
    }
}
