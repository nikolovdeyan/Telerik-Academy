namespace TestPerformanceNumberTypeArithmetics
{
    using System;

    public static class PerformanceTester
    {
        public static void Main()
        {
            AdditionTester.DoAllTests();
            Console.WriteLine();
            SubtractionTester.DoAllTests();
            Console.WriteLine();
            IncrementTester.DoAllTests();
            Console.WriteLine();
            MultiplicationTester.DoAllTests();
            Console.WriteLine();
            DivisionTester.DoAllTests();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
