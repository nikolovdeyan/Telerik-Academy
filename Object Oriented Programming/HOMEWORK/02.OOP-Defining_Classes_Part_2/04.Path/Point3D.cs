using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Path
{
    public struct Point3d
    {
        private double x;
        private double y;
        private double z;
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
