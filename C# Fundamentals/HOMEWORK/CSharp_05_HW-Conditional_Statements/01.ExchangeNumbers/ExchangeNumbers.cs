using System;

class ExchangeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("{0} {1}", Math.Min(a, b), Math.Max(a, b));
    }
}