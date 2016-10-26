using System;

class nthBit
{
    static void Main()
    {
        ulong inputNum = Convert.ToUInt64(Console.ReadLine());
        int bitPos = Convert.ToInt32(Console.ReadLine());
        int bitValue = Convert.ToInt32(Console.ReadLine());

        int soughtBit = (int)(inputNum & (1UL << bitPos));
        ulong result = inputNum;

        if (soughtBit != bitValue)
        {
            result = (bitValue == 1) ? (inputNum | (1UL << bitPos)) : (inputNum ^ (1UL << bitPos));
        }

        Console.WriteLine(result);
    }
}
