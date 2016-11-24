using System;

class MaximalSum
{
    static void Main()
    {
        string[] arrayNM = Console.ReadLine().Split(' ');
        long n = int.Parse(arrayNM[0]);
        long m = int.Parse(arrayNM[1]);

        long[,] matrix = new long[n, m];

        for (int row = 0; row < n; row++)
        {
            string[] rowsNum = Console.ReadLine().Split(' ');

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = int.Parse(rowsNum[col]);
            }
        }

        long bestSum = int.MinValue;
        long sum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                      + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                      + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine(bestSum);
    }

    private static void PrintMatrix(int[,] matrix, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (j == m - 1)
                {
                    Console.Write("{0}", matrix[i, j]);
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