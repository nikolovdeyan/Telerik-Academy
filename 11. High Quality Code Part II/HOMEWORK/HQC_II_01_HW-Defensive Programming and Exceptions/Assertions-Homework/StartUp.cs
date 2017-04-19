using System;

namespace Assertions_Homework
{
    public class StartUp
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SortingUtility.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SortingUtility.SelectionSort(new int[0]); // Test sorting empty array
            SortingUtility.SelectionSort(new int[1]); // Test sorting a single element array

            Console.WriteLine(BinarySearchUtility.BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearchUtility.BinarySearch(arr, 0));
            Console.WriteLine(BinarySearchUtility.BinarySearch(arr, 17));
            Console.WriteLine(BinarySearchUtility.BinarySearch(arr, 10));
            Console.WriteLine(BinarySearchUtility.BinarySearch(arr, 1000));
        }
    }
}