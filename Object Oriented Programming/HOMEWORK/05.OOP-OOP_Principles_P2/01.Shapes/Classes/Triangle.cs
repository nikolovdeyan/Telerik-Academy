using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    public class Triangle : Shape, IShape
    {
        public Triangle(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double triangleSurface = this.Height * this.Width / 2;

            return triangleSurface; 
        }
    }
}
