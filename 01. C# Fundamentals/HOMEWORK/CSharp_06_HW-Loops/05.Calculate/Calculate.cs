using System;

class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double s = 1;

        for (int i = n; i > 0; i--)
        {
            s += FactorialCalc(i) / (Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}", s);
    }

    static double FactorialCalc(int n)
    {
        if (n == 0)
            return 1;
        double result = 1;
        for (int i = n; i > 0; i--)
        {
            result *= i;
        }
        return result;
    }
}