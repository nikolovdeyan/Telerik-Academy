using Minesweeper.Models;
using Minesweeper.Common;
using System;
using System.Collections.Generic;

namespace Minesweeper.Core
{
    public static class Engine
    {
        internal static void Logic()
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

            Score playerScore = null;
            List<Score> highScores = null;

            do
            {
                if (firstMoveForRound)
                {
                    Console.WriteLine(Constants.Messages.Welcome);

                    Field.DisplayField(displayField);

                    firstMoveForRound = false;
                }

                Console.Write(Constants.Messages.AskInput);

                command = Console.ReadLine().Trim();

                ParsePlayerTurn(ref command, out turnRow, out turnCol);

                switch (command)
                {
                    case "top":
                        Field.DisplayHighScores(highScores);
                        break;
                    case "restart":
                        StartNewRound(
                                     ref displayField,
                                     ref playingField,
                                     ref score,
                                     ref roundIsLost,
                                     ref firstMoveForRound,
                                     ref roundIsWon);

                        Field.DisplayField(displayField);

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

                    SetPlayerScore(score, ref playerScore);

                    UpdateHighScores(ref playerScore, ref highScores);

                    Field.DisplayHighScores(highScores);

                    StartNewRound(
                                 ref displayField,
                                 ref playingField,
                                 ref score,
                                 ref roundIsLost,
                                 ref firstMoveForRound,
                                 ref roundIsWon);
                }

                if (roundIsWon)
                {
                    Field.DisplayField(playingField);

                    Console.WriteLine(Constants.Messages.Victory);

                    SetPlayerScore(score, ref playerScore);

                    UpdateHighScores(ref playerScore, ref highScores);

                    Field.DisplayHighScores(highScores);

                    StartNewRound(
                                 ref displayField,
                                 ref playingField,
                                 ref score,
                                 ref roundIsLost,
                                 ref firstMoveForRound,
                                 ref roundIsWon);
                }
            }
            while (command != "exit");

            // Termination
            Console.WriteLine(Constants.Messages.ExitProgram);
        }

        private static void ParsePlayerTurn(
                                           ref string command,
                                           out int turnRow,
                                           out int turnCol)
        {
            turnRow = -1;
            turnCol = -1;

            if (command.Length >= 3)
            {
                bool validRowNumber = int.TryParse(command[0].ToString(), out turnRow);
                bool validColNumber = int.TryParse(command[2].ToString(), out turnCol);

                if (validRowNumber &&
                    validColNumber &&
                    turnRow <= Constants.GameSettings.PlayingFieldRows &&
                    turnCol <= Constants.GameSettings.PlayingFieldCols)
                {
                    command = "turn";
                }
            }
        }

        private static void StartNewRound(
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

        private static void SetPlayerScore(int score, ref Score playerScore)
        {
            Console.WriteLine(Constants.Messages.AskUserName);
            string playerName = Console.ReadLine();

            playerScore = new Score(playerName, score);
        }

        private static void UpdateHighScores(ref Score playerScore, ref List<Score> highScores)
        {
            if (highScores == null)
            {
                highScores = new List<Score>(6);
            }

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
        }
    }
}