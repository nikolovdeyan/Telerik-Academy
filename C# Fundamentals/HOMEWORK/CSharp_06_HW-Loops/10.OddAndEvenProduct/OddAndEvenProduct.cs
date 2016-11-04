using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int numElements = int.Parse(Console.ReadLine());
        string inputString = Console.ReadLine();
        string[] stringArray = inputString.Split(' ');
        // blatantly copy-pasted from msdn.com
        int[] integerArray = Array.ConvertAll<string, int>(stringArray, int.Parse);

        long resEven = 1;
        long resOdd = 1;

        for (int i = 0; i < integerArray.Length; i++)
        {
            if (i % 2 == 0)
            {
                resEven *= integerArray[i];
            }
            else
            {
                resOdd *= integerArray[i];
            }
        }
        Console.WriteLine(((resOdd == resEven) ? "yes {0}": "no {1} {0}"), resOdd, resEven);
    }
}