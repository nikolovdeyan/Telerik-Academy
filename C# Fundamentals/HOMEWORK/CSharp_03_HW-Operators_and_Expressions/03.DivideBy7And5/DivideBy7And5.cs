using System;

class DivideBy7And5
{
    static void Main()
    {
        int providedNumber = Convert.ToInt32(Console.ReadLine());

        string isTrueNumber = "false";

        if ((providedNumber % 5 == 0) && (providedNumber % 7 == 0))
        {
            isTrueNumber = "true";
        }

        Console.WriteLine("{0} {1}", isTrueNumber, providedNumber);
    }
}