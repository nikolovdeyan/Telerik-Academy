using System;
using System.Linq;

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            string inputStr = Console.ReadLine();
            string[] inputSentences = inputStr.Split('.').ToArray();

            char[] delimiters = inputStr.Where(x => !char.IsLetter(x))
                .Distinct()
                .ToArray();

            for (int i = 0; i < inputSentences.Length; i++)
            {
                string[] sentenceWords = inputSentences[i]
                    .Split(delimiters)
                    .ToArray();

                if (sentenceWords.Contains(inputWord))
                {
                    Console.Write("{0}. ", inputSentences[i].Trim());
                }
            }
        }
    }
}