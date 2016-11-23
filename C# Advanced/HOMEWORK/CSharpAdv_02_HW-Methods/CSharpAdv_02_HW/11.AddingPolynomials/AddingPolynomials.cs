using System;
using System.Linq;

class AddingPolynomials
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        int[] polynomFirst = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int[] polynomSecond = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int[] result = PolynomAddition(polynomFirst, polynomSecond);

        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }

    static int[] PolynomAddition(int[] firstArr, int[] secondArr)
    {
        int[] sum = new int[firstArr.Length];

        for (int i = 0; i < firstArr.Length; i++)
        {
            sum[i] = firstArr[i] + secondArr[i];
        }
        return sum;
    }
}