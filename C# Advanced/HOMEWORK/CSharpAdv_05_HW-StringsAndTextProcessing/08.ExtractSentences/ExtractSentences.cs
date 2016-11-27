using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            string inputStr = Console.ReadLine();
            string pattern = @"\b" + inputWord + @"\b";

            foreach (var str in inputStr.Split('.'))
            {
                string sentence = SentenceNormalizer(str);
                if (Regex.IsMatch(sentence, pattern))
                {

                }
            }
        }

        static string SentenceNormalizer(string sentence)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var ch in sentence)
            {
                sb.Append(char.IsLetterOrDigit(ch) ? ch : ' ');
            }
            sb.Append('.');

            //string result = Regex.Replace(sb.ToString(), @"\s+", " ");

            return sb.ToString().Trim();       
        }
    }
}
