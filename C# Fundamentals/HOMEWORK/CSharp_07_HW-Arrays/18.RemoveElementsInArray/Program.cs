using System;

class RemoveElementsInArray
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] inputArray = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            inputArray[i] = (int.Parse(Console.ReadLine()));
        }
        var outputArray = new int[arraySize];
        int result = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            result = 0;

            for (int fromNum = 0; fromNum < i; fromNum++)
            {
                if (inputArray[i] >= inputArray[fromNum])
                {
                    if (outputArray[fromNum] > result)
                    {
                        result = outputArray[fromNum];
                    }
                }
            }

            outputArray[i] = result + 1;
        }

        result = 0;

        for (int i = 0; i < arraySize; i++)
        {
            if (outputArray[i] > result)
            {
                result = outputArray[i];
            }
        }

        Console.WriteLine(arraySize - result);
    }
}