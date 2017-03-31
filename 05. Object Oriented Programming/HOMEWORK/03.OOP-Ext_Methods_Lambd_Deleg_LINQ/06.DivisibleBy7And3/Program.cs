using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            // First define a couple of arrays for testing
            int[] myTestIntArr = new int[] { 4, 6, 13, 20, 21, 42, 49, 56, 87, 96 };
            long[] myTestLongArr = new long[] { 21, 22, 63, 84, 103, 193 };

            // Find numbers divisible by 7 and 3 using lambda expressions
            var lambdaIntArrResult = myTestIntArr.Where(x => x % 3 == 0 && x % 7 == 0);
            var lambdaLongArrResult = myTestLongArr.Where(x => x % 3 == 0 && x % 7 == 0);

            // Print results
            Console.WriteLine("******************************************");
            Console.WriteLine("Filter arrays using lambda:");
            Console.WriteLine();
            Console.WriteLine("Original integer array: {0}", string.Join(", ", myTestIntArr));
            Console.WriteLine("Filtered array: {0}", string.Join(", ", lambdaIntArrResult));
            Console.WriteLine();
            Console.WriteLine("Original long array: {0}", string.Join(", ", myTestLongArr));
            Console.WriteLine("Filtered array: {0}", string.Join(", ", lambdaLongArrResult));
            Console.WriteLine();

            // Find numbers divisible by 7 and 3 using LINQ
            var linqIntArrResult = from num in myTestIntArr
                                   where num % 3 == 0 && num % 7 == 0
                                   select num;
            var linqLongArrResult = from num in myTestLongArr
                                    where num % 3 == 0 && num % 7 == 0
                                    select num;

            // Print results
            Console.WriteLine("******************************************");
            Console.WriteLine("Filter arrays using LINQ:");
            Console.WriteLine();
            Console.WriteLine("Original integer array: {0}", string.Join(", ", myTestIntArr));
            Console.WriteLine("Filtered array: {0}", string.Join(", ", linqIntArrResult));
            Console.WriteLine();
            Console.WriteLine("Original long array: {0}", string.Join(", ", myTestLongArr));
            Console.WriteLine("Filtered array: {0}", string.Join(", ", linqLongArrResult));
            Console.WriteLine();

        }
    }
}
