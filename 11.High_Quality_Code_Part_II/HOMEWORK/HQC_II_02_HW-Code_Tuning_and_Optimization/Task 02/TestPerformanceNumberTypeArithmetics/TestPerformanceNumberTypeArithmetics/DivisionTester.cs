namespace TestPerformanceNumberTypeArithmetics
{
    using System;
    using System.Diagnostics;

    public static class DivisionTester
    {
        public static void DoAllTests()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            DivisionTester.DivideIntegersTest();
            DivisionTester.DivideLongTest();
            DivisionTester.DivideFloatTest();
            DivisionTester.DivideDoubleTest();
            DivisionTester.DivideDecimalTest();
        }

        public static void DivideIntegersTest()
        {
            int[] integers = new int[1024];
            integers[0] = 0;
            Stopwatch stopwatch = new Stopwatch();            
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                integers[i] = integers[i - 1] / 1;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Division of integers", stopwatch.Elapsed);
        }

        public static void DivideLongTest()
        {
            long[] longs = new long[1024];
            longs[0] = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                longs[i] = longs[i - 1] / 1;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Division of longs", stopwatch.Elapsed);
        }

        public static void DivideFloatTest()
        {
            float[] floats = new float[1024];
            floats[0] = 0.0F;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                floats[i] = floats[i - 1] / 1.0F;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Division of floats", stopwatch.Elapsed);
        }

        public static void DivideDoubleTest()
        {
            double[] doubles = new double[1024];
            doubles[0] = 0.0D;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                doubles[i] = doubles[i - 1] / 1.0D;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Division of doubles", stopwatch.Elapsed);
        }

        public static void DivideDecimalTest()
        {
            decimal[] decimals = new decimal[1024];
            decimals[0] = 0.0M;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < 1024; i++)
            {
                decimals[i] = decimals[i - 1] / 1.0M;
            }

            stopwatch.Stop();
            Console.WriteLine("{0} Division of decimals", stopwatch.Elapsed);
        }
    }
}
