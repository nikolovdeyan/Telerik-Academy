using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StaticField
{
    public class Display
    {
        private int width;
        private int height;
        private int numberOfColors;

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

        public Display(int width, int height, int numberOfColors)
        {
            this.Width = width;
            this.Height = height;
            this.NumberOfColors = numberOfColors;
        }

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
