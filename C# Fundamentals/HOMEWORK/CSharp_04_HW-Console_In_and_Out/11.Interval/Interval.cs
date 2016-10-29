using System;

class Interval
{
    static void Main()
    {
        int numFrom = Convert.ToInt32(Console.ReadLine());
        int numTo = Convert.ToInt32(Console.ReadLine());

        int result = 0;

        for (int i = numFrom + 1; i < numTo; i++)
        {
            result += (i % 5 == 0) ? 1 : 0;
        }

        Console.WriteLine(result);
    }
}