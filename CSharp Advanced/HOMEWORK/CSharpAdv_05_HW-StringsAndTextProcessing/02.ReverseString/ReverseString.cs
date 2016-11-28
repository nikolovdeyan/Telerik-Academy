using System;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string result = string.Empty;

            char[] charArr = inputStr.ToCharArray();
            Array.Reverse(charArr);

            Console.WriteLine(charArr);
        }
    }
}
