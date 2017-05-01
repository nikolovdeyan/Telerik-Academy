// <copyright file="SqrtTester.cs" company="telerikacademy.com">for educational purposes only</copyright>

/*
Write a program to compare the performance of square root, natural logarithm, sinus for float,
double and decimal values.
 */

namespace TestSqrtLogSinForFloatDoubleDecimal
{
    using System;
    using System.Diagnostics;

    /// <summary>Tests the speed of square root applied to various numeric types.</summary>
    public static class SqrtTester
    {
        /// <summary>Perform all available tests in sequence.</summary>
        public static void DoAllTests()
        {
            //// the first load of the Stopwatch object takes more time and interferes with first test, that's why
            //// we do a "purge" here
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
                        
            SqrtTester.SqrtFloatTest();
            SqrtTester.SqrtDoubleTest();
            SqrtTester.SqrtDecimalTest();
        }

        /// <summary>Tests float square root performance.</summary>
        public static void SqrtFloatTest()
        {
            float[] floats = new float[512];
            floats[0] = 1.0F;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 512; i++)
            {
                floats[i] = (float)Math.Sqrt((float)floats[i - 1]);
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Square root of floats", stopwatch.Elapsed);
        }

        /// <summary>Tests double square root performance.</summary>
        public static void SqrtDoubleTest()
        {
            double[] doubles = new double[512];
            doubles[0] = 1.0D;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 512; i++)
            {
                doubles[i] = Math.Sqrt(doubles[i - 1]);
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Square root of doubles", stopwatch.Elapsed);
        }

        /// <summary>Tests decimal square root performance.</summary>
        public static void SqrtDecimalTest()
        {
            decimal[] decimals = new decimal[512];
            decimals[0] = 1.0M;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 512; i++)
            {
                decimals[i] = (decimal)Math.Sqrt((double)decimals[i - 1]);
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Square root of decimals", stopwatch.Elapsed);
        }
    }
}
