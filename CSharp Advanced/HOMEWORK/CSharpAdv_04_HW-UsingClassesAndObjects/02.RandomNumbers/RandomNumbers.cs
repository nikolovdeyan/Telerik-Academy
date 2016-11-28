using System;

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating 10 random numbers (100-200 range)");

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(100, 200));
            }
        }
    }
}
