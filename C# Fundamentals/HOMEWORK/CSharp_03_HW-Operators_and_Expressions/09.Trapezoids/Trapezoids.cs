using System;

class Trapezoids
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());

        double trapezoidArea = 0.5D * (a + b) * h;

        Console.WriteLine("{0:F7}", trapezoidArea);
    }
}