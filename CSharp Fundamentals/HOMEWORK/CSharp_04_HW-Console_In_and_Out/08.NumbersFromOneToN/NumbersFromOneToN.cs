using System;

class NumbersFromOneToN
{
    static void Main()
    {
        int inputNum = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        for (int i = 1; i < inputNum + 1; i++)
        {
            Console.WriteLine(i);
        }
    }
}