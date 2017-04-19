using System;
using System.Text;

class DecimalToHex
{
    static void Main()
    {
        long inputNum = long.Parse(Console.ReadLine());

        Console.WriteLine(Base10ToBase16(inputNum));
    }

    static string Base10ToBase16(long numBase10)
    {
        long remainder;
        StringBuilder result = new StringBuilder();

        while (numBase10 > 0)
        {
            remainder = numBase10 % 16;
            numBase10 /= 16;
            result.Insert(0, Translate(remainder));
        }
        return result.ToString();
    }

    static string Translate(long num)
    {
        string base16Digits = "0123456789ABCDEF";
        return base16Digits[(int)num].ToString();
    }
}