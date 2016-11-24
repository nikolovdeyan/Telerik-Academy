using System;
using System.Linq;

class LargestAreaInMatrix
{
    static void Main()
    {
        string text = Console.ReadLine();

        var result = text
            .Split(' ')
            .Select(z => Convert.ToInt16(z))
            .ToArray();
        short rows = result[0];
        short cols = result[1];
        var matrix = new short?[rows][];

        for (short i = 0; i < rows; i++)
        {
            matrix[i] = new short?[cols];
        }

        for (short i = 0; i < rows; i++)
        {
            text = null;
            text = Console.ReadLine();
            result = text
            .Split(' ')
            .Select(z => Convert.ToInt16(z))
            .ToArray();
            text = null;
            for (short j = 0; j < cols; j++)
            {
                matrix[i][j] = result[j];
            }
        }

        short max = 1;
        short counter = 0;
        short? current;

        for (short i = 0; i < rows; i++)
        {
            for (short j = 0; j < cols; j++)
            {
                counter = 0;
                if (matrix[i][j] == null)
                {
                    continue;
                }
                else
                {
                    counter = 1;
                    current = matrix[i][j];
                    matrix[i][j] = null;

                    counter = CheckNeighbours(matrix, i, j, ref current, ref counter);
                    if (counter > max)
                    {
                        max = counter;
                    }
                }

            }
        }

        Console.WriteLine(max);
    }

    static short CheckNeighbours(short?[][] matrix, short row, short col, ref short? curent, ref short counter)
    {
        
        if (col > 0 && matrix[row][col - 1] == curent) 
        {
            counter++;
            matrix[row][col - 1] = null;
            counter = CheckNeighbours(matrix, row, (short)(col - 1), ref curent, ref counter);
        }
        
        if (row < matrix.Length - 1 && matrix[row + 1][col] == curent)
        {
            counter++;
            matrix[row + 1][col] = null;
            counter = CheckNeighbours(matrix, (short)(row + 1), col, ref curent, ref counter);
        }

        if (col < matrix[row].Length - 1 && matrix[row][col + 1] == curent)
        {
            counter++;
            matrix[row][col + 1] = null;
            counter = CheckNeighbours(matrix, row, (short)(col + 1), ref curent, ref counter);
        }

        if (row > 0 && matrix[row - 1][col] == curent)
        {
            counter++;
            matrix[row - 1][col] = null;
            counter = CheckNeighbours(matrix, (short)(row - 1), col, ref curent, ref counter);
        }

        return counter;
    }
}