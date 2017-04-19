using System;

class GetLargestNumber
{
    static void Main()
    {
        string[] inputNums = Console.ReadLine().Split(' ');
        int num1 = int.Parse(inputNums[0]);
        int num2 = int.Parse(inputNums[1]);
        int num3 = int.Parse(inputNums[2]);

        Console.WriteLine(GetMax(GetMax(num1, num2), num3));
    }

    static int GetMax(int firstInt, int secondInt)
    {
        int larger = (firstInt > secondInt) ? firstInt : secondInt;
        return larger;
    }
}