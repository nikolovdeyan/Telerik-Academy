using System;
using System.Linq;

namespace Statistics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] input = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };

            PrintStatistic(input);
        }

        /// <summary>Displays some basic statistical variables calculated for the provided <paramref name="sample"/>.</summary>
        /// <param name="sample">A statistical sample of the observed population.</param>
        /// <param name="stop">Optional stop for the operaion. Elements with indices after <paramref name="stop"/> will not be considered in the calculation.</param>
        public static void PrintStatistic(double[] sample, int stop = 0)
        {
            // If no stop is provided, the sample array length becomes the stop
            int count = (stop == 0) ? sample.Length : stop;

            double max = GetMaxFromSample(sample, count);
            double min = GetMinFromSample(sample, count);
            double avg = GetAverageFromSample(sample, count);

            Console.WriteLine("Maximum value for observed sample: {0}", max);
            Console.WriteLine("Minimum value for observed sample: {0}", min);
            Console.WriteLine("Average value for observed sample: {0}", avg);
            Console.WriteLine("Length of the provided sample: {0}", count);
            Console.WriteLine("Stop used: {0}", (stop == 0) ? "No" : "Yes");
        }

        private static double GetMaxFromSample(double[] sample, int count)
        {
            double maxOfSubset = sample.Min();

            for (int i = 0; i < count; i++)
            {
                if (sample[i] > maxOfSubset)
                {
                    maxOfSubset = sample[i];
                }
            }

            return maxOfSubset;
        }

        private static double GetMinFromSample(double[] sample, int count)
        {
            double minOfSubset = sample.Max();

            for (int i = 0; i < count; i++)
            {
                if (sample[i] < minOfSubset)
                {
                    minOfSubset = sample[i];
                }
            }

            return minOfSubset;
        }

        private static double GetAverageFromSample(double[] sample, int count)
        {
            double sumOfSubset = 0;
            double avgOfSubset;

            for (int i = 0; i < count; i++)
            {
                sumOfSubset += sample[i];
            }

            avgOfSubset = sumOfSubset / count;

            return avgOfSubset;
        }
    }
}