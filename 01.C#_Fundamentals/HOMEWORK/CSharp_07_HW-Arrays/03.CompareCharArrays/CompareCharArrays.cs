using System;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstString = Console.ReadLine().ToCharArray();
        char[] secondString = Console.ReadLine().ToCharArray();

        string areEqual = "=";

        for (long i = 0;
            i <= ((firstString.Length < secondString.Length) ? firstString.Length - 1 : secondString.Length - 1);
            i++)
        {
            if (firstString[i] < secondString[i])
            {
                areEqual = "<";
                break;
            }
            else if (firstString[i] > secondString[i])
            {
                areEqual = ">";
                break;
            }
            else
            {
                if (firstString.Length > secondString.Length)
                {
                    areEqual = ">";
                }
                else if (firstString.Length < secondString.Length)
                {
                    areEqual = "<";
                }
            }            
        }
        Console.WriteLine(areEqual);
    }
}