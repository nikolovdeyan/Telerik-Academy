using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] inputArr = Console.ReadLine()
            .Split(' ')
            .Select(member => Convert.ToInt32(member))
            .ToArray();

        for (int i = 0; i < inputArr.Length; i++)
        {
            if (IsLargerThanNeighbours(inputArr, i))
            {
                Console.WriteLine(i);
                break;
            }
        }
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