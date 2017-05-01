// <copyright file="PerformanceTester.cs" company="telerikacademy.com">for educational purposes only</copyright>

/*
Write a program to compare the performance of square root, natural logarithm, sinus for float,
double and decimal values.
 */

namespace TestSqrtLogSinForFloatDoubleDecimal
{
    using System;

    /// <summary>Evaluates the performance of various number types and functions.</summary>
    public class PerformanceTester
    {
        /// <summary>Main program sequence</summary>        
        public static void Main()
        {
            SqrtTester.DoAllTests();
            Console.WriteLine();
            LogTester.DoAllTests();
            Console.WriteLine();
            SinTester.DoAllTests();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
