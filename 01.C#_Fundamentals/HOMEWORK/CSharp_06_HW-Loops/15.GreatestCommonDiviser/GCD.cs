using System;

class GCD
{
    static void Main()
    {
        string[] inputNums = Console.ReadLine().Split(' ');
        int firstNum = int.Parse(inputNums[0]);
        int secondNum = int.Parse(inputNums[1]);

        int result = CalculateGCD(firstNum, secondNum);

        Console.WriteLine(result);
    }

    static int CalculateGCD(int a, int b)
    {
        int remainder;

        while (b != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}