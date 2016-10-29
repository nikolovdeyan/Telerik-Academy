using System;

class FourDigits
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        int numFirst = Convert.ToInt32(inputNumber.Substring(0, 1));
        int numSecond = Convert.ToInt32(inputNumber.Substring(1, 1));
        int numThird = Convert.ToInt32(inputNumber.Substring(2, 1));
        int numFourth = Convert.ToInt32(inputNumber.Substring(3, 1));

        Console.WriteLine(numFirst + numSecond + numThird + numFourth);
        Console.WriteLine("{3}{2}{1}{0}", numFirst, numSecond, numThird, numFourth);
        Console.WriteLine("{3}{0}{1}{2}", numFirst, numSecond, numThird, numFourth);
        Console.WriteLine("{0}{2}{1}{3}", numFirst, numSecond, numThird, numFourth);
    }
}