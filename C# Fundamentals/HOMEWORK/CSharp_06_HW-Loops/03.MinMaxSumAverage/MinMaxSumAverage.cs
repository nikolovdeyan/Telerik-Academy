using System;

class MinMaxSumAverage
{
    static void Main()
    {
        double min = int.MaxValue;
        double max = int.MinValue;
        double sum = 0;
        double avg = 0;

        int arrLength = int.Parse(Console.ReadLine());

        for (int i = 0; i < arrLength; i++)
        {
            double inputNum = double.Parse(Console.ReadLine());
            min = Math.Min(min, inputNum);
            max = Math.Max(max, inputNum);
            sum += inputNum;
        }

        avg = sum / arrLength;
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}