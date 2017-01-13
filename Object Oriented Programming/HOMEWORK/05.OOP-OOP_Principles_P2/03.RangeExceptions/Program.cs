using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int allowedRangeMin = 5;
            int allowedRangeMax = 45;
            int random;

            while (true)
            {
                Console.WriteLine("This code will throw the exception when an invalid number is drawn.");
                Console.WriteLine("New number drawn every second...");

                random = rand.Next(0,50);

                Console.WriteLine("Number drawn:> {0}", random);
                System.Threading.Thread.Sleep(1000);

                if (random > allowedRangeMax || random < allowedRangeMin)
                {
                    throw new InvalidRangeException<int>("Range exceeded!", allowedRangeMin, allowedRangeMax);
                }
                Console.Clear();
            }
        }
    }
}
