using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine(FactorialCalc(n) / FactorialCalc(k));
    }

    static BigInteger FactorialCalc(BigInteger n)
    {
        if (n == 0)
            return 1;
        BigInteger result = 1;
        for (BigInteger i = n; i > 0; i--)
        {
            result *= i;
        }
        return result;
    }
}