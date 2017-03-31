namespace Minesweeper.Common
{
    internal static class Constants
    {
        internal static class TileSymbols
        {
            internal const char Unchecked = '?';
            internal const char Mine = '*';
            internal const char Empty = '-';
        }

        internal static class GameSettings
        {
            internal const int PlayingFieldRows = 5;
            internal const int PlayingFieldCols = 10;
            internal const int PointsNeededToWin = 35;
            internal const int StartingPoints = 0;
        }

        internal static class Field
        {
            internal const string PlayingFieldTopBorder =
    @"
    0 1 2 3 4 5 6 7 8 9
   ---------------------";

            internal const string PlayingFieldBottomBorder =
    @"   ---------------------
";
        }

        internal static class Messages
        {
            internal const string Points =
    @"
Score:";

            internal const string Victory =
    @"
Congratulations! You opened all 35 cells with no drop of blood!";

            internal const string Defeat =
@"
Daaayum! You stepped on a mine and died with a score of {0}.";

            internal const string AskUserName =
@"Please provide your name : ";

            internal const string Exit =
    @"Exiting game...";

            internal const string EmptyScoreboard =
@"The scoreboard is empty!
";

            internal const string AskInput =
    @"Your turn: Provide row and column in format 'r c' ";

            internal const string BadInputError =
    @"
Error! Invalid Command!
";

            internal const string Welcome =
    @"        Let's play 'Minesweeper'!

Try your luck and find the fields with no mines.

Command 'top' will show the high scores,
        'restart' will start a new game,
        'exit' will exit the game

                Good Luck!";

            internal const string ExitProgram =
    @"Made in Bulgaria - Thanks for playing!
               Good bye!";
        }
    }
}
