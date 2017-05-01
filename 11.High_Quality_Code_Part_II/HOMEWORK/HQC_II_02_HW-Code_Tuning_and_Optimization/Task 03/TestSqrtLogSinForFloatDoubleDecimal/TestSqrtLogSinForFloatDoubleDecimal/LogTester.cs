// <copyright file="LogTester.cs" company="telerikacademy.com">for educational purposes only</copyright>

/*
Write a program to compare the performance of square root, natural logarithm, sinus for float,
double and decimal values.
 */

namespace TestSqrtLogSinForFloatDoubleDecimal
{
    using System;
    using System.Diagnostics;

    /// <summary>Tests the speed of natural logarithm applied to various numeric types.</summary>
    public static class LogTester
    {
        /// <summary>Perform all available tests in sequence.</summary>
        public static void DoAllTests()
        {
            //// the first load of the Stopwatch object takes more time and interferes with first test, that's why
            //// we do a "purge" here
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
                        
            LogTester.LogFloatTest();
            LogTester.LogDoubleTest();
            LogTester.LogDecimalTest();
        }

        /// <summary>Tests float natural logarithm performance.</summary>
        public static void LogFloatTest()
        {
            float[] floats = new float[512];
            floats[0] = 1.0F;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 512; i++)
            {                
                try 
                {
                floats[i] = (float)Math.Log((float)floats[i - 1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Crashed with floats!");
                    break;
                }           
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Natural logarithm of floats", stopwatch.Elapsed);
        }

        /// <summary>Tests double natural logarithm performance.</summary>
        public static void LogDoubleTest()
        {
            double[] doubles = new double[512];
            doubles[0] = 1.0D;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 512; i++)
            {
                try
                {
                doubles[i] = Math.Log(doubles[i - 1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Crashed with doubles!");
                    break;
                }                
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Natural logarithm of doubles", stopwatch.Elapsed);
        }

        /// <summary>Tests decimal natural logarithm performance.</summary>
        public static void LogDecimalTest()
        {
            decimal[] decimals = new decimal[512];
            decimals[0] = 1.0M;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 512; i++)
            {
                try
                {
                    decimals[i] = (decimal)Math.Log((double)decimals[i - 1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Crashed with decimals!");
                    break;
                }                
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Natural logarithm of decimals", stopwatch.Elapsed);
        }
    }
}
