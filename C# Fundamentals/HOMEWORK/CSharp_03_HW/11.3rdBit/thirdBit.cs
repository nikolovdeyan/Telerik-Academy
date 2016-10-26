using System;

class thirdBit
{
    static void Main()
    {
        uint inputNumber = Convert.ToUInt32(Console.ReadLine());
        uint bit = (uint)((((inputNumber >> 3) % 2) == 1) ? 1 : 0);
        
        Console.WriteLine(bit);
    }
}