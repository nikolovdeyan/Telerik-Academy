using System;
class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[26];

        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(i + 97); //65 is the offset for capital A in the ascii table
        }

        string wordIput = Console.ReadLine().ToLower();

        for (int i = 0; i < wordIput.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (wordIput[i] == letters[j])
                {
                    Console.WriteLine("{0}", j);
                }
            }
        }
    }
}
