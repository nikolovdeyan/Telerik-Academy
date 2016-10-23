using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        int result = 0;
        for (int i = 0; i < 5; i++)
        {
            result += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(result);
    }
}