using System;

class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        if (score <= 3 && score >= 1)
        {
            Console.WriteLine(score * 10);
        }
        else if (score <= 6 && score >= 4)
        {
            Console.WriteLine(score * 100);
        }
        else if (score <= 9 && score >= 7)
        {
            Console.WriteLine(score * 1000);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}