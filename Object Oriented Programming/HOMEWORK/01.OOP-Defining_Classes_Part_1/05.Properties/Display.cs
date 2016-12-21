using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Properties
{
    public class Display
    {
        private int width;
        private int height;
        private int numberOfColors;

        // Adding properties to properly encapsulate the data
        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

        // Constructor now use the properties to access the fields
        public Display(int width, int height, int numberOfColors)
        {
            this.Width = width;
            this.Height = height;
            this.NumberOfColors = numberOfColors;
        }

        // ToString() now uses the properties as well
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine("---Display Information:")
                .AppendLine(string.Format("    Model:        {0}", this.Width))
                .AppendLine(string.Format("    Type:         {0}", this.Height))
                .AppendLine(string.Format("    Hours idle:   {0}", this.NumberOfColors))
                .ToString();
        }
    }
}
