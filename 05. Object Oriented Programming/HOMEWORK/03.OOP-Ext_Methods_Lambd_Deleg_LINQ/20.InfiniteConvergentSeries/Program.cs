using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.InfiniteConvergentSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convergent series: https://en.wikipedia.org/wiki/Convergent_series
            double precision = 0.001;
            Console.WriteLine("\n1 + 1/2 + 1/4 + 1/8 + 1/16 + ... = {0:F2}\n",
                              ConvergentSum(x => 1.0 / Math.Pow(2, x), precision));

            Console.WriteLine("1 + 1/2! + 1/3! + 1/4! + 1/5! + ... = {0:F2}\n",
                              ConvergentSum(x => 1.0 / CalculateFactorial(x + 1), precision));

            Console.WriteLine("1 + 1/2 - 1/4 + 1/8 - 1/16 + ... = {0:F2}\n",
                              ConvergentSum(x => x == 0 ? 1 : -1.0 / Math.Pow(-2, x), precision));
        }

        private static double ConvergentSum(Func<int, double> termValue, double precision)
        {
            double sum = 0;
            double t = 1;

            for (int i = 0; Math.Abs(t) > precision; i++)
            {
                t = termValue(i);
                sum += t;
            }

            return sum;
        }

        private static long CalculateFactorial(int num)
        {
            if (num <= 1) return 1;
            return num * CalculateFactorial(num - 1);
        }
    }
}

