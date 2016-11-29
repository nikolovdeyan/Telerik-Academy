using System;

class NotDivisibleNumbers
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());

        for (int i = 1; i < inputNum + 1; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.Write("{0} ", i);
            }
        }
    }
}