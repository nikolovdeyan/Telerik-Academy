using System;

class OddOrEven
{
    static void Main()
    {
        int providedNumber = Convert.ToInt32(Console.ReadLine());
        string resultOddEven = "odd";

        if (providedNumber % 2 == 0)
        {
            resultOddEven = "even";
        }

        Console.WriteLine("{0} {1}", resultOddEven, providedNumber);

    }
}