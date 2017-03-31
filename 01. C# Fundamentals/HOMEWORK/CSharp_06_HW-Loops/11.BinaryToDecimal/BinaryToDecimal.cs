using System;

class BinaryToDecimal
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        double result = 0;
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            if (inputString[i] == '1')
            {
                result += Math.Pow(2, inputString.Length - 1 - i);
            }
        }
        Console.WriteLine(result);
    }
}




