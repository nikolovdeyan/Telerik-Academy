using System;

namespace _06.TriangleSurfaceSidesAngle
{
    class TriangleSurfaceSidesAngle
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", TriangleAreaBySidesAndAngle(firstSide, secondSide, angle));
        }

        static double TriangleAreaBySidesAndAngle(double sideOne, double sideTwo, double angle)
        {
            double area = sideOne * sideTwo * Math.Sin(ConvertToRadians(angle)) / 2;

            return area;
        }

        static double ConvertToRadians(double angle)
        {
            double angleInRadians = (Math.PI / 180) * angle;

            return angleInRadians;
        }
    }
}