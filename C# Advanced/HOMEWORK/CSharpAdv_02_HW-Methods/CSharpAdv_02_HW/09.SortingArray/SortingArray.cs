using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] inputArr = Console.ReadLine()
            .Split()
            .Select(member => Convert.ToInt32(member))
            .ToArray();

        SortArrayAsc(inputArr);

        foreach (var item in inputArr)
        {
            Console.Write("{0} ", item);
        }
    }

    static int FindLargestElementIndex(int startIndex, int[] array)
    {
        int result = 0;
        int maxMember = array[startIndex];
        for (int i = startIndex + 1; i < array.Length; i++)
        {
            if (array[i] > maxMember)
            {
                result = i;
                maxMember = array[i];
            }
        }
        return result;
    }

    static void SortArrayDesc(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int temp = array[i];
            int largestNumIndex = FindLargestElementIndex(i, array);

            if (largestNumIndex > 0)
            {
                array[i] = array[largestNumIndex];
                array[largestNumIndex] = temp;
            }
        }
    }

    static void SortArrayAsc(int[] array)
    {
        SortArrayDesc(array);
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }
    }
}