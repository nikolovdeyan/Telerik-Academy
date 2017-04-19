using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class Tests
    {
        static void Main(string[] args)
        {
            // Initialize a list of 10 students
            List<Student> myTestClassOfStudents = new List<Student>
            {
                new Student("Jonathan", "Archer", 4.56),
                new Student("Bareil", "Antos", 3.27),
                new Student("Beverly", "Crusher", 5.12),
                new Student("Wesley", "Crusher", 4.89),
                new Student("Amanda", "Grayson", 5.40),
                new Student("James", "Kirk", 3.87),
                new Student("Keiko", "O'Brien", 3.76),
                new Student("Owen", "Paris", 4.50),
                new Student("William", "Riker", 5.90),
                new Student("Hoshi", "Sato", 5.00),
            };

            // Sort the students in ascending order by grade
            var studentsOrdered = from student in myTestClassOfStudents
                                  orderby student.Grade ascending
                                  select new
                                  {
                                      name = student.FirstName + " " + student.LastName,
                                      grade = student.Grade
                                  };

            // Print result
            Console.WriteLine(new String('*', 50));
            Console.WriteLine("Sorting the students in ascending order by grade: \n");
            Console.WriteLine(String.Format("{0,-20} {1,-10}", "Student Name", "Student Grade"));
            Console.WriteLine(new String('-', 40));
            foreach (var student in studentsOrdered)
            {
                Console.WriteLine(String.Format("{0,-20} {1,-10:F2}", student.name, student.grade));
            }
            Console.WriteLine("\n\n");

            // Initialize a list of 10 workers
            List<Worker> myTestClassOfWorkers = new List<Worker>
            {
                new Worker("Depa", "Billaba", 750, 8),
                new Worker("Boba", "Fett", 1450, 9),
                new Worker("Cliegg", "Lars", 550, 9.75),
                new Worker("Mon", "Mothma", 1900, 6.25),
                new Worker("Leia", "Organa", 1400, 7.5),
                new Worker("Unkar", "Plutt", 2050, 10.5),
                new Worker("Mace", "Windu", 1760, 5.5),
                new Worker("Xamuel", "Lennox", 1200, 7.5),
                new Worker("Jyn", "Erso", 800, 8),
                new Worker("Biggs", "Darklighter", 750, 8),
            };

            // Sort the workers in descending order by earnings per hour
            var workersOrdered = from worker in myTestClassOfWorkers
                                 orderby worker.MoneyPerHour() descending
                                 select new
                                 {
                                     name = worker.FirstName + " " + worker.LastName,
                                     salaryPerHour = worker.MoneyPerHour()
                                 };

            // Print result
            Console.WriteLine(new String('*', 50));
            Console.WriteLine("Sorting the workers in descending order by earned \nmoney per hour: \n");
            Console.WriteLine(String.Format("{0,-20} {1,-10}", "Worker Name", "Worker Salary Per Hour"));
            Console.WriteLine(new String('-', 40));
            foreach (var worker in workersOrdered)
            {
                Console.WriteLine(String.Format("{0,-20} {1,-10:C2}", worker.name, worker.salaryPerHour));
            }
            Console.WriteLine("\n\n");

            // Merge the lists and sort them by first name and last name
            List<Human> myMergedList = new List<Human>();
            myMergedList.AddRange(myTestClassOfStudents);
            myMergedList.AddRange(myTestClassOfWorkers);

            var humansOrdered = from human in myMergedList
                                orderby human.FirstName ascending,
                                        human.LastName ascending
                                select new
                                {
                                    firstName = human.FirstName,
                                    lastName = human.LastName
                                };

            // Print result
            Console.WriteLine(new String('*', 50));
            Console.WriteLine("Printing the merged list, sorted by first and last name: \n");
            Console.WriteLine(String.Format("First Name, Last Name"));
            Console.WriteLine(new String('-', 40));
            foreach (var human in humansOrdered)
            {
                Console.WriteLine(String.Format("{0} {1}", human.firstName, human.lastName));
            }
            Console.WriteLine();
        }
    }
}
