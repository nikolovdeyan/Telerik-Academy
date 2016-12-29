using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structure
{
    // Creating a struct with fields, properties, constructor and ToString override
    public struct Point3d
    {
        // Private Fields
        private double x;
        private double y;
        private double z;

        // Constructor
        // A default (parameterless) constructor should not be defined for structs 
        public Point3d(double latitude, double longitude, double elevation)
            : this()
        {
            this.X = longitude;
            this.Y = latitude;
            this.Z = elevation;
        }

        // Properties
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

        // Implement ToString() to enable printing a 3D point
        // Format is latitude, longitude, elevation
        public override string ToString()
        {
            return new StringBuilder()
                .AppendFormat("{0}, {1}, {2}", this.Y, this.X, this.Z)
                .ToString();
        }
    }
}
