using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the DistanceCalculator
            Point3d locSofia = new Point3d(42.7, 23.33, 500);
            Point3d locPlovdiv = new Point3d(42.15, 24.75, 160);

            var distance = DistanceCalculator.CalculateDistance(locSofia, locPlovdiv);

            Console.WriteLine("The distance from point A to point B in km: {0:F2}", distance / 1000);
        }
    }
}
