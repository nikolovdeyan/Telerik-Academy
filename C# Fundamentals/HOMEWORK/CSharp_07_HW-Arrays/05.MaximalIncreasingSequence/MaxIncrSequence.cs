using System;

class MaxIncrSequence
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        int[] numSequence = new int[inputNum];

        int maxSequence = 1;
        int currentSequence = 0;
        int prevNumber = 0;

        for (int i = 0; i < inputNum; i++)
        {
            numSequence[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numSequence.Length - 1; i++)
        {
            if (numSequence[i] > prevNumber)
            {
                currentSequence += 1;
            }
            else
            {
                currentSequence = 1;
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }
            prevNumber = numSequence[i];
        }
        Console.WriteLine(maxSequence);
    }
}