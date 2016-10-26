using System;

class PrimeCheck
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string isPrimeNumber = "true";

        if (n <= 1)
        {
            isPrimeNumber = "false";
        }

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                isPrimeNumber = "false";
                break;
            }
        }

        Console.WriteLine(isPrimeNumber);
    }
}