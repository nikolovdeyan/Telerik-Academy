using System;

class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        char copyrightSymbol = '\u00A9';

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("   {0}", copyrightSymbol);
        Console.WriteLine();
        Console.WriteLine("  {0} {0}", copyrightSymbol);
        Console.WriteLine();
        Console.WriteLine(" {0}   {0}", copyrightSymbol);
        Console.WriteLine();
        Console.WriteLine("{0} {0} {0} {0}", copyrightSymbol);
        Console.WriteLine();
    }
}