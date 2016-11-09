using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] inputArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = inputArray[0];
        int maxSum = inputArray[0];
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < n; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += inputArray[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                endIndex = i;
            }
        }
        Console.WriteLine(maxSum);
    }
}