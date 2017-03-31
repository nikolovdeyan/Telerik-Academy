using System;

class UnicodeCharacter
{
    static void Main(string[] args)
    {
        char characterVariable = '\u002A';

        Console.WriteLine("The Unicode symbol with code '\\u002A' is: {0}", characterVariable);
    }
}