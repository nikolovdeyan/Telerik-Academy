using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MatrixOperations
{
    public class Matrix<T>
    {
        private const int defaultWidth = 2;
        private const int defaultHeight = 2;

        private int rows;
        private int cols;
        private T[,] contents;

        public Matrix()
            : this(defaultWidth, defaultHeight)
        {
        }
        public Matrix(int width, int height)
        {
            this.Cols = width;
            this.Rows = height;
            this.Contents = new T[Rows, Cols];
        }
        public Matrix(T[,] array)
        {
            this.Cols = array.GetLength(1);
            this.Rows = array.GetLength(0);
            this.Contents = array;
        }

        public int Rows
        {
            get { return this.rows; }
            set { this.rows = value; }
        }
        
        public int Cols
        {
            get { return this.cols; }
            set { this.cols = value; }
        }

        public T[,] Contents
        {
            get { return this.contents; }
            set { this.contents = value; }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.Contents[row, col];
            }
            set
            {
                if (row < 0 || row > this.Rows || col < 0 || col > this.Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    this.Contents[row, col] = value;
                }
            }
        }

        // Overriding the addition (+) operator
        public static Matrix<T> operator + (Matrix<T> matrix1, Matrix<T> matrix2)
        {
            // First check if matrices' dimensions match
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new InvalidOperationException("Matrices' dimensions must be the same!");
            }

            // Adding the contents of the matrices
            Matrix<T> sumMatrix = new Matrix<T>(matrix1.Cols, matrix1.Rows);

            for (int row = 0; row < sumMatrix.Rows; row++)
            {
                for (int col = 0; col < sumMatrix.Cols; col++)
                {
                    sumMatrix[row, col] = (T)((dynamic)matrix1[row, col] + (dynamic)matrix2[row, col]);
                }
            }

            // Finally, return the resulting matrix
            return sumMatrix;
        }

        // Overriding the subtraction (-) operator
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            // First check if matrices' dimensions match
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new InvalidOperationException("Matrices' dimensions must be the same!");
            }

            // Subtracting the contents of the matrices
            Matrix<T> sumMatrix = new Matrix<T>(matrix1.Cols, matrix1.Rows);

            for (int row = 0; row < sumMatrix.Rows; row++)
            {
                for (int col = 0; col < sumMatrix.Cols; col++)
                {
                    try
                    {
                        sumMatrix[row, col] = (T)((dynamic)matrix1[row, col] - (dynamic)matrix2[row, col]);
                    }
                    catch(RuntimeBinderException) 
                    {
                        Console.WriteLine("Can't subtract matrices of the given type!");
                    }
                }
            }

            // Finally, return the resulting matrix
            return sumMatrix;
        }

        // Overriding the multiplication (*) operator
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            // First check if matrices' dimensions match
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new InvalidOperationException("Matrices' dimensions must be the same!");
            }

            // Multiplying the contents of the matrices
            Matrix<T> sumMatrix = new Matrix<T>(matrix1.Cols, matrix1.Rows);

            for (int row = 0; row < sumMatrix.Rows; row++)
            {
                for (int col = 0; col < sumMatrix.Cols; col++)
                {
                    try
                    {
                        sumMatrix[row, col] = (T)((dynamic)matrix1[row, col] * (dynamic)matrix2[row, col]);
                    }
                    catch (RuntimeBinderException)
                    {
                        Console.WriteLine("Can't multiply matrices of the given type!");
                    }
                }
            }

            // Finally, return the resulting matrix
            return sumMatrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    sb.AppendFormat("{0} ", this.Contents[i, j]);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
