using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    public class Square : Rectangle, IShape
    {
        public Square(double side)
            :base(side, side)
        {
        }

        // The following method is not necessary. If not implemented 
        // Square.CalculateSurface() will call the base class method from 
        // Rectangle, which will calculate surface correctly.
        public override double CalculateSurface()
        {
            // Surface is calculated on Rectangle level.
            // As width and height are equal, the method is valid for squares.
            return base.CalculateSurface();
        }
    }
}
