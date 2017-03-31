using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Matrix
{
    public class Matrix<T>
    {
        // CONSTANTS
        private const int defaultWidth = 2;
        private const int defaultHeight = 2;

        // FIELDS
        private int rows;
        private int cols;
        private T[,] contents;

        // CONSTRUCTORS
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

        // PROPERTIES
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
            private set { this.contents = value; }
        }

        // METHODS
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
