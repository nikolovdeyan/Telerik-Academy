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

            int turnRow;
            int turnCol;
            string command = string.Empty;

            Score playerScore = null;
            List<Score> highScores = null;

            State state = State.Initial;

            do
            {
                if (state.firstMoveForRound)
                {
                    Console.WriteLine(Constants.Messages.Welcome);
                    Field.DisplayField(state.displayField, true);
                    state.firstMoveForRound = false;
                }

                GetNextCommand(ref command, out turnRow, out turnCol);
                switch (command)
                {
                    case "top":
                        Field.DisplayHighScores(highScores);
                        Field.DisplayField(state.displayField, true);
                        break;

                    case "restart":
                        Console.Clear();
                        state = State.Initial;
                        break;

                    case "exit":
                        Console.Clear();
                        Console.WriteLine(Constants.Messages.Exit);
                        break;

                    case "turn":
                        if (state.playingField[turnRow, turnCol] != Constants.TileSymbols.Mine)
                        {
                            // didn't step on a mine, now check if stepped on a valid unopened tile
                            if (state.playingField[turnRow, turnCol] == Constants.TileSymbols.Empty)
                            {
                                state.score++;
                                Field.UpdatePlayingFieldOnSuccessfulMove(
                                                                        ref state.displayField,
                                                                        ref state.playingField,
                                                                        turnRow,
                                                                        turnCol);
                            }

                            if (state.score == ScoreToWin)
                            {
                                state.roundIsWon = true;
                            }
                            else
                            {
                                Field.DisplayField(state.displayField);
                            }
                        }
                        else
                        {
                            state.roundIsLost = true;
                        }

                        break;
                    default:
                        Console.WriteLine(Constants.Messages.BadInputError);
                        break;
                }

                if (state.roundIsLost)
                {
                    Field.DisplayField(state.playingField);

                    Console.WriteLine(Constants.Messages.Defeat, state.score);

                    SetPlayerScore(state.score, ref playerScore);

                    UpdateHighScores(ref playerScore, ref highScores);

                    Field.DisplayHighScores(highScores);

                    state = State.Initial;
                }

                if (state.roundIsWon)
                {
                    Field.DisplayField(state.playingField);

                    Console.WriteLine(Constants.Messages.Victory);

                    SetPlayerScore(state.score, ref playerScore);

                    UpdateHighScores(ref playerScore, ref highScores);

                    Field.DisplayHighScores(highScores);

                    state = State.Initial;
                }
            }
            while (command != "exit");

            // Termination
            Console.WriteLine(Constants.Messages.ExitProgram);
        }

        private static void GetNextCommand(
                                           ref string command,
                                           out int turnRow,
                                           out int turnCol)
        {
            turnRow = -1;
            turnCol = -1;

            Console.Write(Constants.Messages.AskInput);
            command = Console.ReadLine().Trim();

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