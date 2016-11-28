using System;

class BitExchange
{
    static void Main()
    {
        ulong inputNum = Convert.ToUInt64(Console.ReadLine());

        ulong swapXOR = ((inputNum >> 3) ^ (inputNum >> 24)) & (1UL << 3) - 1;
        ulong result = inputNum ^ ((swapXOR << 3) | (swapXOR << 24));

        Console.WriteLine(result);
    }
}