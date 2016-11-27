using System;
using System.Text;

namespace _06.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                result.Append((i < inputStr.Length) ? inputStr[i] : '*');
            }

            Console.WriteLine(result);
        }
    }
}
