namespace TestPerformanceNumberTypeArithmetics
{
    using System;
    using System.Diagnostics;

    public static class MultiplicationTester
    {
        public static void DoAllTests()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            MultiplicationTester.MultiplyIntegersTest();
            MultiplicationTester.MultiplyLongTest();
            MultiplicationTester.MultiplyFloatTest();
            MultiplicationTester.MultiplyDoubleTest();
            MultiplicationTester.MultiplyDecimalTest();
        }

        public static void MultiplyIntegersTest()
        {
            int[] integers = new int[1024];
            integers[0] = 1;
            Stopwatch stopwatch = new Stopwatch();            
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                integers[i] = integers[i - 1] * 2;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of integers", stopwatch.Elapsed);
        }

        public static void MultiplyLongTest()
        {
            long[] longs = new long[1024];
            longs[0] = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                longs[i] = longs[i - 1] * 2;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of longs", stopwatch.Elapsed);
        }

        public static void MultiplyFloatTest()
        {
            float[] floats = new float[1024];
            floats[0] = 1.0F;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                floats[i] = floats[i - 1] * 2.0F;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of floats", stopwatch.Elapsed);
        }

        public static void MultiplyDoubleTest()
        {
            double[] doubles = new double[1024];
            doubles[0] = 1.0D;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                doubles[i] = doubles[i - 1] * 2.0D;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of doubles", stopwatch.Elapsed);
        }

        public static void MultiplyDecimalTest()
        {
            decimal[] decimals = new decimal[1024];
            decimals[0] = 1.0M;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 512; i++)
            {
                decimals[i] = decimals[i - 1] * 0.1M;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Multiplication of decimals", stopwatch.Elapsed + stopwatch.Elapsed);
        }
    }
}
