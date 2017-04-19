using System;
using System.Diagnostics;

public class CSharpExam : IExam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            Debug.Assert(this.score >= 0, "Cannot get invalid score.");

            return this.score;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Cannot set invalid score.");
            }

            this.score = value;
        }
    }

    public ExamResult Check()
    {
        if (this.Score < 0 || this.Score > 100)
        {
            throw new ArgumentOutOfRangeException(string.Format("Invalid score {0}", this.Score));
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}