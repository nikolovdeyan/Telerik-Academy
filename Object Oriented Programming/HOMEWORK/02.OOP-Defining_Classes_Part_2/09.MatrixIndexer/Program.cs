using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the Matrix indexer
            // First creating a matrix of strings and assigning it to Matrix<T>
            string[,] myPlanesArray = new string[,]
                { { "Boeing 727", "Boeing 737", "Boeing 747", "Boeing 757", "Boeing 767", "Boeing 777" },
                  { "Airbus 319", "Airbus 320", "Airbus 321", "Airbus 330", "Airbus 340", "Airbus 380" } };

            Matrix<string> myStringMatrix = new Matrix<string>(myPlanesArray);

            // Printing the created matrix
            Console.WriteLine("*****************************************************");
            Console.WriteLine("My string matrix:");
            Console.WriteLine("Dimensions: width: {0}, height: {1}", myStringMatrix.Cols, myStringMatrix.Rows);
            Console.WriteLine(myStringMatrix.ToString());

            // Testing the indexer
            Console.WriteLine("*****************************************************");
            Console.WriteLine("What is at position [0,2]?:");
            Console.WriteLine("{0}", myStringMatrix[0,2]);
            Console.WriteLine();

            // Replacing an item and printing the matrix again
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Airbus A340 is an old model. Lets replace it!");
            myStringMatrix[1, 4] = "Airbus 350";
            Console.WriteLine("My string matrix, updated:");

            Console.WriteLine(myStringMatrix.ToString()); 
        }
    }
}
