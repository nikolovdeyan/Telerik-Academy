using System;

namespace Methods.Utils
{
    public static class Utilities
    {
        /// <summary>Calculates the area of a triangle with given three sides lengths.</summary>
        /// <param name="sideA">First side of the triangle.</param>
        /// <param name="sideB">Second side of the triangle.</param>
        /// <param name="sideC">Third side of the triangle.</param>
        /// <returns>The area of the triangle.</returns>
        /// <exeption cref="ArgumentException">Thrown if a side is negative or if any two sides are shorter than the third side.</exeption>
        public static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            // Validations were extracted into a meaningful method and expanded.
            if (!ValidTriangleSides(sideA, sideB, sideC))
            {
                throw new ArgumentException("Invalid triangle sides provided");
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;

            // Using Heron's formula:
            double area = Math.Sqrt(
                semiPerimeter *
                (semiPerimeter - sideA) *
                (semiPerimeter - sideB) *
                (semiPerimeter - sideC));

            return area;
        }

        /// <summary>Translates a single digit in the range 0-9 to a word.</summary>
        /// <param name="digit">The digit to be converted to a word.</param>
        /// <returns>A <see cref="string"/> of the digit represented as a word.</returns>
        public static string ConvertSingleDigitNumberToString(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new ArgumentException("Invalid number provided.");
            }
        }

        /// <summary>Finds the maximal of the given parameters.</summary>
        /// <param name="elements">Parameter collection of <see cref="int"/> numbers.</param>
        /// <returns>The maximal element.</returns>
        public static int FindMaxElement(params int[] elements)
        {
            if (!ValidParameterCollection(elements))
            {
                throw new ArgumentException("Invalid parameters provided. All params should be int numbers.");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        /// <summary>Applies custom formatting rules on a given number.</summary>
        /// <param name="number">The number to be formatted.</param>
        /// <param name="format">A predefined formatting string to apply to the <paramref name="number"/>.</param>
        public static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        /// <summary>
        /// Calculates a line length out of a given coordinates.
        /// <para>Additionally outputs flags <paramref name="isHorizontal"/> and <paramref name="isVertical"/> to indicate if the line is aligned horizontally or vertically.</para>
        /// </summary>
        /// <param name="x1">The X1 coordinate of the line.</param>
        /// <param name="y1">The Y1 coordinate of the line.</param>
        /// <param name="x2">The X2 coordinate of the line.</param>
        /// <param name="y2">The Y2 coordinate of the line.</param>
        /// <param name="isHorizontal">Is the line horizontally aligned.</param>
        /// <param name="isVertical">Is the line vertically aligned.</param>
        /// <returns></returns>
        public static double CalculateLineLength(
            double x1,
            double y1,
            double x2,
            double y2,
            out bool isHorizontal,
            out bool isVertical)
        {
            double width = Math.Abs(y2 - y1);
            double height = Math.Abs(x2 - x1);

            isHorizontal = y1 == y2;
            isVertical = x1 == x2;

            double length = Math.Sqrt((height * height) + (width * width));

            return length;
        }

        private static bool ValidTriangleSides(double sideA, double sideB, double sideC)
        {
            var result = true;

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                result = false;
            }

            if (sideA + sideB < sideC ||
                sideB + sideC < sideA ||
                sideA + sideC < sideB)
            {
                result = false;
            }

            return result;
        }

        private static bool ValidParameterCollection(params int[] elements)
        {
            var result = true;

            if (elements == null || elements.Length == 0)
            {
                result = false;
            }

            return result;
        }
    }
}
