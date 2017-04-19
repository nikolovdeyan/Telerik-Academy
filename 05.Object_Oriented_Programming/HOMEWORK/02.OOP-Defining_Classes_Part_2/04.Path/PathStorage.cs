using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Path
{
    // Creating the PathStorage class
    public class PathStorage
    {
        // A method to write a Path to a file at a given location
        // If the file exists, its contents are overwritten
        public static void WritePathToFile(Path path, string fileName)
        {
            // That defaultPath should bring the file in the main 
            // homework folder (02.OOP-Defining_Classes_Part_2)
            string defaultPath = "./../../../";
            string completePath = defaultPath + fileName;

            Console.WriteLine("Your Path file saved as: {0}", completePath);
            Console.WriteLine();
            File.WriteAllText(completePath, path.ToString());

        }

        // A method to read a Path from a file 
        public static Path ReadPathFromFile(string fileLocation)
        {
            // Generate a list of all points in the file
            List<Point3d> allPoints = File.ReadAllLines(fileLocation)
                       .Select(l => new { split = l.Split(',') })
                       .Select(s => new Point3d
                       {
                           X = Double.Parse(s.split.ElementAtOrDefault(0)),
                           Y = Double.Parse(s.split.ElementAtOrDefault(1)),
                           Z = Double.Parse(s.split.ElementAtOrDefault(2))
                       }).ToList();

            // Convert the list to a path
            Path pathFromFile = new Path(allPoints);
            return pathFromFile;
        }
    }
}
