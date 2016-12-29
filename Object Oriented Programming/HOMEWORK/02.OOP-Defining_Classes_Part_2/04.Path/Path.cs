using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Path
{
    // Creating the Path class
    public class Path
    {
        // Creating the private field
        private List<Point3d> polyLine;

        // Path constructors
        public Path()
        {
            this.PolyLine = new List<Point3d>();
        }
        public Path(List<Point3d> line)
            : this()
        {
            this.PolyLine = line; 
        }

        // Creating the public property
        public List<Point3d> PolyLine
        {
            get { return this.polyLine; }
            set { this.polyLine = value; }
        }

        // Methods
        // Add a single Point3d point at the end of existing line
        public void AddPoint(Point3d point)
        {
            this.PolyLine.Add(point);
            return;
        }
        // Add a list of Point3d points at the end of existing line
        public void AddLine(List<Point3d> line)
        {
            this.PolyLine.AddRange(line);
            return;
        }

        // Adding a ToString() override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Point3d point in this.PolyLine)
            {
                sb.AppendLine(point.ToString());
            }

            return sb.ToString();
        }
    }
}
