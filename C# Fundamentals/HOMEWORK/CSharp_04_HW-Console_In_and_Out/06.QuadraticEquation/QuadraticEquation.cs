using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double x1 = (-b + (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);
        double x2 = (-b - (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);

        if (double.IsNaN(x1) || double.IsNaN(x2))
        {
            Console.WriteLine("no real roots");
        }
        else if (x1 == x2)
        {
            Console.WriteLine("{0:F2}", x1);
        }
        else
        {
            Console.WriteLine("{0:F2}", x1 < x2 ? x1 : x2);
            Console.WriteLine("{0:F2}", x1 > x2 ? x1 : x2);
        }
    }
}