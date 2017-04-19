using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace _03.StaticClass
{
    public static class DistanceCalculator
    {

        // While searching for Halversine algorithm implemented in C# i found that there is a
        // built-in GeoCoordinate class in .NET, so I happily used it.
        // Here is the Halversine implemented in C# for reference --> http://stackoverflow.com/a/215849/6819519
        public static double CalculateDistance(Point3d origin, Point3d destination)
        {
            var originPoint = new GeoCoordinate(origin.X, origin.Y);
            var destinationPoint = new GeoCoordinate(destination.X, destination.Y);

            return originPoint.GetDistanceTo(destinationPoint);
        }

    }
}
