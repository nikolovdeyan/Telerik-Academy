using System;

class MaximalKSum
{
    static void Main()
    {
        int arrLength = int.Parse(Console.ReadLine());
        int numElem = int.Parse(Console.ReadLine());
        long[] numArray = new long[arrLength];
        long result = 0;

        for (int i = 0; i < arrLength; i++)
        {
            numArray[i] = long.Parse(Console.ReadLine());
        }

        Array.Sort(numArray);
        Array.Reverse(numArray);

        for (int i = 0; i < numElem; i++)
        {
            result += numArray[i];
        }
        Console.WriteLine(result);
    }
}