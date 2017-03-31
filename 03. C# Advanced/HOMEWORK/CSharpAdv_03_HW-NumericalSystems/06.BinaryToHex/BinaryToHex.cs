using System;
using System.Text;

class BinaryToHex
{
    static void Main()
    {
        string inputNum = Console.ReadLine();

        Console.WriteLine(Base2ToBase16(inputNum));
    }

    static string Base2ToBase16(string numBase2)
    {
        // normalize input for missing leading zeros
        while (numBase2.Length % 4 != 0)
        {
            numBase2 = "0" + numBase2;
        }

        StringBuilder result = new StringBuilder();  

        // pass chunks of four to the Translate() function to convert to Hex
        for (int i = 0; i < numBase2.Length; i += 4)
        {
            result.Append(Translate(numBase2.Substring(i, 4)));
        }

        return result.ToString();
    }

    static string Translate(string num)
    {
        switch (num)
        {
            case "0000": return "0" ;
            case "0001": return "1" ;
            case "0010": return "2" ;
            case "0011": return "3" ;
            case "0100": return "4" ;
            case "0101": return "5" ;
            case "0110": return "6" ;
            case "0111": return "7" ;
            case "1000": return "8" ;
            case "1001": return "9" ;
            case "1010": return "A" ;
            case "1011": return "B" ;
            case "1100": return "C" ;
            case "1101": return "D" ;
            case "1110": return "E" ;
            case "1111": return "F" ;
            default: return "-";
        }
    }
}