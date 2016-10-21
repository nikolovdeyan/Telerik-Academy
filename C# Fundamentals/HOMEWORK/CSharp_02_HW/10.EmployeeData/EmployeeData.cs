using System;


class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "Kim";
        string lastName = "Kardashian";
        short age = 45; //but don't tell anyone
        char gender = 'f';
        long personalIDNumber = 8306112507;
        uint employeeId = 27569999;

        Console.WriteLine("First and last name: {0} {1}", firstName, lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal Identification Number: {0}", personalIDNumber);
        Console.WriteLine("Employee ID: {0}", employeeId);
    }
}