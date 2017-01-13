using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Tests
    {
        static void Main(string[] args)
        {
            // Create different shapes and store them in an array.
            Shape[] myShapeArr = new Shape[]
            {
                new Rectangle(5, 4),
                new Square (3),
                new Triangle (1, 2.5),
                new Triangle (2, 1.25),
                new Square (2.375),
                new Rectangle(1, 12),
                new Rectangle(0.45, 2.333),
                new Triangle (12, 15.123)
            };

            // Test the CalculateSurface() on the created array.
            foreach (var shape in myShapeArr)
            {
                Console.WriteLine("Hello! I am a {0} and my area is {1:F2}!",shape.GetType().Name, 
                                                                             shape.CalculateSurface());
            }
        }
    }
}
