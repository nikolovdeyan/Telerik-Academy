using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] inputArr = Console.ReadLine()
            .Split(' ')
            //.Select(member => Convert.ToInt32(member))
            .Select(int.Parse)
            .ToArray();

        int result = 0;

        for (int i = 0; i < inputArr.Length; i++)
        {
            if (IsLargerThanNeighbours(inputArr, i))
            {
                result += 1;
            }
        }
        Console.WriteLine(result);
    }

    static bool IsLargerThanNeighbours(int[] arr, int index)
    {
        bool isLarger = false;

        if (index > 0 && arr[index] > arr[index - 1] && index < arr.Length - 1 && arr[index] > arr[index + 1])
        {
            isLarger = true;
        }
        return isLarger;
    }
}