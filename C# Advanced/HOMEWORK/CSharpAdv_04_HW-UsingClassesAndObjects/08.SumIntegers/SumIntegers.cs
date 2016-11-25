using System;
using System.Linq;

namespace _08.SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            string inputNums = Console.ReadLine();

            Console.WriteLine(SumIntegersString(inputNums));
        }

        static long SumIntegersString (string integersStr)
        {
            long result = 0;
            int[] integersArr = integersStr.Split(' ')
                .Select(int.Parse)
                .ToArray();

            foreach (var num in integersArr)
            {
                result += num;
            }

            return result;
        }
    }
}
