using System;

class EnglishDigit
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        Console.WriteLine(StringLastDigit(inputNum));
    }

    static string StringLastDigit(int number)
    {
        string strNumber = Convert.ToString(number);
        char lastDigit = strNumber[strNumber.Length - 1];

        switch (lastDigit)
        {
            case '1':
                return "one";
            case '2':
                return "two";
            case '3':
                return "three";
            case '4':
                return "four";
            case '5':
                return "five";
            case '6':
                return "six";
            case '7':
                return "seven";
            case '8':
                return "eight";
            case '9':
                return "nine";
            case '0':
                return "zero";
        }
        return lastDigit.ToString();
    }
}