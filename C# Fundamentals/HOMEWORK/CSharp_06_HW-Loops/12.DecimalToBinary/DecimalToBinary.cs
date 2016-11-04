using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        int inputDecimal = Convert.ToInt32(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        while (inputDecimal > 0)
        {
            string num = Convert.ToString(inputDecimal % 2);
            sb.Insert(0, num);
            inputDecimal /= 2;
        }
        Console.WriteLine(sb.ToString());
    }
}