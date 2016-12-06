using System;
using System.Linq;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        private const int LEN = 10;

        public static void Main()
        {
            double[] numbers = ReadNumber(1, 100);
            bool isIncreasing = false;

            try
            {
                for (int i = 0; i < LEN - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        isIncreasing = true;
                    }
                    else
                    {
                        isIncreasing = false;
                        break;
                    }
                }

                if (!isIncreasing || numbers.Any(x => x < 0) || numbers.Any(x => x > 100))
                {
                    Console.WriteLine("Exception");
                }
                else
                {
                    Console.WriteLine("1 < {0} < 100", string.Join(" < ", numbers));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        private static double[] ReadNumber(int start, int end)
        {
            double[] numbers = new double[LEN];

            for (int i = 0; i < LEN; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            return numbers;
        }
    }
}
