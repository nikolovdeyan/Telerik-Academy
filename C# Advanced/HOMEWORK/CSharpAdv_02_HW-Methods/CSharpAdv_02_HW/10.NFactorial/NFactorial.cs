using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        BigInteger result = CalculateFactorial(inputNum);

        Console.WriteLine(result);
    }

    static BigInteger CalculateFactorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        return number * CalculateFactorial(number - 1);
    }
}