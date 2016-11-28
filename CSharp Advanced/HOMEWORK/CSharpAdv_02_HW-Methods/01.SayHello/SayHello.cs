using System;

class SayHello
{
    static void Main()
    {
        string name = Console.ReadLine();
        NamePrinter(name);
    }

    static void NamePrinter(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}
