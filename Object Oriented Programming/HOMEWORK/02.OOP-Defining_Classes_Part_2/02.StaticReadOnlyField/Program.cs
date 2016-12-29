using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StaticReadOnlyField
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the zero point
            Point3d zeroPoint = Point3d.Datum;

            Console.WriteLine("Zero point coordinates: {0}", zeroPoint);

        }
    }
}
