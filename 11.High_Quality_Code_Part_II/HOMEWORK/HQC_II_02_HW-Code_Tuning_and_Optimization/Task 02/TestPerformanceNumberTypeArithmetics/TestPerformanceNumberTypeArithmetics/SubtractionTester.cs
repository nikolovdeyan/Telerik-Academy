namespace TestPerformanceNumberTypeArithmetics
{
    using System;
    using System.Diagnostics;

    /// <summary>Tests the speed of subtraction applied to various numeric types.</summary>
    public static class SubtractionTester
    {
        /// <summary>Perform all available tests in sequence.</summary>
        public static void DoAllTests()
        {
            //// the first load of the Stopwatch object takes more time and interferes with first test, that's why
            //// we do a "purge" here
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            SubtractionTester.SubtractIntegersTest();
            SubtractionTester.SubtractLongTest();
            SubtractionTester.SubtractFloatTest();
            SubtractionTester.SubtractDoubleTest();
            SubtractionTester.SubtractDecimalTest();
        }

        /// <summary>Tests integer subtraction performance.</summary>
        public static void SubtractIntegersTest()
        {
            int[] integers = new int[1024];
            integers[0] = 0;
            Stopwatch stopwatch = new Stopwatch();            
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                integers[i] = integers[i - 1] - 1;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Subtraction of integers", stopwatch.Elapsed);
        }

        /// <summary>Tests long subtraction performance.</summary>
        public static void SubtractLongTest()
        {
            long[] longs = new long[1024];
            longs[0] = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                longs[i] = longs[i - 1] - 1;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Subtraction of longs", stopwatch.Elapsed);
        }

        /// <summary>Tests float subtraction performance.</summary>
        public static void SubtractFloatTest()
        {
            float[] floats = new float[1024];
            floats[0] = 0.0F;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                floats[i] = floats[i - 1] - 1.0F;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Subtraction of floats", stopwatch.Elapsed);
        }

        /// <summary>Tests double subtraction performance.</summary>
        public static void SubtractDoubleTest()
        {
            double[] doubles = new double[1024];
            doubles[0] = 0.0D;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                doubles[i] = doubles[i - 1] - 1.0D;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Subtraction of doubles", stopwatch.Elapsed);
        }

        /// <summary>Tests decimal subtraction performance.</summary>
        public static void SubtractDecimalTest()
        {
            decimal[] decimals = new decimal[1024];
            decimals[0] = 0.0M;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                decimals[i] = decimals[i - 1] - 1.0M;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Subtraction of decimals", stopwatch.Elapsed);
        }
    }
}
