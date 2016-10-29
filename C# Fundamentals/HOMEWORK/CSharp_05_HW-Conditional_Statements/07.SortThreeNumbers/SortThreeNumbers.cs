using System;

class SortThreeNumbers
{
    static void Main()
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());

        if (numOne > numTwo)
        {
            int tmpSwap = numOne;
            numOne = numTwo;
            numTwo = tmpSwap;
        }

        if (numTwo > numThree)
        {
            int tmpSwap = numTwo;
            numTwo = numThree;
            numThree = tmpSwap;
        }

        if (numOne > numTwo)
        {
            int tmpSwap = numOne;
            numOne = numTwo;
            numTwo = tmpSwap;
        }

        Console.WriteLine("{2} {1} {0}", numOne, numTwo, numThree);
    }
}