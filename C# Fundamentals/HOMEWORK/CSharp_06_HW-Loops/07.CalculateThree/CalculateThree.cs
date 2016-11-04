using System;
using System.Numerics;

class CalculateThree
{
    static void Main()
    {
        BigInteger n = int.Parse(Console.ReadLine());
        BigInteger k = int.Parse(Console.ReadLine());

        Console.WriteLine(FactorialCalc(n) / (FactorialCalc(k) * FactorialCalc(n - k)));
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