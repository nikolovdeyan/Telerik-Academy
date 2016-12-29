using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the Point3d Struct
            Point3d locSofia = new Point3d(42.7, 23.33, 500);
            Point3d locPlovdiv = new Point3d(42.15, 24.75, 160);
            Point3d locVarna = new Point3d(43.22, 27.92, 80);

            Console.WriteLine("Sofia coordinates: {0}m", locSofia);
            Console.WriteLine("Plovdiv coordinates: {0}m", locPlovdiv);
            Console.WriteLine("Varna coordinates: {0}m", locVarna);
        }
    }
}
