using System;

class SumOfNNumbers
{
    static void Main()
    {
        int inputNum = Convert.ToInt32(Console.ReadLine());
        double result = 0.0;

        for (int i = 1; i < inputNum + 1; i++)
        {
            result += Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine(result);
    }
}