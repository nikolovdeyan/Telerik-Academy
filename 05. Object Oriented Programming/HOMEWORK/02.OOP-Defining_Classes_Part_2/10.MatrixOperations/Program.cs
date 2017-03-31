using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // TEST 1 -- Integer Matrices
            // Constructing two integer matrices with matching dimensions
            int[,] integerArray1 = new int[,]
                { { 0, 0, 0 },
                  { 1, 1, 1 },
                  { 2, 2, 2 } };
            int[,] integerArray2 = new int[,]
                { { 1, 2, 3 },
                  { 1, 2, 3 },
                  { 1, 2, 3 } };

            Matrix<int> intMatrix1 = new Matrix<int>(integerArray1);
            Matrix<int> intMatrix2 = new Matrix<int>(integerArray2);

            // Printing the created matrices
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Testing a Matrix<int>:");
            Console.WriteLine("Matrix 1:");
            Console.WriteLine(intMatrix1.ToString());
            Console.WriteLine("Matrix 2:");
            Console.WriteLine(intMatrix2.ToString());

            // Adding the matrices together and printing the result
            Console.WriteLine("Matrix 1 + Matrix 2:");
            Console.WriteLine(intMatrix1 + intMatrix2);

            // Subtracting the matrices and printing the result
            Console.WriteLine("Matrix 1 - Matrix 2:");
            Console.WriteLine(intMatrix1 - intMatrix2);

            // Multiplying the matrices and printing the result
            Console.WriteLine("Matrix 1 * Matrix 2:");
            Console.WriteLine(intMatrix1 * intMatrix2);

            // TEST 2 -- Double Matrices
            // Constructing two double matrices with matching dimensions
            double[,] doubleArray1 = new double[,]
                { { 0.0, 0.0, 0.0 },
                  { 1.25, 1.25, 1.25 },
                  { 20.750, 20.750, 20.750 } };
            double[,] doubleArray2 = new double[,]
                { { 0.0, 1.0, 2.0 },
                  { 1.5, 5.725, 25.100 },
                  { 1.5, 5.725, 25.100 } };

            Matrix<double> charMatrix1 = new Matrix<double>(doubleArray1);
            Matrix<double> charMatrix2 = new Matrix<double>(doubleArray2);
            // Printing the created matrices
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Testing a Matrix<double>:");
            Console.WriteLine("Matrix 1:");
            Console.WriteLine(charMatrix1.ToString());
            Console.WriteLine("Matrix 2:");
            Console.WriteLine(charMatrix2.ToString());

            // Adding the matrices together and printing the result
            Console.WriteLine("Matrix 1 + Matrix 2:");
            Console.WriteLine(charMatrix1 + charMatrix2);

            // Subtracting the matrices and printing the result
            Console.WriteLine("Matrix 1 - Matrix 2:");
            Console.WriteLine(charMatrix1 - charMatrix2);

            // Multiplying the matrices and printing the result
            Console.WriteLine("Matrix 1 * Matrix 2:");
            Console.WriteLine(charMatrix1 * charMatrix2);

            // TEST 3 -- String Matrices
            // Constructing two string matrices with matching dimensions
            string[,] stringArray1 = new string[,]
                { { "do", "do"},
                  { "re", "re"} };
            string[,] stringArray2 = new string[,]
                { { "mi", "fa"},
                  { "mi", "fa"} };

            Matrix<string> stringMatrix1 = new Matrix<string>(stringArray1);
            Matrix<string> stringMatrix2 = new Matrix<string>(stringArray2);
            // Printing the created matrices
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Testing a Matrix<string>:");
            Console.WriteLine("Matrix 1:");
            Console.WriteLine(stringMatrix1.ToString());
            Console.WriteLine("Matrix 2:");
            Console.WriteLine(stringMatrix2.ToString());

            // Adding the matrices together and printing the result -- Concatenates the strings
            Console.WriteLine("Matrix 1 + Matrix 2:");
            Console.WriteLine(stringMatrix1 + stringMatrix2);

            // Subtracting or multiplying the strings will trigger an exception
            Console.WriteLine("Matrix 1 - Matrix 2:");
            Console.WriteLine(stringMatrix1 - stringMatrix2);
            Console.WriteLine("Matrix 1 * Matrix 2:");
            Console.WriteLine(stringMatrix1 * stringMatrix2);
        }
    }
}
