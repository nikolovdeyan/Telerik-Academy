using System;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        double[] inputNums = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        Console.WriteLine(CalculateMinimum(inputNums));
        Console.WriteLine(CalculateMaximum(inputNums));
        Console.WriteLine("{0:F2}", CalculateAverage(inputNums));
        Console.WriteLine(CalculateSum(inputNums));
        Console.WriteLine(CalculateProduct(inputNums));
    }

    static double CalculateMinimum(double[] inputArr)
    {
        double result = double.MaxValue;
        foreach (var item in inputArr)
        {
            if (item < result)
            {
                result = item;
            }
        }
        return result;
    }

    static double CalculateMaximum(double[] inputArr)
    {
        double result = double.MinValue;
        foreach (var item in inputArr)
        {
            if (item > result)
            {
                result = item;
            }
        }
        return result;
    }

    static double CalculateAverage(double[] inputArr)
    {
        double result = CalculateSum(inputArr) / inputArr.Length;
        return result;   
    }

    static double CalculateSum(double[] inputArr)
    {
        double result = 0;
        foreach (var item in inputArr)
        {
            result += item;
        }
        return result;
    }

    static long CalculateProduct(double[] inputArr)
    {
        long result = 1;
        foreach (var item in inputArr)
        {
            result *= (long)item;
        }
        return result;
    }
}