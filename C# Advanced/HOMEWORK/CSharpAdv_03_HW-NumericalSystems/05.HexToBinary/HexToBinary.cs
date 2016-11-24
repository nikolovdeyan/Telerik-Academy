using System;
using System.Text;

class HexToBinary
{
    static void Main()
    {
        string inputNum = Console.ReadLine();

        Console.WriteLine(Base16ToBase2(inputNum));
    }

    static string Base16ToBase2(string numBase16)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < numBase16.Length; i++)
        {
            sb.Append(Translate(numBase16[i]));
        }

        string result = sb.ToString().TrimStart('0');
        result = result.Length > 0 ? result : "0";
        return result;
    }

    static string Translate(char num)
    {
        switch (num)
        {
            case '0': return "0000";
            case '1': return "0001";
            case '2': return "0010";
            case '3': return "0011";
            case '4': return "0100";
            case '5': return "0101";
            case '6': return "0110";
            case '7': return "0111";
            case '8': return "1000";
            case '9': return "1001";
            case 'A': return "1010";
            case 'B': return "1011";
            case 'C': return "1100";
            case 'D': return "1101";
            case 'E': return "1110";
            case 'F': return "1111";
            default: return "-";
        }
    }
}