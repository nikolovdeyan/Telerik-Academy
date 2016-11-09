using System;

class AllocateArray
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        int[] taskArray = new int[inputNum];

        for (int i = 0; i < inputNum; i++)
        {
            taskArray[i] = i;
        }

        foreach (int j in taskArray)
        {
            Console.WriteLine(j * 5);
        }
    }
}