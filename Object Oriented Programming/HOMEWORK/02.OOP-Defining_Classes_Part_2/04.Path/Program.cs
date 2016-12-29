using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Path
{
    class Program
    {
        static void Main(string[] args)
        {
            // TESTING THE PATH CLASS:
            // Creating a **very** generalized sequence of points to Pleven from Sofia
            List<Point3d> waypoints = new List<Point3d>();
            waypoints.Add(new Point3d(42.6954, 23.3057, 550));
            waypoints.Add(new Point3d(42.7971, 23.8105, 780));
            waypoints.Add(new Point3d(42.8919, 23.8257, 463));
            waypoints.Add(new Point3d(43.0919, 24.1500, 197));
            waypoints.Add(new Point3d(43.3266, 24.2726, 221));
            waypoints.Add(new Point3d(43.4127, 24.6152, 125));

            // Creating a Path from the list of Points3d items
            Path myTestRoute = new Path(waypoints);

            // Print the Path
            Console.WriteLine("*** Road Sofia-Pleven ***");
            Console.WriteLine(myTestRoute.ToString());
            Console.WriteLine();

            // Create a sequence of points from Pleven to Ruse
            List<Point3d> waypoints2 = new List<Point3d>();
            waypoints2.Add(new Point3d(43.4451, 25.0171, 46));
            waypoints2.Add(new Point3d(43.4130, 25.1691, 146));
            waypoints2.Add(new Point3d(43.4679, 25.7268, 43));
            waypoints2.Add(new Point3d(43.4942, 25.8022, 247));
            waypoints2.Add(new Point3d(43.8420, 25.9616, 50));

            // Add the second sequence to our Path and print it again
            myTestRoute.AddLine(waypoints2);
            Console.WriteLine("*** Road Sofia-Ruse ***");
            Console.WriteLine(myTestRoute.ToString());
            Console.WriteLine();

            // Adding a few Points to myTestRoute to extend the Path to Silistra
            myTestRoute.AddPoint(new Point3d(43.9226, 26.1163, 22));
            myTestRoute.AddPoint(new Point3d(43.9921, 26.3651, 34));
            myTestRoute.AddPoint(new Point3d(44.0374, 26.6393, 114));
            myTestRoute.AddPoint(new Point3d(43.9752, 26.7827, 118));
            myTestRoute.AddPoint(new Point3d(44.1171, 27.2608, 25));

            // Print the Path again 
            Console.WriteLine("*** Road Sofia-Silistra ***");
            Console.WriteLine(myTestRoute.ToString());
            Console.WriteLine();

            // TESTING THE PATHSTORAGE CLASS:
            // Let's save myTestRoute to a file using the PathStorage class
            string myTestRouteName = "sf-ss.path";
            PathStorage.WritePathToFile(myTestRoute, myTestRouteName);

            // Now let's read the sf-ss.path file and print its contents again
            string myTestFileToRead = "./../../../sf-ss.path";
            Path myRouteFromFile = PathStorage.ReadPathFromFile(myTestFileToRead);

            Console.WriteLine("*** Road Read From A File ***");
            Console.WriteLine(myRouteFromFile.ToString());
            Console.WriteLine();

        }
    }
}
