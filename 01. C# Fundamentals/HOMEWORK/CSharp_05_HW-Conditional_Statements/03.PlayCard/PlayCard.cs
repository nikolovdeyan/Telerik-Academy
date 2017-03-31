using System;

class PlayCard
{
    static void Main()
    {
        string input = Convert.ToString(Console.ReadLine());
        string[] cardDeck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        int resultPos = Array.IndexOf(cardDeck, input);

        if (resultPos > -1)
        {
            Console.WriteLine("yes {0}", cardDeck[resultPos]);
        }
        else
        {
            Console.WriteLine("no {0}", input);
        }
    }
}


// Best Practice: (using System.Linq)
//
// if (array.Contains(input))
// {
//     Console.WriteLine("yes {0}", input)
// }
// else
// {
//     Console.WriteLine("no {0}", input)
// }