using System;

class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? nullableInteger = null;
        double? nullableDouble = null;

        Console.WriteLine("Printing the nullableInteger: {0}\nand the nullableDouble: {1}", nullableInteger, nullableDouble);
    }
}