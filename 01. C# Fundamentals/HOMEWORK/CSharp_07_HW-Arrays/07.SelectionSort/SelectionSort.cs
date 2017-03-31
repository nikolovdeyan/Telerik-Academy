using System;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] inputArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < n; j++)
            {
                if (inputArray[j] < inputArray[min])
                {
                    min = j;
                }
            }

            int temp = inputArray[i];
            inputArray[i] = inputArray[min];
            inputArray[min] = temp;
        }
        foreach (var item in inputArray)
        {
            Console.WriteLine(item);
        }
    }
}