using System;
using System.Text;

class DecimalToHex
{
    static void Main()
    {
        long inputDecimal = long.Parse(Console.ReadLine());
        StringBuilder outputHex = new StringBuilder();

        while (inputDecimal > 0)
        {
            switch (inputDecimal % 16)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: outputHex.Append(inputDecimal % 16); break;
                case 10: outputHex.Append("A"); break;
                case 11: outputHex.Append("B"); break;
                case 12: outputHex.Append("C"); break;
                case 13: outputHex.Append("D"); break;
                case 14: outputHex.Append("E"); break;
                case 15: outputHex.Append("F"); break;
            }
            inputDecimal /= 16;
        }

        StringBuilder result = new StringBuilder();
        for (int i = outputHex.Length - 1; i >= 0; i--)
        {
            result.Append(outputHex[i]);
        }
        Console.WriteLine(result);
    }
}

