using System;
using System.Text;

class MixingNumbers
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        StringBuilder mixedNums = new StringBuilder();
        StringBuilder subtrNums = new StringBuilder();

        for (int i = 1; i < numbers.Length; i++)
        {
            int mixerFirst = numbers[i - 1] % 10;
            int mixerSecond = numbers[i] / 10;
            mixedNums.Append(mixerFirst * mixerSecond).Append(" ");
        }
        for (int i = 1; i < numbers.Length; i++)
        {
            int diff = Math.Abs(numbers[i] - numbers[i - 1]);
            subtrNums.Append(diff).Append(" ");
        }

        Console.WriteLine(string.Join(" ", mixedNums));
        Console.WriteLine(string.Join(" ", subtrNums));
    }
}