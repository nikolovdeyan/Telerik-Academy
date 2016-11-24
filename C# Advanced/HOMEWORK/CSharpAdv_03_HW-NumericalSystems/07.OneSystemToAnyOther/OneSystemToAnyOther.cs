using System;
using System.Text;
using System.Numerics;

class OneSystemToAnyOther
{
    static void Main()
    {
        int inputBase = int.Parse(Console.ReadLine());
        string inputNum = Console.ReadLine();
        int outputBase = int.Parse(Console.ReadLine());

        BigInteger inputNumInDecimal = BaseNToBase10(inputNum, inputBase);
        string result = Base10ToBaseN(inputNumInDecimal, outputBase);

        Console.WriteLine(result);
    }

    static BigInteger BaseNToBase10(string numBaseN, int baseN)
    {
        BigInteger result = 0;
        foreach (char digit in numBaseN)
        {
            result = result * baseN + (digit - '0');
        }
        return result;
    }

    static string Base10ToBaseN(BigInteger numBase10, int baseN)
    {
        BigInteger remainder = 0;
        StringBuilder sb = new StringBuilder();

        while (numBase10 > 0)
        {
            remainder = numBase10 % baseN;
            numBase10 /= baseN;
            //sb.Insert(0, Translate(remainder));
            if (remainder > 9)
            {
                char letter = (char)((remainder - 9 - 1) + 'A');
                sb.Insert(0, letter.ToString());
            }
            else
            {
                sb.Insert(0, remainder.ToString());
            }
        }

        string result = sb.ToString().TrimStart('0');
        result = result.Length > 0 ? result : "0";
        return result;
    }

//      if (tempSum > 9)
//      {
//           char letter = (char)((tempSum - 9 - 1) + 'A');
//           result = (letter.ToString()) + result;
//      }
//      else
//      {
//           result = tempSum + result;
//      }

    //static string Translate(int num)
    //{
    //    string base16Digits = "0123456789ABCDEF";
    //    return base16Digits[(int)num].ToString();
    //}
}
