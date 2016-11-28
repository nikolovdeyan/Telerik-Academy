using System;

class HexToDecimal
{
    static void Main()
    {
        string inputNum = Console.ReadLine();

        Console.WriteLine(Base16ToBase10(inputNum));
    }

    static long Base16ToBase10(string numBase16)
    {
        long result = 0;

        for (int i = 0; i < numBase16.Length; i++)
        {
            result += Translate(numBase16[i]) * (long)Math.Pow(16, numBase16.Length - 1 - i);
        }

        return result;
    }

    static int Translate(char num)
    {          
            switch (num)
        {
            case '0': return 0;
            case '1': return 1;
            case '2': return 2;
            case '3': return 3;
            case '4': return 4;
            case '5': return 5;
            case '6': return 6;
            case '7': return 7;
            case '8': return 8;
            case '9': return 9;
            case 'A': return 10;
            case 'B': return 11;
            case 'C': return 12;
            case 'D': return 13;
            case 'E': return 14;
            case 'F': return 15;
            default: return -1;
        }
    }
}