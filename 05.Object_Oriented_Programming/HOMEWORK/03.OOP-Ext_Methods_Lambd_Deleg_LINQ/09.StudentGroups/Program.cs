using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the same list of students as in the previous students tasks, this time presented as a List<students> instead of an array.
            List<Student> studentsList = new List<Student>
            {
                new Student() { FirstName = "Carrot", LastName = "Ironfoundersson", Age = 16, FN = "10010621", Tel = "5000-12591", Email = "carrot@ampolice.com", Marks = new List<double> {4.5, 5, 3, 2, 6, 4.5, 5}, GroupNumber = 2 },
                new Student() { FirstName = "Mortimer", LastName = "Sto Helit", Age = 17, FN = "10020555", Tel = "5001-55493", Email = "NOREPLY@DEATHSDOMAIN", Marks = new List<double> {3, 4, 4.5, 3, 5, 4, 3.5}, GroupNumber = 1},
                new Student() { FirstName = "Moist", LastName = "von Lipwig", Age = 20, FN = "10020412", Tel = "5001-12121", Email = "vonlipwig@morporkpostal.com", Marks = new List<double> {6, 5, 6, 4, 6, 5.5, 6}, GroupNumber = 3},
                new Student() { FirstName = "Havelock", LastName = "Vetinari", Age = 55, FN = "10010611", Tel = "5000-05000", Email = "patrician@ankhmorpork.com", Marks = new List<double> {6, 6, 6, 6, 6, 6, 6}, GroupNumber = 1},
                new Student() { FirstName = "William", LastName = "de Lorde", Age = 22, FN = "10030415", Tel = "5000-02525", Email = "editor@ankhmorporktimes.com", Marks = new List<double> {4.5, 5.5, 6, 6, 4, 4.5, 5}, GroupNumber = 2},
                new Student() { FirstName = "Nobby", LastName = "Nobbs", Age = 42, FN = "10010619", Tel = "5001-11974", Email = "nobby@ampolice.com", Marks = new List<double> {3, 2, 4, 3.5, 2, 2, 2}, GroupNumber = 3},
                new Student() { FirstName = "Mustrum", LastName = "Ridcully", Age = 67, FN = "10011412", Tel = "5000-19449", Email = "archchancellor@unseenuni.edu", Marks = new List<double> {5.5, 5, 6, 6, 6, 4.5, 5.5}, GroupNumber = 1},
                new Student() { FirstName = "Ponder", LastName = "Stibbons", Age = 24, FN = "10003515", Tel = "5001-99178", Email = "ponder.stibbons@unseenuni.edu", Marks = new List<double> {3.5, 6, 6, 4, 5, 2, 3}, GroupNumber = 3},
                new Student() { FirstName = "Samuel", LastName = "Vimes", Age = 50, FN = "10014494", Tel = "5001-99178", Email = "sam@ampolice.com", Marks = new List<double> {3.5, 4, 3, 4.5, 3, 2, 5}, GroupNumber = 3},
                new Student() { FirstName = "Esmeralda", LastName = "Weatherwax", Age = 50, FN = "10020641", Tel = "5004-91485", Email = "granny@abv.bg", Marks = new List<double> {5.5, 4, 2, 2, 4, 5.5, 5}, GroupNumber = 2},
                new Student() { FirstName = "Lucy", LastName = "Tockley", Age = 16, FN = "10001417", Tel = "5004-91500", Email = "diamanda@abv.bg", Marks = new List<double> {4, 2, 3.5, 6, 6, 5, 4}, GroupNumber = 2},
                new Student() { FirstName = "Otto", LastName = "Chriek", Age = 453, FN = "10046614", Tel = "5000-55197", Email = "otto@ankhmorporktimes.com", Marks = new List<double> {5, 4.5, 3.5, 6, 5, 5.5, 5.5}, GroupNumber = 1},
                new Student() { FirstName = "Cheery", LastName = "Littlebottom", Age = 42, FN = "10069494", Tel = "5001-94831", Email = "cheery@ampolice.com", Marks = new List<double> {5.5, 3.5, 3, 2, 2, 4, 6}, GroupNumber = 2},
                new Student() { FirstName = "Rufus", LastName = "Drumknott", Age = 35, FN = "55911111", Tel = "5000-11339", Email = "chiefclerk@ankhmorpork.com", Marks = new List<double> {6, 6, 5.5, 4.5, 6, 5.5, 5.5}, GroupNumber = 1},
                new Student() { FirstName = "Horace", LastName = "Worblehat", Age = 42, FN = "10005966", Tel = "5001-49136", Email = "harambe@abv.bg", Marks = new List<double> {3, 4.5, 6, 5, 4.5, 4, 3}, GroupNumber = 3}
            };

            // Select the students from group number 2 and order them by First Name using LINQ

            var studentsFilteredLinq = from student in studentsList
                                       where student.GroupNumber == 2
                                       orderby student.FirstName descending
                                       select student;

            // Print results
            Console.WriteLine("******************************************");
            Console.WriteLine("Students from group 2, sorted in descending order by FirstName:");
            foreach (var student in studentsFilteredLinq)
            {
                Console.WriteLine("Student: {0} {1} -- group {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine();

        }
    }
}
