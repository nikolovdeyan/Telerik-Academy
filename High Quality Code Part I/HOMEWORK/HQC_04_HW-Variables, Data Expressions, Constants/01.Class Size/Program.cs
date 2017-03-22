using System;

namespace Shapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Box oldBox = new Box(16, 9);

            Box newBox = Box.GetRotatedBox(oldBox, 45);
        }
    }
}