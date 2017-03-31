using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixIndexer
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

        // Implement the matrix indexer
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
