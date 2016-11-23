using System;

class AppearanceCount
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        string[] inputArrString = Console.ReadLine().Split(' ');
        string numSought = Console.ReadLine();

        Console.WriteLine(NumFrequency(inputArrString, numSought));
    }

    static int NumFrequency(string[] inputArr, string numSought)
    {
        int result = 0;
        foreach (string member in inputArr)
        {
            if (member == numSought)
            {
                result += 1;
            }
        }
        return result;
    }
}