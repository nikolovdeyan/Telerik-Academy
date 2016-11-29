using System;


class BitSwap
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        for (int i = p; i <= ((p + k) - 1); i++)
        {
            uint mask = 1U;

            uint bitP = ((mask << i) & n) >> i;
            uint bitQ = ((mask << q) & n) >> q;

            n = n & ~(mask << i);
            n = n & ~(mask << q);
            n = n | (bitP << q);
            n = n | (bitQ << i);

            q++;

        }

        Console.WriteLine(n);
    }
}