using System;

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string result = "Correct";
            int counter = 0;

            char[] charArr = inputStr.ToCharArray();
            foreach (var ch in charArr)
            {
                if (ch == '(') counter++;
                if (ch == ')') counter--;
                // counter should not go below 0 <-- unbalanced closing bracket
                if (counter < 0)
                {
                    result = "Incorrect";
                    break;
                }
            }

            if (counter != 0) result = "Incorrect";

            Console.WriteLine(result);
        }
    }
}
