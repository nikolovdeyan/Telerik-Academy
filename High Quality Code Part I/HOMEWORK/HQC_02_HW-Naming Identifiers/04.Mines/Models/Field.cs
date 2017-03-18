using Minesweeper.Common;
using Minesweeper.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.Models
{
    internal static class Field
    {
        internal static void DisplayField(char[,] playingField)
        {
            int rows = playingField.GetLength(0);
            int cols = playingField.GetLength(1);

            Console.WriteLine(Constants.Field.PlayingFieldTopBorder);

            for (int r = 0; r < rows; r++)
            {
                Console.Write("{0} | ", r); // Playfield left border

                for (int c = 0; c < cols; c++)
                {
                    Console.Write(string.Format("{0} ", playingField[r, c]));
                }

                Console.Write("|"); // Playfield right border

                Console.WriteLine();
            }

            Console.WriteLine(Constants.Field.PlayingFieldBottomBorder);
        }

        internal static void DisplayHighScores(List<Score> highScorePoints)
        {
            Console.WriteLine(Constants.Messages.Points);

            if (highScorePoints.Count > 0)
            {
                for (int i = 0; i < highScorePoints.Count; i++)
                {
                    Console.WriteLine(
                        "{0}. {1} --> {2} tiles",
                        i + 1,
                        highScorePoints[i].PlayerName,
                        highScorePoints[i].PlayerScore);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        internal static char[,] GetNewDisplayField()
        {
            int fieldRows = Constants.GameSettings.PlayingFieldRows;
            int fieldCols = Constants.GameSettings.PlayingFieldCols;

            char[,] playingField = new char[fieldRows, fieldCols];

            for (int r = 0; r < fieldRows; r++)
            {
                for (int c = 0; c < fieldCols; c++)
                {
                    playingField[r, c] = Constants.TileSymbols.Unchecked;
                }
            }

            return playingField;
        }

        internal static char[,] GetNewPlayingField()
        {
            const char EmptyTile = Constants.TileSymbols.Empty;

            int fieldRows = Constants.GameSettings.PlayingFieldRows;
            int fieldCols = Constants.GameSettings.PlayingFieldCols;
            char[,] playField = new char[fieldRows, fieldCols];
            List<int> mineTileIndices = new List<int>();
            Random random = new Random();

            // fill the field with '-'
            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldCols; j++)
                {
                    playField[i, j] = EmptyTile;
                }
            }

            // place mines 'randomly'
            while (mineTileIndices.Count < 15)
            {
                // int tileIndexDrawn = random.Next(50);
                int tileIndexDrawn = Randomizer.GetRandomSeed().Next(50);

                if (!mineTileIndices.Contains(tileIndexDrawn))
                {
                    mineTileIndices.Add(tileIndexDrawn);
                }
            }

            foreach (int tileIndex in mineTileIndices)
            {
                int mineRow = tileIndex % fieldCols;
                int mineCol = tileIndex / fieldCols;

                if (mineRow == 0 && tileIndex != 0)
                {
                    mineCol--;
                    mineRow = fieldCols;
                }
                else
                {
                    mineRow++;
                }

                playField[mineCol, mineRow - 1] = Constants.TileSymbols.Mine;
            }

            return playField;
        }

        internal static void UpdatePlayingFieldOnSuccessfulMove(
                                        ref char[,] displayField,
                                        ref char[,] playingField,
                                        int turnRow,
                                        int turnCol)
        {
            char countOfSurroundingMines = GetSurroundingMinesCount(playingField, turnRow, turnCol);
            Console.WriteLine(countOfSurroundingMines);
            displayField[turnRow, turnCol] = countOfSurroundingMines;
            playingField[turnRow, turnCol] = countOfSurroundingMines;
        }

        internal static char GetSurroundingMinesCount(
                                        char[,] playingField,
                                        int tileRow,
                                        int tileCol)
        {
            int count = 0;
            int minRow = 0;
            int minCol = 0;
            int maxRow = playingField.GetLength(0) - 1;
            int maxCol = playingField.GetLength(1) - 1;

            int startTileRow = (tileRow - 1 < minRow) ? tileRow : tileRow - 1;
            int startTileCol = (tileCol - 1 < minCol) ? tileCol : tileCol - 1;
            int endTileRow = (tileRow + 1 > maxRow) ? tileRow : tileRow + 1;
            int endTileCol = (tileCol + 1 > maxCol) ? tileCol : tileCol + 1;

            // Traverses the surrounding tiles to test for mines
            for (int row = startTileRow; row <= endTileRow; row++)
            {
                for (int col = startTileCol; col <= endTileCol; col++)
                {
                    if (playingField[row, col] == Constants.TileSymbols.Mine)
                    {
                        count++;
                    }
                }
            }

            return char.Parse(count.ToString());
        }
    }
}