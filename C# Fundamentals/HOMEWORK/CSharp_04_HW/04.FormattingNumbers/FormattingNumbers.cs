using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("{0,-10:X}|{1,10:}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a, 2).PadLeft(8, '0'), b, c);
    }
}