using System;

class Program
{
    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;

            while (numbers[right] > pivot)
                right--;


            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSort_Recursive(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            if (pivot > 1)
                QuickSort_Recursive(arr, left, pivot - 1);

            if (pivot + 1 < right)
                QuickSort_Recursive(arr, pivot + 1, right);
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] inputArray = new int[n];
        for (int i = 0; i < inputArray.Length; i++)
            inputArray[i] = int.Parse(Console.ReadLine());

        QuickSort_Recursive(inputArray, 0, inputArray.Length - 1);

        foreach (int num in inputArray)
                Console.WriteLine(num);
    }
}
