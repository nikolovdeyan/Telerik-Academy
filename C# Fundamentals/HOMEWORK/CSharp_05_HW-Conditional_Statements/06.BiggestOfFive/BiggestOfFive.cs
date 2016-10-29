using System;

class BiggestOfFive
{
    static void Main()
    {
        double[] numsArr = new double[5];
        for (int i = 0; i < 5; i++)
        {
            numsArr[i] = double.Parse(Console.ReadLine());
        }

        double largestNum = numsArr[0];
        foreach (double num in numsArr)
        {
            if (num > largestNum)
            {
                largestNum = num;
            }
        }
        Console.WriteLine(largestNum);
    }
}