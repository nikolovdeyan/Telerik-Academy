using System;

namespace Refactor_Loop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] sampleArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };

            ShowFirstHundredValuesCheckEveryTenthMemberForABreakValue(sampleArray, 11);
        }

        private static void ShowFirstHundredValuesCheckEveryTenthMemberForABreakValue(int[] array, int expectedValue)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }
    }
}