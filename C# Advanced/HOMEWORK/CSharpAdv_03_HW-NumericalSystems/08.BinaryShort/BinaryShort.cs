using System;

class BinaryShort
{
    static void Main()
    {
        short inputNum = short.Parse(Console.ReadLine());
        string result = string.Empty;

        for (int i = 0; i < 16; i++)
        {
            string bitAtPos = ((inputNum >> i) & 1).ToString();

            result = bitAtPos + result;
        }

        Console.WriteLine(result);
    }
} 

