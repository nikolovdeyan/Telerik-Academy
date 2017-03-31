using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StaticReadOnlyField
{
    public struct Point3d
    {
        private double x;
        private double y;
        private double z;
        // Adding a private static read-only field for the start of the coordinate system
        private static Point3d datum = new Point3d(0, 0, 0);

        public Point3d(double latitude, double longitude, double elevation)
            : this()
        {
            this.X = longitude;
            this.Y = latitude;
            this.Z = elevation;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        // Only a getter to make the datum property read-only
        public static Point3d Datum
        {
            get { return Point3d.datum; }
        }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendFormat("{0}, {1}, {2}", this.Y, this.X, this.Z)
                .ToString();
        }
    }
}
