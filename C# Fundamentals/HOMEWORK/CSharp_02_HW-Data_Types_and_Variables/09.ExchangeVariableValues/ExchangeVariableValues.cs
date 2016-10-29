using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        short a = 5;
        short b = 10;

        Console.WriteLine("The values before the exchange: \n a={0} \n b={1}", a, b);
        Console.WriteLine();

        short tmp = b;
        b = a;
        a = tmp;

        Console.WriteLine("The values after the exchange: \n a={0} \n b={1}", a, b);
    }
}