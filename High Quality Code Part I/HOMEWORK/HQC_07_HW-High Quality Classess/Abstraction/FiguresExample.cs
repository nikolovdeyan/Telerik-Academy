using Abstraction.Models;
using System;

namespace Abstraction
{
    public class FiguresExample
    {
        public static void Main()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            Console.WriteLine(circle);
            Console.WriteLine("I am a circle. My perimeter is {0:f2}. My surface is {1:f2}.", circle.CalcPerimeter(), circle.CalcSurface());

            double width = 2;
            double height = 3;
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("I am a rectangle. My perimeter is {0:f2}. My surface is {1:f2}.", rectangle.CalcPerimeter(), rectangle.CalcSurface());
        }
    }
}