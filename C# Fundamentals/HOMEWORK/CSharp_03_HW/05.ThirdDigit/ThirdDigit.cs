using System;

class ThirdDigit
{
    static void Main()
    {
        int providedNumber = Convert.ToInt32(Console.ReadLine());
        string numberString = providedNumber.ToString("D3");

        int thirdDigit = Convert.ToInt32(numberString.Substring(numberString.Length - 3, 1));

        if ((thirdDigit != 0) && (thirdDigit % 7 == 0))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirdDigit);
        }
    }
}