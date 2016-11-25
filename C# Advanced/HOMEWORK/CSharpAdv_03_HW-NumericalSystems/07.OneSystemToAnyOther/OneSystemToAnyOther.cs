using System;
using System.Text;

class OneSystemToAnyOther
{
    const string BASE_N_DIGITS = "0123456789ABCDEF";

    static void Main()
    {
        int inputBase = int.Parse(Console.ReadLine());
        string inputNum = Console.ReadLine();
        int outputBase = int.Parse(Console.ReadLine());

        long inputNumInDecimal = BaseNToBase10(inputNum, inputBase);
        string result = Base10ToBaseN(inputNumInDecimal, outputBase);

        Console.WriteLine(result);
    }

    static long BaseNToBase10(string numBaseN, int baseN)
    {
        long result = 0;
        foreach (char digit in numBaseN)
        {
            int numberDecimal = BASE_N_DIGITS.IndexOf(digit);
            result = result * baseN + numberDecimal;
        }

        return result;
    }

    static string Base10ToBaseN(long numBase10, int baseN)
    {
        int remainder = 0;
        StringBuilder sb = new StringBuilder();

        while (numBase10 > 0)
        {
            remainder = (int)(numBase10 % baseN);
            numBase10 /= baseN;
            sb.Insert(0, BASE_N_DIGITS[remainder]);
        }

        string result = sb.ToString().TrimStart('0');
        result = result.Length > 0 ? result : "0";

        return result;
    }
}
