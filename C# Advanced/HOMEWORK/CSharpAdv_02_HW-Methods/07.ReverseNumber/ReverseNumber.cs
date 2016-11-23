using System;
using System.Text;

class ReverseNumber
{
    static void Main()
    {
        string inputNum = Console.ReadLine();

        Console.WriteLine(Reverser(inputNum));
    }

    static string Reverser(string reversee)
    {
        StringBuilder result = new StringBuilder();

        for (int ch = reversee.Length - 1; ch >= 0; ch--)
        {
            result.Append(reversee[ch]);
        }

        return result.ToString();
    }
}