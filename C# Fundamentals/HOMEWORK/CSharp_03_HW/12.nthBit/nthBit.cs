using System;

class nthBit
{
    static void Main()
    {
        ulong inputNum = Convert.ToUInt64(Console.ReadLine());
        int inputPos = Convert.ToInt32(Console.ReadLine());

        ulong mask = 1UL << inputPos;
        ulong result = (inputNum & mask) >> inputPos;


        Console.WriteLine(result);
    }
}

