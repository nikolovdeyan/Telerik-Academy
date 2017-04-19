using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.SubsetKWithSumS
{
    class Program
    {
        static void FindSubsetInArr(int[] inputArr, int subset, int sum)
        {
            Console.WriteLine("Provided array: {0}", string.Join(", ", inputArr));
            Console.Write("Subsets with {0} elements and sum {1}: ", subset, sum);

            int allPossibleSubsets = (int)(Math.Pow(2, inputArr.Length) - 1); // Total subsets = 2^n - 1 
            bool subsetFound = false;

            for (int i = 1; i <= allPossibleSubsets; i++)
            {
                if (ElementsInSubset(i) == subset)
                {
                    List<int> currentSubset = inputArr.Where((t, j) => ((i >> j) & 1) == 1).ToList();

                    if (currentSubset.Sum() == sum)
                    {
                        subsetFound = true;
                        PrintSubsetWithGivenSum(currentSubset);
                    }
                }
            }

            if (!subsetFound) Console.WriteLine("There are no subsets with {0} elements and Sum {1}...", subset, sum);
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

        static void PrintSubsetWithGivenSum(List<int> subset)
        {
            Console.WriteLine(string.Join(", ", subset));
        }

        static void Main()
        {
            Console.WriteLine("Please provide a sequence of integer, separated by commas:");
            int[] inputArr = Console.ReadLine()
                                    .Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries)
                                    .Select(member => Convert.ToInt32(member))
                                    .ToArray();

            Console.WriteLine("Please provide the length of the subset sought:");
            int subset = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the sum of the subset sought: ");
            int sum = int.Parse(Console.ReadLine());

            if (inputArr.Length < subset)
            {
                Console.WriteLine("Array length was smaller than the provided subset length");
                return;
            }

            FindSubsetInArr(inputArr, subset, sum);
        }
    }
}
