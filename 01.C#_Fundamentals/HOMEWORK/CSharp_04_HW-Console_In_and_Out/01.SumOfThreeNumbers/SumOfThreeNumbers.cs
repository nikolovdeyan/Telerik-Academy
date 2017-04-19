using System;


class SumOfThreeNumbers
{
    static void Main()
    {
        double numOne = Convert.ToDouble(Console.ReadLine());
        double numTwo = Convert.ToDouble(Console.ReadLine());
        double numThree = Convert.ToDouble(Console.ReadLine());

        double result = numOne + numTwo + numThree;

        Console.WriteLine(result);
    }
}