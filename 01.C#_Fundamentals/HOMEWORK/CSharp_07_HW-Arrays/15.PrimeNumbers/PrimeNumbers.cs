using System;
class PrimeNumbers
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine()) + 1;

        bool[] numbers = new bool[n];

        for (int i = 2; i < n; i++)
        {
            numbers[i] = true;
        }

        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            for (int j = i * 2; j < n; j += i)
            {
                numbers[j] = false;
            }
        }

        for (long i = n - 1; i >= 0; i--)
        {
            if (numbers[i])
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}