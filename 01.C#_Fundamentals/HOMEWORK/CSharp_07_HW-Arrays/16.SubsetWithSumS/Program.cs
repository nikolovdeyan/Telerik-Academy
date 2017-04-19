/// Code not mine, credit to https://github.com/marianamn/Telerik-Academy-Activities/blob/master/Homeworks/03.%20CSharp-Advance/01.%20Arrays/SubsetKWithSumS/SubsetKWithSumS.cs

using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.SubsetWithSumS
{
    class SubsetWithKElementsWithGivenSum
    {

        static void FindAndPrintSubsetsWithMaxSum(int[] numbers, int elements, int sum)
        {
            Console.Write("Subsets with {0} elements and sum {1}: ", elements, sum);

            int totalSubsets = (int)(Math.Pow(2, numbers.Length) - 1); // Total subsets = 2^n - 1 
            bool isFoundSubset = false;

            for (int i = 1; i <= totalSubsets; i++)
            {
                if (ElementsInSubset(i) == elements)
                {
                    List<int> currentSubset = numbers.Where((t, j) => ((i >> j) & 1) == 1).ToList();

                    if (currentSubset.Sum() == sum)
                    {
                        isFoundSubset = true;
                        PrintSubsetWithGivenSum(currentSubset);
                    }
                }
            }

            if (!isFoundSubset) Console.WriteLine("There are no subsets with {0} elements and Sum {1}...", elements, sum);
        }

        static int ElementsInSubset(int currentNumber)
        {
            int elementsInSubset = 0;
            while (currentNumber != 0)
            {
                elementsInSubset += currentNumber & 1;
                currentNumber >>= 1;
            }
            return elementsInSubset;
        }

        static void PrintElementOfArray(int[] numbers)
        {
            Console.WriteLine("Array's elements: {0}", string.Join(", ", numbers));
        }

        static void PrintSubsetWithGivenSum(List<int> subset)
        {
            Console.WriteLine(string.Join(", ", subset));
        }

        static void Main()
        {
            Console.WriteLine("Enter number sequence, separated by commas:");
            string input = Console.ReadLine();
            string[] array = input.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }

            Console.WriteLine("Enter a number of elements K in subset: ");
            int elements = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number for a sum S that we are going to looking for: ");
            int sum = int.Parse(Console.ReadLine());

            if (numbers.Length < elements)
            {
                Console.WriteLine("Number of elements must be smaller or equal than the array's length!");
                return;
            }

            PrintElementOfArray(numbers);
            FindAndPrintSubsetsWithMaxSum(numbers, elements, sum);
        }
    }
}
