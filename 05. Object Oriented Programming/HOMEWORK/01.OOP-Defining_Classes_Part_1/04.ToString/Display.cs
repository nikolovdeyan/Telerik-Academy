using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ToString
{
    public class Display
    {
        private int width;
        private int height;
        private int numberOfColors;

        public Display(int width, int height, int numberOfColors)
        {
            this.width = width;
            this.height = height;
            this.numberOfColors = numberOfColors;
        }

        // Override .ToString() Method
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine("---Display Information:")
                .AppendLine(string.Format("    Model:        {0}", this.width))
                .AppendLine(string.Format("    Type:         {0}", this.height))
                .AppendLine(string.Format("    Hours idle:   {0}", this.numberOfColors))
                .ToString();
        }
    }
}
