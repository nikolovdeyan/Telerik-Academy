using System;

class MultiplicationSign
{
    static void Main()
    {
        double numOne = double.Parse(Console.ReadLine());
        double numTwo = double.Parse(Console.ReadLine());
        double numThree = double.Parse(Console.ReadLine());

        int numNegatives = 0;
        if (numOne < 0)
            numNegatives += 1;
        if (numTwo < 0)
            numNegatives += 1;
        if (numThree < 0)
            numNegatives += 1;

        if (numOne == 0 || numTwo == 0 || numThree == 0)
        {
            Console.WriteLine("0");
        }
        else if (numNegatives == 1 || numNegatives == 3)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}