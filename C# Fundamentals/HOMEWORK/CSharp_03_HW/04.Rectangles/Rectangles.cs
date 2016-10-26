using System;

class Rectangles
{
    static void Main()
    {
        double rectWidth = Convert.ToDouble(Console.ReadLine());
        double rectHeight = Convert.ToDouble(Console.ReadLine());

        double rectArea = rectWidth * rectHeight;
        double rectPerimeter = (rectHeight + rectWidth) * 2;

        Console.WriteLine("{0:F2} {1:F2}", rectArea, rectPerimeter);
    }
}