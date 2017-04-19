using System;

namespace _05.TriangleSurfaceThreeSides
{
    class TriangleSurfaceThreeSides
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double thirdSide = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", TriangleAreaBySides(firstSide, secondSide, thirdSide));
        }

        static double TriangleAreaBySides(double sideOne, double sideTwo, double sideThree)
        {
            double semiPerimeter = (sideOne + sideTwo + sideThree) / 2;

            // Using Heron's formula
            double result = Math.Sqrt(
                (semiPerimeter *
                (semiPerimeter - sideOne) *
                (semiPerimeter - sideTwo) *
                (semiPerimeter - sideThree)));

            return result;
        }
    }
}
