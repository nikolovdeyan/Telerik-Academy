using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());

        for (int i = 1; i < inputNum + 1; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}