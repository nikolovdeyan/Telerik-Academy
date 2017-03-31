using System;

class HexToDecimal
{
    static void Main()
    {
        string inputHex = Console.ReadLine();
        long outputDecimal = 0;

        for (int i = inputHex.Length - 1; i >= 0; i--)
        {
            switch (inputHex[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    outputDecimal += (long.Parse(inputHex[i].ToString())) * (long)Math.Pow(16, inputHex.Length - 1 - i);
                    break;
                case 'A':
                    outputDecimal += 10 * (long)Math.Pow(16, inputHex.Length - 1 - i);
                    break;
                case 'B':
                    outputDecimal += 11 * (long)Math.Pow(16, inputHex.Length - 1 - i);
                    break;
                case 'C':
                    outputDecimal += 12 * (long)Math.Pow(16, inputHex.Length - 1 - i);
                    break;
                case 'D':
                    outputDecimal += 13 * (long)Math.Pow(16, inputHex.Length - 1 - i);
                    break;
                case 'E':
                    outputDecimal += 14 * (long)Math.Pow(16, inputHex.Length - 1 - i);
                    break;
                case 'F':
                    outputDecimal += 15 * (long)Math.Pow(16, inputHex.Length - 1 - i);
                    break;
            }
        }
        Console.WriteLine(outputDecimal);
    }
}