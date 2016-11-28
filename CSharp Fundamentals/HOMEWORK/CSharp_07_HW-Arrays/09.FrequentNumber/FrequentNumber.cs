using System;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] inputArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(inputArray);

        int currentCount = 1;
        int maxCount = 1;
        int currentElement = 0;
        int maxElement = 0;

        for (int i = 0; i < n - 1; i++)
        {
            if (inputArray[i] == inputArray[i + 1])
            {
                currentCount++;
                currentElement = inputArray[i];
            }
            else
            {
                currentCount = 1;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxElement = currentElement;
            }
        }
        Console.WriteLine("{0} ({1} times)", maxElement, maxCount);
    }
}
