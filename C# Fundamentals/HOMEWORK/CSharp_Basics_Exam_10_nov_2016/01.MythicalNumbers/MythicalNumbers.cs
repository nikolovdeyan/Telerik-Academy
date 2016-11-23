using System;

class MythicalNumbers
{
    static void Main()
    {
        string inputNum = Console.ReadLine();

        int num1 = int.Parse(inputNum.Substring(0, 1));
        int num2 = int.Parse(inputNum.Substring(1, 1));
        int num3 = int.Parse(inputNum.Substring(2, 1));

        double result = 0;

        if (num3 == 0)
        {
            result = num1 * num2;
        }
        else if (num3 > 0 && num3 <= 5)
        {
            result = (double)num1 * num2 / num3;
        }
        else if (num3 > 5)
        {
            result = (num1 + num2) * num3;
        }

        Console.WriteLine("{0:F2}", result);
    }
}
