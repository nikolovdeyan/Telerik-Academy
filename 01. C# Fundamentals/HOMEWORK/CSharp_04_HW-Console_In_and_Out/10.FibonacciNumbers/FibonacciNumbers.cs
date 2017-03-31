using System;

class FibonacciNumbers
{
    static void Main()
    {
        int inputNum = Convert.ToInt32(Console.ReadLine());

        long currentNumber = 0;
        long nextNumber = 1;

        for (int i = 0; i < inputNum; i++)
        {
            Console.Write(currentNumber);
            if (i == inputNum - 1)
            {
                break;
            }
            Console.Write(", ");
            long prevNumber = currentNumber;
            currentNumber = nextNumber;
            nextNumber += prevNumber;
        }
    }
}