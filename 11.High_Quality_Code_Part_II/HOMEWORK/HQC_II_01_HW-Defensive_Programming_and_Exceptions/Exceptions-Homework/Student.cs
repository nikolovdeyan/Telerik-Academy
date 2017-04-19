using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

public class Student
{
    private string firstName;

    private string lastName;

    private IList<IExam> exams;

    public Student(string firstName, string lastName, IList<IExam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            Debug.Assert(!string.IsNullOrEmpty(this.firstName), "Cannot get invalid firstName value.");

            return this.firstName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("First name cannot be empty.");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            Debug.Assert(!string.IsNullOrEmpty(this.lastName), "Cannot get invalid lastName value.");

            return this.lastName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Last name cannot be empty.");
            }

            this.lastName = value;
        }
    }

    public IList<IExam> Exams
    {
        get
        {
            Debug.Assert(this.exams != null, "Cannot get invalid Exams value.");

            return this.exams;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot set null as exams.");
            }

            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("The student has null value for exams.");
        }

        if (this.Exams.Count == 0)
        {
            Console.WriteLine("The student has no exams.");
        }

        IList<ExamResult> results = new List<ExamResult>();

        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("Cannot calculate average on missing exams.");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("Cannot average missing results.");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}