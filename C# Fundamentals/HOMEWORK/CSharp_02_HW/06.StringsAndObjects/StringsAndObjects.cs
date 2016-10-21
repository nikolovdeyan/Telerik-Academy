using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string firstStringVariable = "Hello";
        string secondStringVariable = "World";

        object concatenatedStrings = firstStringVariable + " " +secondStringVariable;

        string resultStringVariable = (string)concatenatedStrings;

        Console.WriteLine(resultStringVariable);
    }
}