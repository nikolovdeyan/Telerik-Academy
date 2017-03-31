using System;
using System.Linq;
using System.Collections.Generic;

class SumInArray
{
    static void Main()
    {
        int[] inputArr = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.None)
            .Select(member => Convert.ToInt32(member))
            .ToArray();
        int soughtNum = int.Parse(Console.ReadLine());
        int currentSum = inputArr[0];
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < inputArr.Length; i++)
        {
            if (currentSum > soughtNum)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += inputArr[i];

            if (currentSum == soughtNum)
            {
                endIndex = i;
            }
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i == endIndex)
            {
                Console.Write("{0}", inputArr[i]);
            }
            else
            {
                Console.Write("{0}, ", inputArr[i]);
            }
        }

        Console.WriteLine();
    }
}
