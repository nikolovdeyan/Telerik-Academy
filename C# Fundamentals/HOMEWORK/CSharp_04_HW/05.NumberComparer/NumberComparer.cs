using System;


class NumberComparer
{
    static void Main()
    {
        double firstNum = Convert.ToDouble(Console.ReadLine());
        double secondNum = Convert.ToDouble(Console.ReadLine());

        double result = (firstNum > secondNum) ? firstNum : secondNum;

        Console.WriteLine(result);
    }
}