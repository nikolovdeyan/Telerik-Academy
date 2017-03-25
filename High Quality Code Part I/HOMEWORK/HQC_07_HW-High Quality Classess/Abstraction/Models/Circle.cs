using System;

namespace Abstraction.Models
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid radius!");
                }

                this.radius = value;
            }
        }

        internal override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        internal override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }
    }
}