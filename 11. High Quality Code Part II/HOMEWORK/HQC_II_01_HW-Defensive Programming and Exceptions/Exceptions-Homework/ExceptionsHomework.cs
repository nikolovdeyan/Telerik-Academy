using System;
using System.Collections.Generic;
using System.Text;

internal static class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count = -1)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("Array must be non-null.");
        }

        List<T> result = new List<T>();

        if (startIndex < 0 || startIndex > arr.Length - 1)
        {
            throw new ArgumentOutOfRangeException("startIndex out of range.");
        }

        if (count == -1 || count > arr.Length - startIndex)
        {
            count = arr.Length - startIndex;
        }

        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count = -1)
    {
        if (str == null)
        {
            throw new ArgumentNullException("Input string cannot be null");
        }

        if (count == -1 || count > str.Length)
        {
            count = str.Length;
        }

        StringBuilder result = new StringBuilder();

        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentException("Only natural numbers can be prime");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}