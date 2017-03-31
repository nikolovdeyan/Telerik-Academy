using System;
class BiggestOfThree
{
    static void Main()
    {
        double[] numsArr = new double[3];
        for (int i=0; i<3; i++)
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

