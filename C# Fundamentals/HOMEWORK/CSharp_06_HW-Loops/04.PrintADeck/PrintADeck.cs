using System;

class PrintADeck
{
    static void Main()
    {
        string inputChar = Convert.ToString(Console.ReadLine());
        string[] stdDeck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        int trigger = 1;
        for (int i = 0; i < stdDeck.Length; i++)
        {
            if (trigger == 1)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", stdDeck[i]);
            }

            if (inputChar == stdDeck[i])
            {
                trigger = 0;
            }
        }
    }
}