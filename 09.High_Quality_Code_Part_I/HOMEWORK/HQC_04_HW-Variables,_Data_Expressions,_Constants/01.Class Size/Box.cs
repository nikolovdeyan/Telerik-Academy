using System;

namespace Shapes
{
    public class Box
    {
        private double width;
        private double height;

        public Box(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Box GetRotatedBox(Box box, double rotationAngle)
        {
            // xPrime = x cos f - y sin f
            // yPrime = y cos f + x sin f
            double xPrime = (Math.Abs(Math.Cos(rotationAngle)) * box.width) + (Math.Abs(Math.Sin(rotationAngle)) * box.height);
            double yPrime = (Math.Abs(Math.Sin(rotationAngle)) * box.width) + (Math.Abs(Math.Cos(rotationAngle)) * box.height);
            return new Box(xPrime, yPrime);
        }
    }
}