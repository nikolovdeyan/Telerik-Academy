using System;
using System.Linq;
using System.Text;

class NumberAsArray
{
    static void Main()
    {
        string[] inputLengths = Console.ReadLine().Split(' ');
        int sizeArrFirst = int.Parse(inputLengths[0]);
        int sizeArrSecond = int.Parse(inputLengths[1]);

        int[] arrayFirst = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int[] arraySecond = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        string result = ArraySum(arrayFirst, arraySecond);
        Console.WriteLine(result);
    }

    static string ArraySum(int[] arr1, int[] arr2)
    {
        int longerArrLength = (arr1.Count() > arr2.Count()) ? arr1.Count() : arr2.Count();
        int shorterArrLength = (arr1.Count() < arr2.Count()) ? arr1.Count() : arr2.Count();

        int[] longerArr = new int[longerArrLength];
        int[] shorterArr = new int[shorterArrLength];

        if (arr1.Length > arr2.Length)
        {
            arr1.CopyTo(longerArr, 0);
            arr2.CopyTo(shorterArr, 0);
        }
        else
        {
            arr1.CopyTo(shorterArr, 0);
            arr2.CopyTo(longerArr, 0);
        }

        StringBuilder result = new StringBuilder();

        int carryOver = 0;
        for (int i = 0; i < longerArrLength; i++)
        {
            if (i < shorterArrLength)
            {
                int sum = longerArr[i] + shorterArr[i] + carryOver;
                if (sum >= 10)
                {
                    result.Append(sum % 10).Append(' ');
                    carryOver = (int)sum / 10;
                }
                else
                {
                    result.Append(sum).Append(' ');
                    carryOver = 0;
                }
            }
            else
            {
                int sum = longerArr[i] + carryOver;
                if (sum >= 10)
                {
                    result.Append(sum % 10).Append(' ');
                    carryOver = (int)sum / 10;
                }
                else
                {
                    result.Append(sum).Append(' ');
                    carryOver = 0;
                }
            }
        }
        return result.ToString();
    }
}