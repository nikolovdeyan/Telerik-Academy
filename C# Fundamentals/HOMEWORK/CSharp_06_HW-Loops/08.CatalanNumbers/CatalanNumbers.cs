using System;
using System.Numerics;

class NthCatalanNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(CalcCatalan(n));
    }

    static BigInteger CalcCatalan(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
            return 2 * (2 * n - 1) * CalcCatalan(n - 1) / (n + 1);
    }
}