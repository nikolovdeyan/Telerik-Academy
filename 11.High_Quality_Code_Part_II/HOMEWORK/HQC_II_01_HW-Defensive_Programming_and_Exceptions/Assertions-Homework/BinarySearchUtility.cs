using System;
using System.Linq;
using System.Diagnostics;

public static class BinarySearchUtility
{
    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        // Preconditions:
        //// • The array exists (is not null)
        //// • The array is not empty (contains at least one element)
        //// • Neither of the elements in the array is null
        //// • The sought value cannot be null
        Debug.Assert(arr != null, "Array cannot be null.");
        Debug.Assert(arr.Length != 0, "Array must contain at least one element.");
        Debug.Assert(arr.All(el => el != null), "Array cannot contain null elements.");
        Debug.Assert(value != null, "Sought value cannot be null.");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        // Preconditions:
        //// • The array and value are already verified
        //// • Both indices are non-negative numbers
        //// • Both indices are not greater than the array's length
        //// • endIndex comes after startIndex
        Debug.Assert(startIndex >= 0, "startIndex must be a non-negative number.");
        Debug.Assert(endIndex >= 0, "endIndex must be a non-negative number.");
        Debug.Assert(startIndex < arr.Length, "startIndex cannot be greater than the array's length.");
        Debug.Assert(endIndex < arr.Length, "endIndex cannot be greater than the array's length.");
        Debug.Assert(endIndex >= startIndex, "endIndex cannot be smaller than startIndex.");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                // Postconditions:
                //// • The index returned is a non-negative number
                //// • The index returned is not greater than the array's length
                Debug.Assert(midIndex >= 0, "minElementIndex must be a non-negative number.");
                Debug.Assert(midIndex < arr.Length, "minElementIndex must be lesser than the array's length.");

                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the left half
                endIndex = midIndex - 1;
            }
        }

        // Sought value not found
        return -1;
    }
}