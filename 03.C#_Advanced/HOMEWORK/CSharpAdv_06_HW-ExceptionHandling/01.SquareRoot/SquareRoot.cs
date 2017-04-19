using System;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            try
            {
                double inputNum = double.Parse(inputStr);

                if (inputNum < 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    double result = Math.Sqrt(inputNum);

                    Console.WriteLine("{0:F3}", result);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
