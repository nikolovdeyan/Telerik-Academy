using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] firstArray = new int[arrayLength];
        int[] secondArray = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        } 

        for (int i = 0; i < arrayLength; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(firstArray.SequenceEqual(secondArray) ? "Equal" : "Not equal");
    }
}