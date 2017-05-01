namespace TestPerformanceNumberTypeArithmetics
{
    using System;
    using System.Diagnostics;

    public static class IncrementTester
    {
        public static void DoAllTests()
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            IncrementTester.IncrementIntegersTest();
            IncrementTester.IncrementLongTest();
            IncrementTester.IncrementFloatTest();
            IncrementTester.IncrementDoubleTest();
            IncrementTester.IncrementDecimalTest();
        }

        public static void IncrementIntegersTest()
        {
            int[] integers = new int[1024];
            integers[0] = 1;
            Stopwatch stopwatch = new Stopwatch();            
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                integers[i] += integers[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of integers", stopwatch.Elapsed);
        }

        public static void IncrementLongTest()
        {
            long[] longs = new long[1024];
            longs[0] = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                longs[i] += longs[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of longs", stopwatch.Elapsed);
        }

        public static void IncrementFloatTest()
        {
            float[] floats = new float[1024];
            floats[0] = 1.0F;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                floats[i] += floats[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of floats", stopwatch.Elapsed);
        }

        public static void IncrementDoubleTest()
        {
            double[] doubles = new double[1024];
            doubles[0] = 1.0D;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                doubles[i] += doubles[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of doubles", stopwatch.Elapsed);
        }

        public static void IncrementDecimalTest()
        {
            decimal[] decimals = new decimal[1024];
            decimals[0] = 1.0M;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                decimals[i] += decimals[i - 1];
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Increment of decimals", stopwatch.Elapsed);
        }
    }
}
