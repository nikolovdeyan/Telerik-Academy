using System;
using System.Numerics;

class Trailing0InN
{
    static void Main()
    {
        BigInteger inputNum;
        inputNum = BigInteger.Parse(Console.ReadLine());
        int result = 0;

        string factResult = (FactorialCalc(inputNum).ToString());
        for (int i = factResult.Length - 1; i > 0; i--)
        {
            if (factResult[i].ToString() == "0") {
                result += 1;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(result);
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