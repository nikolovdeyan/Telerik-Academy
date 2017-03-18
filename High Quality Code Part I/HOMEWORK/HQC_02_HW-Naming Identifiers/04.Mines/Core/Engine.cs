using Minesweeper.Models;
using Minesweeper.Common;
using System;
using System.Collections.Generic;

namespace Minesweeper.Core
{
    public static class Engine
    {
        public static void ParsePlayerTurn(
                                        string userInput,
                                        out string command,
                                        out int turnRow,
                                        out int turnCol)
        {
            turnRow = -1;
            turnCol = -1;
            command = string.Empty;

            if (userInput.Length >= 3)
            {
                bool validRowNumber = int.TryParse(userInput[0].ToString(), out turnRow);
                bool validColNumber = int.TryParse(userInput[2].ToString(), out turnCol);

                if (validRowNumber &&
                    validColNumber &&
                    turnRow <= Constants.GameSettings.PlayingFieldRows &&
                    turnCol <= Constants.GameSettings.PlayingFieldCols)
                {
                    command = "turn";
                }
            }
        }

        public static void SetUpNewRound(
                                                ref char[,] displayField,
                                                ref char[,] playingField,
                                                ref int scoreCount,
                                                ref bool gameIsLost,
                                                ref bool gameIsStarting,
                                                ref bool gameIsWon)
        {
            displayField = Field.GetNewDisplayField();

            playingField = Field.GetNewPlayingField();

            scoreCount = Constants.GameSettings.StartingPoints;

            gameIsLost = false;

            gameIsStarting = true;

            gameIsWon = false;
        }

        public static void Logic()
        {
            const int ScoreToWin = Constants.GameSettings.PointsNeededToWin;

            char[,] displayField = Field.GetNewDisplayField();
            char[,] playingField = Field.GetNewPlayingField();
            int score = 0;
            bool roundIsLost = false;
            bool firstMoveForRound = true;
            bool roundIsWon = false;
            int turnRow;
            int turnCol;
            string command = string.Empty;

            List<Score> highScores = new List<Score>(6);

            do
            {
                if (firstMoveForRound)
                {
                    Console.WriteLine(Constants.Messages.Welcome);

                    Field.DisplayField(displayField);

                    firstMoveForRound = false;
                }

                Console.Write(Constants.Messages.AskInput);

                var userInput = Console.ReadLine().Trim();

                Engine.ParsePlayerTurn(userInput, out command, out turnRow, out turnCol);

                Console.WriteLine(command);

                switch (command)
                {
                    case "top":
                        Field.DisplayHighScores(highScores);
                        break;
                    case "restart":
                        displayField = Field.GetNewDisplayField();
                        playingField = Field.GetNewPlayingField();
                        Field.DisplayField(displayField);
                        roundIsLost = false;
                        roundIsWon = false;
                        break;
                    case "exit":
                        Console.WriteLine(Constants.Messages.ExitProgram);
                        break;
                    case "turn":
                        if (playingField[turnRow, turnCol] != Constants.TileSymbols.Mine)
                        {
                            // didn't step on a mine, now check if stepped on a valid unopened tile
                            if (playingField[turnRow, turnCol] == Constants.TileSymbols.Empty)
                            {
                                score++;
                                Field.UpdatePlayingFieldOnSuccessfulMove(
                                                                        ref displayField,
                                                                        ref playingField,
                                                                        turnRow,
                                                                        turnCol);
                            }

                            if (score == ScoreToWin)
                            {
                                roundIsWon = true;
                            }
                            else
                            {
                                Field.DisplayField(displayField);
                            }
                        }
                        else
                        {
                            roundIsLost = true;
                        }

                        break;
                    default:
                        Console.WriteLine(Constants.Messages.BadInputError);
                        break;
                }

                if (roundIsLost)
                {
                    Field.DisplayField(playingField);
                    Console.WriteLine(Constants.Messages.Defeat, score);

                    // High score check initiated
                    string playerName = Console.ReadLine();

                    Score playerScore = new Score(playerName, score);

                    if (highScores.Count < 5)
                    {
                        highScores.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].PlayerScore < playerScore.PlayerScore)
                            {
                                highScores.Insert(i, playerScore);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((Score r1, Score r2) => r2.PlayerName.CompareTo(r1.PlayerName));
                    highScores.Sort((Score r1, Score r2) => r2.PlayerScore.CompareTo(r1.PlayerScore));

                    Field.DisplayHighScores(highScores);
                }

                if (roundIsWon)
                {
                    Console.WriteLine(Constants.Messages.Victory);

                    Field.DisplayField(playingField);

                    // High score add initiated
                    Console.WriteLine(Constants.Messages.AskName);
                    string playerName = Console.ReadLine();
                    Score playerPoints = new Score(playerName, score);
                    highScores.Add(playerPoints);
                    Field.DisplayHighScores(highScores);
                }
            }
            while (command != "exit");

            // Termination
            Console.WriteLine(Constants.Messages.ExitProgram);
        }
    }
}