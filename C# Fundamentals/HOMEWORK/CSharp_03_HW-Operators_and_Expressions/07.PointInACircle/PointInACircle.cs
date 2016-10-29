using System;

class PointInACircle
{
    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        double distancePoint = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        if (distancePoint <= 2)
        {
            Console.WriteLine("yes {0:f2}", distancePoint);
        }
        else
        {
            Console.WriteLine("no {0:f2}", distancePoint);
        }
    }
}