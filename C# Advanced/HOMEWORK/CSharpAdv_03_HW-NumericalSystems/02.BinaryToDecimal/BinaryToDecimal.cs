using System;
using System.Linq;

class BinaryToDecimal
{
    static void Main()
    {
        string inputNum = Console.ReadLine();

        Console.WriteLine(Base2ToBase10(inputNum));
    }

    static long Base2ToBase10(string numBase2)
    {
        long result = 0;
        int inputBase = 2;

        // My initial approach: 
        int[] numBase2Arr = numBase2.Select(ch => ch - '0').ToArray();

        for (int i = 0; i < numBase2Arr.Length; i++)
        {
            result += numBase2Arr[i] * (long)Math.Pow(2, numBase2Arr.Length - 1 - i);
        }

        // Horner's Method:
        //foreach (char digit in numBase2)
        //{
        //    result = result * inputBase + (digit - '0');
        //}

        return result;
    }
}

