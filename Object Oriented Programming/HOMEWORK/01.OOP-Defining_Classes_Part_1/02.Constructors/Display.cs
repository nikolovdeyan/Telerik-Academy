using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Constructors
{
    public class Display
    {
        private int width;
        private int height;
        private int numberOfColors;

        // Adding constructors
        // This implementation is wrong as it breaks encapsulation.
        // Private fields should be accessed through public properties only.
        // Proper implementation in 05.Properties
        public Display(int width, int height, int numberOfColors)
        {
            this.width = width;
            this.height = height;
            this.numberOfColors = numberOfColors;
        }
    }
}
