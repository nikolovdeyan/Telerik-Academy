using System;
using System.Diagnostics;
using System.Linq;

namespace Assertions_Homework
{
    public static class SortingUtility
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            // Preconditions:
            //// • The array exists (is not null)
            //// • The array is not empty (contains at least one element)
            //// • Neither of the elements in the array is null
            Debug.Assert(arr != null, "Array cannot be null");
            Debug.Assert(arr.Length >= 0, "Array must contain at least one element");
            Debug.Assert(arr.All(el => el != null), "Array cannot contain null elements");
            var initialLength = arr.Length;

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            // Postconditions:
            //// • The output array should be the same length
            //// • The output array should be sorted
            var finalLength = arr.Length;
            Debug.Assert(finalLength == initialLength, "The output array is not the same size.");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, "The array is not sorted");
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            // Preconditions:
            //// • The array is already verified to exist and be valid
            //// • Both indices are non-negative numbers
            //// • Both indices are not greater than the array's length
            //// • endIndex comes after startIndex
            Debug.Assert(startIndex >= 0, "startIndex must be a non-negative number");
            Debug.Assert(endIndex >= 0, "endIndex must be a non-negative number");
            Debug.Assert(startIndex < arr.Length, "startIndex cannot be greater than the array's length");
            Debug.Assert(endIndex < arr.Length, "endIndex cannot be greater than the array's length");
            Debug.Assert(endIndex >= startIndex, "endIndex cannot be smaller than startIndex");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            // Postconditions:
            //// • The index returned is a non-negative number
            //// • The index returned is not greater than the array's length
            Debug.Assert(minElementIndex >= 0, "minElementIndex must be a non-negative number");
            Debug.Assert(minElementIndex < arr.Length, "minElementIndex must be lesser than the array's length");
            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            // Preconditions:
            //// • The references to the elements should not be null
            Debug.Assert(x != null, "Reference to first element to swap can not be null");
            Debug.Assert(y != null, "Reference to second element to swap can not be null");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}