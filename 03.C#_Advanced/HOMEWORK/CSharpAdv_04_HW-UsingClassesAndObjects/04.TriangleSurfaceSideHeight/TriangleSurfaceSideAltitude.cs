using System;

namespace _04.TriangleSurfaceSideAltitude
{
    class TriangleSurfaceSideAltitude
    {
        static void Main(string[] args)
        {
            double inputSide = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", TriangleAreaByAltitude(inputSide, altitude));
        }

        static double TriangleAreaByAltitude(double side, double altitude)
        {
            double result = side * altitude / 2;

            return result;
        }
    }
}
