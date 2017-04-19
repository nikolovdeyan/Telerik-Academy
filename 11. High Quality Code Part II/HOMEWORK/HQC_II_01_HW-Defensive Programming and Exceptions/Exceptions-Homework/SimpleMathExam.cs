using System;
using System.Diagnostics;

public class SimpleMathExam : IExam
{
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            Debug.Assert(this.problemsSolved >= 0, "Cannot get invalid problemsSolved value.");

            return this.problemsSolved;
        }

        set
        {
            if (value < 0)
            {
                value = 0;
            }

            if (value > 10)
            {
                value = 10;
            }

            this.problemsSolved = value;
        }
    }

    public ExamResult Check()
    {
        switch (this.ProblemsSolved)
        {
            case 0: return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            case 1: return new ExamResult(4, 2, 6, "Average result: nothing done.");
            case 2: return new ExamResult(6, 2, 6, "Average result: nothing done.");
            default: throw new ArgumentException("Invalid number of problems solved!");
        }
    }
}