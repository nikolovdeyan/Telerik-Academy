using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        double eps = 0.000001;

        //Console.WriteLine("Please provide first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        //Console.WriteLine("Please provide second number:");
        double secondNumber = double.Parse(Console.ReadLine());

        bool equalAB = Math.Abs(firstNumber - secondNumber) < eps;

        if (equalAB)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}