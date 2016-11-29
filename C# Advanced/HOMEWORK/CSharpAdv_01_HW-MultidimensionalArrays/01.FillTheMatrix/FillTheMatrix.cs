using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string matrixType = Console.ReadLine();
        int[,] matrix = new int[n, n];

        // build the matrix
        // Matrix Type A
        if (matrixType == "a")
        {
            int numA = 1;

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = numA;
                    numA++;
                }
            }
        }
        // Matrix Type B
        else if (matrixType == "b")
        {
            int numB = 1;

            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = numB;
                        numB++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = numB;
                        numB++;
                    }
                }
            }
        }
        // Matrix Type C
        else if (matrixType == "c")
        {
            int numC = 1;
            int rows = 0;
            int cols = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;

                while (rows < n && cols < n)
                {
                    matrix[rows++, cols++] = numC++;
                }
            }
            for (int j = 1; j < n; j++)
            {
                rows = j;
                cols = 0;

                while (rows < n && cols < n)
                {
                    matrix[cols++, rows++] = numC++;
                }
            }
        }
        // Matrix Type D
        else
        {
            int numD = 1;
            int rows = 0;
            int cols = 0;
            int rowsEnd = n - 1;
            int colsEnd = n - 1;

            do
            {
                for (int i = rows; i <= rowsEnd; i++)
                {
                    matrix[i, cols] = numD;
                    numD++;
                }
                cols++;

                for (int i = cols; i <= colsEnd; i++)
                {
                    matrix[rowsEnd, i] = numD;
                    numD++;
                }
                rowsEnd--;

                for (int i = rowsEnd; i >= rows; i--)
                {
                    matrix[i, colsEnd] = numD;
                    numD++;
                }
                colsEnd--;

                for (int i = colsEnd; i >= cols; i--)
                {
                    matrix[rows, i] = numD;
                    numD++;
                }
                rows++;
            } while (numD <= n * n);
        }

        // print the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == n - 1)
                {
                    Console.Write(matrix[i, j]);
                }
                else
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
            }
            Console.WriteLine();
        }

    }
}