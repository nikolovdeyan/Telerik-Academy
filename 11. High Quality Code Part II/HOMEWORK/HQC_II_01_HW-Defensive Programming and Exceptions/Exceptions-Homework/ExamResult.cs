using System;
using System.Diagnostics;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;

        this.MinGrade = minGrade;

        this.MaxGrade = maxGrade;

        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Grade cannot be a negative number.");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.grade;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("minGrade cannot be a negative number.");
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("maxGrade cannot be a negative number.");
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Comments parameter cannot be empty");
            }

            this.comments = value;
        }
    }
}
