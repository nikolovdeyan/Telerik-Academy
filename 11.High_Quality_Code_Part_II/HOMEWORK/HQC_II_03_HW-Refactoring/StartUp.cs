using System;
using MatrixTraverser.Common;
using MatrixTraverser.Contracts;
using MatrixTraverser.Providers;
using MatrixTraverser.Models;

namespace MatrixTraverser.Core
{
    class WalkInMatrica
    {
        static void change(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };

            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int cd = 0;

            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == dx && dirY[count] == dy) { cd = count; break; }
            }

            if (cd == 7) { dx = dirX[0]; dy = dirY[0]; return; }
            dx = dirX[cd + 1];


            dy = dirY[cd + 1];
        }

        static bool NextMoveIsValid(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };

            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0) dirX[i] = 0;


                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0) dirY[i] = 0;
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0) return true;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="tileCoordinateX"></param>
        /// <param name="tileCoordinateY"></param>
        static void GetNextValidTile(int[,] arr, out int tileCoordinateX, out int tileCoordinateY)
        {
            tileCoordinateX = 0;

            tileCoordinateY = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        tileCoordinateX = i;
                        tileCoordinateY = j;

                        return;
                    }
                }
            }
        }

        // ##################################################################### 

        /// <summary>Takes an user input number between 1 and 100</summary>
        /// <returns>The user input parsed as an int</returns>
        static int GetMatrixDimensions(IWriter writer, IReader reader)
        {
            writer.WriteLine("Enter a positive number between 1 and 100:");

            string userInput = reader.ReadLine();

            int parsedInput = 0;

            while (!int.TryParse(userInput, out parsedInput) ||
                parsedInput < Constants.minimumMatrixSizeNumber ||
                parsedInput > Constants.maximumMatrixSizeNumber)
            {
                writer.WriteLine("You haven't entered a correct positive number");

                userInput = reader.ReadLine();
            }

            return parsedInput;
        }

        // ##################################################################### 

        static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
            IReader reader = new ConsoleReader();

            int matrixSize = GetMatrixDimensions(writer, reader);

            // Matrix matrix = new Matrix(matrixDimensions);

            int[,] matrix = new int[matrixSize, matrixSize];

            Bearing bearing = new Bearing(Constants.startDirectionRow, Constants.startDirectionCol);

            int step = matrixSize,
                index = 1,
                nextRow = 0,
                nextCol = 0;

            while (true)
            {
                matrix[nextRow, nextCol] = index;

                if (!NextMoveIsValid(matrix, nextRow, nextCol))
                {
                    break;
                }

                if (nextRow + bearing.y >= matrixSize || 
                    nextRow + bearing.y < 0 || 
                    nextCol + bearing.x >= matrixSize || 
                    nextCol + bearing.x < 0 || 
                    matrix[nextRow + bearing.y, nextCol + bearing.x] != 0)
                {
                    while ((nextRow + bearing.y >= matrixSize || 
                        nextRow + bearing.y < 0 || 
                        nextCol + bearing.x >= matrixSize || 
                        nextCol + bearing.x < 0 || 
                        matrix[nextRow + bearing.y, nextCol + bearing.x] != 0))
                    {
                        change(ref bearing.y, ref bearing.x);
                    }
                }
                    
                nextRow += bearing.y; nextCol += bearing.x; index++;
            }

            for (int p = 0; p < matrixSize; p++)
            {
                for (int q = 0; q < matrixSize; q++) Console.Write("{0,3}", matrix[p, q]);
                Console.WriteLine();
            }

            GetNextValidTile(matrix, out nextRow, out nextCol);

            if (nextRow != 0 && nextCol != 0)
            {
                bearing.y = 1; bearing.x = 1;


                while (true)
                {
                    matrix[nextRow, nextCol] = index;
                    if (!NextMoveIsValid(matrix, nextRow, nextCol)) { break; }// prekusvame ako sme se zadunili
                    if (nextRow + bearing.y >= matrixSize || nextRow + bearing.y < 0 || nextCol + bearing.x >= matrixSize || nextCol + bearing.x < 0 || matrix[nextRow + bearing.y, nextCol + bearing.x] != 0)


                        while ((nextRow + bearing.y >= matrixSize || 
                            nextRow + bearing.y < 0 || 
                            nextCol + bearing.x >= matrixSize || 
                            nextCol + bearing.x < 0 || 
                            matrix[nextRow + bearing.y, nextCol + bearing.x] != 0))
                        {
                            change(ref bearing.y, ref bearing.x);
                        }
                            
                    nextRow += bearing.y; nextCol += bearing.x; index++;
                }
            }

            for (int pp = 0; pp < matrixSize; pp++)
            {
                for (int qq = 0; qq < matrixSize; qq++)
                {
                    Console.Write("{0,3}", matrix[pp, qq]);
                }

                Console.WriteLine();
            }
        }
    }
}
