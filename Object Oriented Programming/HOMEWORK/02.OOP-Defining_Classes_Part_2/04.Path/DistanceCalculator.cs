using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace _04.Path
{
    public static class DistanceCalculator
    {

        public static double CalculateDistance(Point3d origin, Point3d destination)
        {
            var originPoint = new GeoCoordinate(origin.X, origin.Y);
            var destinationPoint = new GeoCoordinate(destination.X, destination.Y);

            return originPoint.GetDistanceTo(destinationPoint);
        }

    }
}
