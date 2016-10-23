using System;

class Circle
{
    static void Main()
    {
        double r = Convert.ToDouble(Console.ReadLine());

        double circlePerimeter = 2 * Math.PI * r;
        double circleArea = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("{0:F2} {1:F2}", circlePerimeter, circleArea);
    }
}