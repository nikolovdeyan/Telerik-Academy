using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructing an integer matrix with the default constructor
            Matrix<int> myIntMatrix = new Matrix<int>();

            Console.WriteLine("*****************************************************");
            Console.WriteLine("My integer matrix:");
            Console.WriteLine("Dimensions: width: {0}, height: {0}", myIntMatrix.Cols, myIntMatrix.Rows);
            Console.WriteLine(myIntMatrix.ToString());

            // Constructing a double matrix with given width and height. 
            Matrix<double> myDoubleMatrix = new Matrix<double>(6, 3);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("My double matrix:");
            Console.WriteLine("Dimensions: width: {0}, height: {1}", myDoubleMatrix.Cols, myDoubleMatrix.Rows);
            Console.WriteLine(myDoubleMatrix.ToString());

            // Constructing a char matrix with given contents.
            char[,] myCharArray = new char[,]
                { { 'a', 'b', 'c', 'd', 'e' },
                  { 'f', 'g', 'h', 'i', 'j' },
                  { 'k', 'l', 'm', 'n', 'o' },
                  { 'p', 'q', 'r', 's', 't' } };
            Matrix<char> myCharMatrix = new Matrix<char>(myCharArray);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("My char matrix:");
            Console.WriteLine("Dimensions: width: {0}, height: {1}", myCharMatrix.Cols, myCharMatrix.Rows);
            Console.WriteLine(myCharMatrix.ToString());

        }
    }
}
