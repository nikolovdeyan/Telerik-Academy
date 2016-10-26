using System;

class PointCircleRectangle
{
    static void Main()
    {
        double circleX = 1.0;
        double circleY = 1.0;
        double circleR = 1.5;

        double rectTop = 1.0;
        double rectLeft = -1.0;
        double rectBottom = -1.0;
        double rectRight = 5.0;

        string pointToCircle = "inside";
        string pointToRect = "inside";

        double pointX = Convert.ToDouble(Console.ReadLine());
        double pointY = Convert.ToDouble(Console.ReadLine());

        double pointDistCircle = Math.Sqrt(Math.Pow((pointX + (0 - circleX)), 2) + Math.Pow((pointY + (0 - circleY)), 2));
        if (pointDistCircle > circleR)
        {
            pointToCircle = "outside";          
        }

        if (((pointX < rectLeft) || (pointX > rectRight)) || ((pointY < rectBottom) || (pointY > rectTop)))
        {
            pointToRect = "outside";
        }

        Console.WriteLine("{0} circle {1} rectangle", pointToCircle, pointToRect);
    }
}