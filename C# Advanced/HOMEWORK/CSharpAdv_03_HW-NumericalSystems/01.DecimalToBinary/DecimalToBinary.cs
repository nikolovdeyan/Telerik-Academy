using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        long inputNum = long.Parse(Console.ReadLine());

        Console.WriteLine(Base10ToBase2(inputNum));
    }

    static string Base10ToBase2(long numBase10)
    {
        long remainder;
        StringBuilder result = new StringBuilder();

        while (numBase10 > 0)
        {
            remainder = numBase10 % 2;
            numBase10 /= 2;
            result.Insert(0, remainder);
        }
        return result.ToString();
    }
}
