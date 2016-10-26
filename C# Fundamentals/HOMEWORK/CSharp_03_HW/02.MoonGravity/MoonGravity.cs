using System;

class MoonGravity
{
    static void Main()
    {
        double weightEarth = Convert.ToDouble(Console.ReadLine());

        double weightMoon = weightEarth * 0.17;

        Console.WriteLine("{0:F3}", weightMoon);
    }
}