using System;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            string[] arrayNM = Console.ReadLine().Split(' ');

            int rows = int.Parse(arrayNM[0]);
            int cols = int.Parse(arrayNM[1]);
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int counter = 1;
            int maxCounter = int.MinValue;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
                counter = 1;
            }

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                }
                counter = 1;
            }

            for (int col = 0; col < cols; col++)
            {
                int row = 0;
                int col1 = col;
                while (row < rows - 1 && col1 < cols - 1)
                {
                    if (matrix[row, col1] == matrix[row + 1, col1 + 1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                    row++;
                    col1++;
                }
                counter = 1;
            }
            for (int row = 0; row < rows; row++)
            {
                int col = 0;
                int row1 = row;
                while (row1 < rows - 1 && col < cols - 1)
                {
                    if (matrix[row1, col] == matrix[row1 + 1, col + 1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                    row1++;
                    col++;
                }
                counter = 1;
            }

            for (int col = cols - 1; col > 0; col--)
            {
                int row = 0;
                int col1 = col;
                while (row < rows - 1 && col1 > 0)
                {
                    if (matrix[row, col1] == matrix[row + 1, col1 - 1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                    row++;
                    col1--;
                }
                counter = 1;
            }


            for (int row = 0; row < rows; row++)
            {
                int col = cols - 1;
                int row1 = row;
                while (row1 < rows - 1 && col > 0)
                {
                    if (matrix[row1, col] == matrix[row1 + 1, col - 1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }
                    row1++;
                    col--;
                }
                counter = 1;
            }

            Console.WriteLine(maxCounter);
        }
    }
}